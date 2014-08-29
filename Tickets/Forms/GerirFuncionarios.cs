/*
 * Tickets
 * Copyright (C) 2011 Filipe Carvalho
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Tickets.Forms
{
    public partial class GerirFuncionarios : Form
    {
        private SqlConnection connection;

        public GerirFuncionarios()
        {
            InitializeComponent();
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        }

        #region Form
        /// <summary>
        /// Adiciona os headers e chama a função que preenche a grid.
        /// </summary>
        private void AdicionarFuncionarios_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.Clone() as Icon;

            grid_funcionarios.ColumnCount = 9;
            grid_funcionarios.Columns[0].Name = "ID";
            grid_funcionarios.Columns[1].Name = "Username";
            grid_funcionarios.Columns[2].Name = "Nome";
            grid_funcionarios.Columns[3].Name = "Email";
            grid_funcionarios.Columns[4].Name = "Telefone";
            grid_funcionarios.Columns[5].Name = "Função";
            grid_funcionarios.Columns[6].Name = "Departamento";
            grid_funcionarios.Columns[7].Name = "Permissão";
            grid_funcionarios.Columns[8].Name = "Activo";

            obtem_departamentos();
            atualiza_grid();
            cb_departamento.Text = "";
        }

        /// <summary>
        /// Dá reload à combobox no focos do form.
        /// Pois podem ter sido modificados enquanto a janela estava aberta.
        /// </summary>
        private void AdicionarFuncionarios_Activated(object sender, EventArgs e)
        {
            obtem_departamentos();
            atualiza_grid();
            cb_departamento.Text = "";
        }

        /// <summary>
        /// Actualiza a tabela ao mudar a opção.
        /// </summary>
        private void ckb_activos_CheckedChanged(object sender, EventArgs e)
        {
            atualiza_grid();
            reset_form();
        }

        /// <summary>
        /// Ao clicar no form, chama a função que restaura o form.
        /// </summary>
        private void AdicionarFuncionarios_Click(object sender, EventArgs e)
        {
            reset_form();
        }

        /// <summary>
        /// Bloqueia a escrita nas combobox.
        /// </summary>
        private void cb_departamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_permissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_activo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        #endregion

        #region Botão
        /// <summary>
        /// Adiciona/Edita um funcionario.
        /// </summary>
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (valida_form())
            {
                if (btn_adicionar.Text == "Adicionar")
                {
                    try
                    {
                        string query = "INSERT INTO Funcionarios "
                                     + "VALUES (@id_departamento, @username, @password, @nome_funcionario, " 
                                     + "@email_funcionario, @telefone_funcionario, @funcao, @permissao, @activo)";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.Add(new SqlParameter("@id_departamento", cb_departamento.SelectedValue));
                        command.Parameters.Add(new SqlParameter("@username", txt_username.Text));
                        command.Parameters.Add(new SqlParameter("@password", get_sha512(txt_password.Text)));
                        command.Parameters.Add(new SqlParameter("@nome_funcionario", txt_nome.Text));
                        command.Parameters.Add(new SqlParameter("@email_funcionario", txt_email.Text));
                        command.Parameters.Add(new SqlParameter("@telefone_funcionario", txt_telefone.Text));
                        command.Parameters.Add(new SqlParameter("@funcao", txt_funcao.Text));
                        command.Parameters.Add(new SqlParameter("@permissao", cb_permissao.Text));
                        command.Parameters.Add(new SqlParameter("@activo", true));

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao inserir os dados.\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                    }
                }
                else if (btn_adicionar.Text == "Editar")
                {
                    try
                    {
                        string query = "";
                        if (txt_password.Text == "")
                        {
                            query = "UPDATE Funcionarios "
                                  + "SET id_departamento=@id_departamento, username=@username, "
                                  + "nome_funcionario=@nome_funcionario, email_funcionario=@email_funcionario, "
                                  + "telefone_funcionario=@telefone_funcionario, funcao=@funcao, permissao=@permissao, activo=@activo " 
                                  + "WHERE id_funcionario=@id_funcionario";
                        }
                        else
                        {
                            query = "UPDATE Funcionarios "
                                  + "SET id_departamento=@id_departamento, username=@username, "
                                  + "password=@password, nome_funcionario=@nome_funcionario, "
                                  + "email_funcionario=@email_funcionario, telefone_funcionario=@telefone_funcionario, "
                                  + "funcao=@funcao, permissao=@permissao, activo=@activo " 
                                  + "WHERE id_funcionario=@id_funcionario";
                        }
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.Add(new SqlParameter("@id_funcionario", grid_funcionarios.Rows[grid_funcionarios.SelectedRows[0].Index].Cells["ID"].Value.ToString()));
                        command.Parameters.Add(new SqlParameter("@id_departamento", cb_departamento.SelectedValue));
                        command.Parameters.Add(new SqlParameter("@username", txt_username.Text));
                        command.Parameters.Add(new SqlParameter("@password", get_sha512(txt_password.Text)));
                        command.Parameters.Add(new SqlParameter("@nome_funcionario", txt_nome.Text));
                        command.Parameters.Add(new SqlParameter("@email_funcionario", txt_email.Text));
                        command.Parameters.Add(new SqlParameter("@telefone_funcionario", txt_telefone.Text));
                        command.Parameters.Add(new SqlParameter("@funcao", txt_funcao.Text));
                        command.Parameters.Add(new SqlParameter("@permissao", cb_permissao.Text));
                        command.Parameters.Add(new SqlParameter("@activo", true));

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao editar o registo.\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                    }
                }

                atualiza_grid();
                reset_form();
            }
        }
        #endregion

        #region Grid
        /// <summary>
        /// Ao clicar na celula os dados do form são preenchidos.
        /// </summary>
        private void grid_funcionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid_funcionarios.RowCount != 0)
            {
                txt_username.Text = grid_funcionarios.Rows[grid_funcionarios.SelectedRows[0].Index].Cells["Username"].Value.ToString();
                txt_nome.Text = grid_funcionarios.Rows[grid_funcionarios.SelectedRows[0].Index].Cells["Nome"].Value.ToString();
                txt_email.Text = grid_funcionarios.Rows[grid_funcionarios.SelectedRows[0].Index].Cells["Email"].Value.ToString();
                txt_telefone.Text = grid_funcionarios.Rows[grid_funcionarios.SelectedRows[0].Index].Cells["Telefone"].Value.ToString();
                cb_departamento.Text = grid_funcionarios.Rows[grid_funcionarios.SelectedRows[0].Index].Cells["Departamento"].Value.ToString();
                txt_funcao.Text = grid_funcionarios.Rows[grid_funcionarios.SelectedRows[0].Index].Cells["Função"].Value.ToString();
                cb_permissao.Text = grid_funcionarios.Rows[grid_funcionarios.SelectedRows[0].Index].Cells["Permissão"].Value.ToString();
                btn_adicionar.Text = "Editar";
            }
        }

        /// <summary>
        /// Elimina registo com duplo clique.
        /// </summary>
        private void grid_funcionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid_funcionarios.RowCount != 0)
            {
                DialogResult result = DialogResult.Ignore;
                string activo = grid_funcionarios.Rows[grid_funcionarios.SelectedRows[0].Index].Cells["Activo"].Value.ToString();

                if (activo == "Sim")
                {
                    result = MessageBox.Show("Deseja desactivar \"" + grid_funcionarios.Rows[grid_funcionarios.SelectedRows[0].Index].Cells["Nome"].Value.ToString() + "\" ?", "Desactivar Utilizador", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else if (activo == "Não")
                {
                    result = MessageBox.Show("Deseja reactivar \"" + grid_funcionarios.Rows[grid_funcionarios.SelectedRows[0].Index].Cells["Nome"].Value.ToString() + "\" ?", "Reactivar Utilizador", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string query = "UPDATE Funcionarios "
                                     + "SET activo=@activo "
                                     + "WHERE id_funcionario=@id_funcionario";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.Add(new SqlParameter("@id_funcionario", grid_funcionarios.Rows[grid_funcionarios.SelectedRows[0].Index].Cells["ID"].Value.ToString()));

                        if (activo == "Sim")
                        {
                            command.Parameters.Add(new SqlParameter("@activo", false));
                        }
                        else if (activo == "Não")
                        {
                            command.Parameters.Add(new SqlParameter("@activo", true));
                        }

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao desactivar o registo.\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                    }

                    atualiza_grid();
                    reset_form();
                }
            }
        }

        /// <summary>
        /// Ao clicar no controlo, chama a função que restaura o form.
        /// </summary>
        private void grid_funcionarios_Click(object sender, EventArgs e)
        {
            reset_form();
        }
        #endregion

        #region Funções
        /// <summary>
        /// Preenche a grid.
        /// </summary>
        private void atualiza_grid()
        {
            grid_funcionarios.Rows.Clear();

            try
            {
                string query = "SELECT * " 
                             + "FROM Funcionarios";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (ckb_activos.Checked || (reader["activo"].ToString() == "True"))
                    {
                        string[] row = new string[grid_funcionarios.ColumnCount];
                        row[0] = reader["id_funcionario"].ToString();
                        row[1] = reader["username"].ToString();
                        row[2] = reader["nome_funcionario"].ToString();
                        row[3] = reader["email_funcionario"].ToString();
                        row[4] = reader["telefone_funcionario"].ToString();
                        row[5] = reader["funcao"].ToString();
                        row[6] = obtem_nome_dep(reader["id_departamento"].ToString());
                        row[7] = reader["permissao"].ToString();

                        string x = reader["activo"].ToString();
                        if (x == "True")
                        {
                            row[8] = "Sim";
                        }
                        else if (x == "False")
                        {

                            row[8] = "Não";
                        }

                        grid_funcionarios.Rows.Add(row);
                    }
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao ler os dados.\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        /// <summary>
        /// Adiciona departamentos à combobox.
        /// </summary>
        private void obtem_departamentos()
        {
            try
            {
                string query = "SELECT id_departamento, nome_departamento " 
                             + "FROM Departamentos";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                DataTable table = new DataTable();
                table.Columns.Add("nome_departamento", typeof(string));
                table.Columns.Add("id_departamento", typeof(int));

                while (reader.Read())
                {
                    table.Rows.Add(reader["nome_departamento"].ToString(), reader["id_departamento"]);
                }

                cb_departamento.DataSource = table;
                cb_departamento.DisplayMember = "nome_departamento";
                cb_departamento.ValueMember = "id_departamento";

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao ler os dados.\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        /// <summary>
        /// Obtem o nome correspondente ao ID.
        /// </summary>
        private string obtem_nome_dep(string id)
        {
            for (int i = 0; i < cb_departamento.Items.Count; i++)
            {
                cb_departamento.SelectedIndex = i;
                if (cb_departamento.SelectedValue.ToString() == id)
                {
                    DataRowView drow = (DataRowView)cb_departamento.SelectedItem;
                    return drow.Row.ItemArray[0].ToString();
                }
            }

            return null;
        }

        /// <summary>
        /// Função que cria um hash do tipo SHA512.
        /// </summary>
        public string get_sha512(string password)
        {
            SHA512 sha = new SHA512Managed();
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
            byte[] data = UTF8.GetBytes(password);
            byte[] hash = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        /// <summary>
        /// Função que valida os dados inseridos.
        /// </summary>
        private bool valida_form()
        {
            string error = "";

            if (txt_username.Text != "" && txt_nome.Text != "" && txt_email.Text != "" && txt_funcao.Text != "" && cb_departamento.Text != "" && cb_permissao.Text != "")
            {
                //Testa email
                if (!Regex.IsMatch(txt_email.Text,
                @"^(?("")(""[^""]+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$"))
                {
                    error += "Email inválido\n";
                }

                //Testa username
                try
                {
                    string query = "SELECT COUNT(*) "
                                 + "FROM Funcionarios "
                                 + "WHERE username=@username";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add(new SqlParameter("@username", txt_username.Text));

                    connection.Open();

                    if ((int)command.ExecuteScalar() == 1)
                    {
                        if (btn_adicionar.Text == "Editar")
                        {
                            //Se estiver a editar, aceita o mesmo User.
                            if (txt_username.Text.ToLower() != grid_funcionarios.Rows[grid_funcionarios.SelectedRows[0].Index].Cells["Username"].Value.ToString().ToLower())
                            {
                                error += "Esse username já está em uso.\n";
                            }
                        }
                        else
                        {
                            error += "Esse username já está em uso.\n";
                        }

                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao ler os dados.\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }

            }
            else
            {
                error += "Todos os campos são obrigatórios.\n(À excepção do telefone)\n";
            }

            if (error == "")
            {
                return true;
            }
            else
            {
                MessageBox.Show(error, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        /// <summary>
        /// Restaura as predefinições.
        /// </summary>
        private void reset_form()
        {
            txt_username.Text = "";
            txt_password.Text = "";
            txt_nome.Text = "";
            txt_email.Text = "";
            txt_telefone.Text = "";
            cb_departamento.Text = "";
            txt_funcao.Text = "";
            cb_permissao.Text = "";
            btn_adicionar.Text = "Adicionar";
            txt_username.Focus();
        }
        #endregion

    }
}
