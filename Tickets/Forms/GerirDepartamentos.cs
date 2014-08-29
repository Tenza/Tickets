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
using System.Text.RegularExpressions;

namespace Tickets.Forms
{
    public partial class GerirDepartamentos : Form
    {
        private SqlConnection connection;

        public GerirDepartamentos()
        {
            InitializeComponent();
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        }

        #region Form
        /// <summary>
        /// Adiciona os headers e chama a função que preenche a grid.
        /// </summary>
        private void AdicionarDepartamentos_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.Clone() as Icon;

            grid_departamentos.ColumnCount = 4;
            grid_departamentos.Columns[0].Name = "ID";
            grid_departamentos.Columns[1].Name = "Nome";
            grid_departamentos.Columns[2].Name = "Email";
            grid_departamentos.Columns[3].Name = "Telefone";

            atualiza_grid();
        }

        /// <summary>
        /// Ao clicar no form, chama a função que restaura o form.
        /// </summary>
        private void AdicionarDepartamentos_Click(object sender, EventArgs e)
        {
            reset_form();
            txt_nome.Focus();
        }
        #endregion

        #region Botão
        /// <summary>
        /// Adiciona/Edita um departamento.
        /// </summary>
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (valida_form())
            {
                if (btn_adicionar.Text == "Adicionar")
                {
                    try
                    {
                        string query = "INSERT INTO Departamentos " 
                                     + "VALUES (@nome_departamento, @email_departamento, @telefone_departamento)";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.Add(new SqlParameter("@nome_departamento", txt_nome.Text));
                        command.Parameters.Add(new SqlParameter("@email_departamento", txt_email.Text));
                        command.Parameters.Add(new SqlParameter("@telefone_departamento", txt_telefone.Text));

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
                        string query = "UPDATE Departamentos "
                                     + "SET nome_departamento=@nome_departamento, email_departamento=@email_departamento, telefone_departamento=@telefone_departamento " 
                                     + "WHERE id_departamento=@id_departamento";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.Add(new SqlParameter("@id_departamento", grid_departamentos.Rows[grid_departamentos.SelectedRows[0].Index].Cells["ID"].Value.ToString()));
                        command.Parameters.Add(new SqlParameter("@nome_departamento", txt_nome.Text));
                        command.Parameters.Add(new SqlParameter("@email_departamento", txt_email.Text));
                        command.Parameters.Add(new SqlParameter("@telefone_departamento", txt_telefone.Text));

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
        private void grid_departamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid_departamentos.RowCount != 0)
            {
                txt_nome.Text = grid_departamentos.Rows[grid_departamentos.SelectedRows[0].Index].Cells["Nome"].Value.ToString();
                txt_email.Text = grid_departamentos.Rows[grid_departamentos.SelectedRows[0].Index].Cells["Email"].Value.ToString();
                txt_telefone.Text = grid_departamentos.Rows[grid_departamentos.SelectedRows[0].Index].Cells["Telefone"].Value.ToString();
                btn_adicionar.Text = "Editar";
            }
        }

        /// <summary>
        /// Elimina registo com duplo clique.
        /// </summary>
        private void grid_departamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid_departamentos.RowCount != 0)
            {
                bool allow = true;
                string query = "SELECT COUNT(*) "
                             + "FROM Funcionarios "
                             + "WHERE id_departamento=@id_departamento";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@id_departamento", grid_departamentos.Rows[grid_departamentos.SelectedRows[0].Index].Cells["ID"].Value.ToString()));

                connection.Open();
                if ((int)command.ExecuteScalar() > 0)
                {
                    allow = false;
                }
                connection.Close();

                if (allow)
                {
                    DialogResult result = MessageBox.Show("Deseja eliminar \"" + grid_departamentos.Rows[grid_departamentos.SelectedRows[0].Index].Cells["Nome"].Value.ToString() + "\" do registo?", "Eliminar registo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            string query2 = "DELETE FROM Departamentos "
                                          + "WHERE id_departamento=@id_departamento";

                            SqlCommand command2 = new SqlCommand(query2, connection);
                            command2.Parameters.Add(new SqlParameter("@id_departamento", grid_departamentos.Rows[grid_departamentos.SelectedRows[0].Index].Cells["ID"].Value.ToString()));

                            connection.Open();
                            command2.ExecuteNonQuery();
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocorreu um erro ao eliminar o registo.\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            connection.Close();
                        }

                        atualiza_grid();
                        reset_form();
                    }
                }
                else
                {
                    MessageBox.Show("Não é possível eliminar um departamento que contenha funcionários.\nPara poder eliminar este departamento em primeiro tem que mover todos os seus funcionários.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Ao clicar no controlo, chama a função que restaura o form.
        /// </summary>
        private void grid_departamentos_Click(object sender, EventArgs e)
        {
            reset_form();
            txt_nome.Focus();
        }
        #endregion

        #region Funções
        /// <summary>
        /// Preenche a grid.
        /// </summary>
        private void atualiza_grid()
        {
            grid_departamentos.Rows.Clear();

            try
            {
                string query = "SELECT * "
                             + "FROM Departamentos";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string[] row = new string[grid_departamentos.ColumnCount];
                    row[0] = reader["id_departamento"].ToString();
                    row[1] = reader["nome_departamento"].ToString();
                    row[2] = reader["email_departamento"].ToString();
                    row[3] = reader["telefone_departamento"].ToString();

                    grid_departamentos.Rows.Add(row);
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
        /// Função que valida os dados inseridos.
        /// </summary>
        private bool valida_form()
        {
            string error = "";

            if (txt_nome.Text != "" && txt_email.Text != "")
            {
                if (!Regex.IsMatch(txt_email.Text,
                @"^(?("")(""[^""]+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$"))
                {
                    error += "Email inválido\n";
                }
            }
            else
            {
                error += "O campo \"Nome\" e \"Email\" são obrigatórios.\n";
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
            txt_nome.Text = "";
            txt_email.Text = "";
            txt_telefone.Text = "";
            btn_adicionar.Text = "Adicionar";
        }
        #endregion

    }
}
