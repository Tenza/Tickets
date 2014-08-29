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
using Tickets.Classes;

namespace Tickets.Forms
{
    partial class GerirTickets : Form
    {
        private Utilizador user;
        private SqlConnection connection;

        private DataTable table_funcionarios;
        private DataTable table_grupos;

        public GerirTickets(ref Utilizador vuser)
        {
            InitializeComponent();
            user = vuser;
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        }

        #region Form
        private void GerirTickets_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.Clone() as Icon;
            init_tables();

            grid_tickets.ColumnCount = 10;
            grid_tickets.Columns[0].Name = "ID Ticket";
            grid_tickets.Columns[1].Name = "Funcionário";
            grid_tickets.Columns[2].Name = "Assunto";
            grid_tickets.Columns[3].Name = "Comentário";
            grid_tickets.Columns[4].Name = "Departamento";
            grid_tickets.Columns[5].Name = "Prioridade Funcionário";
            grid_tickets.Columns[6].Name = "Data Início";
            grid_tickets.Columns[7].Name = "Data Fim";
            grid_tickets.Columns[8].Name = "Prioridade Atribuída";
            grid_tickets.Columns[9].Name = "Estado";

            atualiza_grid();
            actualiza_listboxs();
        }

        /// <summary>
        /// Reload no focus da form.
        /// </summary>
        private void GerirTickets_Activated(object sender, EventArgs e)
        {
            atualiza_grid();
            if (cb_filtro.Text != "Pendente")
            {
                actualiza_listboxs();
            }
        }

        /// <summary>
        /// Bloqueia a escrita nas combobox.
        /// </summary>
        private void cb_prioridade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_estado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_filtro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Restaura as definições dependendo do filtro
        /// </summary>
        private void cb_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            atualiza_grid();

            if (cb_filtro.Text == "Pendente")
            {
                actualiza_listboxs();
                lb_funcionarios.Enabled = true;
                lb_grupos.Enabled = true;
                cb_prioridade.Enabled = true;
                btn_aplicar.Enabled = true;
                btn_aplicar.Text = "Abrir Ticket";
            }
            else if (cb_filtro.Text == "Aberto")
            {
                actualiza_listboxs();
                lb_funcionarios.Enabled = true;
                lb_grupos.Enabled = true;
                cb_prioridade.Enabled = true;
                btn_aplicar.Enabled = true;
                btn_aplicar.Text = "Alterar Ticket";
            }
            else if (cb_filtro.Text == "Fechado")
            {
                actualiza_listboxs();
                lb_funcionarios.Enabled = false;
                lb_grupos.Enabled = false;
                cb_prioridade.Enabled = false;
                btn_aplicar.Enabled = false;
            }
        }
        #endregion

        #region ListBox
        /// <summary>
        /// Passa o utilizador selecionado para a outra listbox.
        /// </summary>
        private void lb_funcionarios_DoubleClick(object sender, EventArgs e)
        {
            if (lb_funcionarios.SelectedIndex >= 0)
            {
                DataRowView drow = (DataRowView)lb_funcionarios.SelectedItem;
                table_grupos.Rows.Add(drow.Row.ItemArray[0].ToString(), drow.Row.ItemArray[1].ToString());

                table_funcionarios.Rows.RemoveAt(lb_funcionarios.SelectedIndex);
            }
        }

        /// <summary>
        /// Passa o utilizador selecionado para a outra listbox.
        /// </summary>
        private void lb_grupos_DoubleClick(object sender, EventArgs e)
        {
            if (lb_grupos.SelectedIndex >= 0)
            {
                DataRowView drow = (DataRowView)lb_grupos.SelectedItem;
                table_funcionarios.Rows.Add(drow.Row.ItemArray[0].ToString(), drow.Row.ItemArray[1].ToString());

                table_grupos.Rows.RemoveAt(lb_grupos.SelectedIndex);
            }
        }
        #endregion

        #region Botão
        /// <summary>
        /// Adiciona/Edita um grupos e tickets.
        /// </summary>
        private void btn_aplicar_Click(object sender, EventArgs e)
        {
            if (valida_form())
            {
                string id_ticket = grid_tickets.Rows[grid_tickets.SelectedRows[0].Index].Cells["ID Ticket"].Value.ToString();

                if (cb_filtro.Text == "Pendente")
                {
                    try
                    {
                        string query = "UPDATE Tickets "
                                     + "SET prioridade_gestor = @prioridade_gestor, estado = @estado "
                                     + "WHERE id_ticket = @id_ticket";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.Add(new SqlParameter("@id_ticket", id_ticket));
                        command.Parameters.Add(new SqlParameter("@prioridade_gestor", cb_prioridade.Text));
                        command.Parameters.Add(new SqlParameter("@estado", "Aberto"));

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        //-----

                        for (int i = 0; i < lb_grupos.Items.Count; i++)
                        {
                            lb_grupos.SelectedIndex = i;
                            DataRowView drow = (DataRowView)lb_grupos.SelectedItem;

                            string query2 = "INSERT INTO Grupos "
                                          + "VALUES (@id_ticket, @id_funcionario)";

                            SqlCommand command2 = new SqlCommand(query2, connection);
                            command2.Parameters.Add(new SqlParameter("@id_ticket", id_ticket));
                            command2.Parameters.Add(new SqlParameter("@id_funcionario", drow.Row.ItemArray[1].ToString()));

                            connection.Open();
                            command2.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao criar o registo.\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                    }
                }
                else if (cb_filtro.Text == "Aberto")
                {
                    try
                    {
                        string query = "UPDATE Tickets "
                                     + "SET prioridade_gestor = @prioridade_gestor "
                                     + "WHERE id_ticket = @id_ticket";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.Add(new SqlParameter("@id_ticket", id_ticket));
                        command.Parameters.Add(new SqlParameter("@prioridade_gestor", cb_prioridade.Text));

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        //-----

                        string query2 = "DELETE FROM Grupos "
                                      + "WHERE id_ticket = @id_ticket";

                        SqlCommand command2 = new SqlCommand(query2, connection);
                        command2.Parameters.Add(new SqlParameter("@id_ticket", id_ticket));

                        connection.Open();
                        command2.ExecuteNonQuery();
                        connection.Close();

                        //---

                        for (int i = 0; i < lb_grupos.Items.Count; i++)
                        {
                            lb_grupos.SelectedIndex = i;
                            DataRowView drow = (DataRowView)lb_grupos.SelectedItem;

                            string query3 = "INSERT INTO Grupos "
                                          + "VALUES (@id_ticket, @id_funcionario)";

                            SqlCommand command3 = new SqlCommand(query3, connection);
                            command3.Parameters.Add(new SqlParameter("@id_ticket", id_ticket));
                            command3.Parameters.Add(new SqlParameter("@id_funcionario", drow.Row.ItemArray[1].ToString()));

                            connection.Open();
                            command3.ExecuteNonQuery();
                            connection.Close();
                        }

                        lb_grupos.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao editar o registo.\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                    }
                }

                atualiza_grid();
                actualiza_listboxs();
            }
        }
        #endregion

        #region Grid
        /// <summary>
        /// Ao clicar na celula preenche a listbox dos grupos.
        /// </summary>
        private void grid_tickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cb_filtro.Text != "Pendente")
            {
                actualiza_listboxs();
            }
        }

        /// <summary>
        /// Fecha o ticket.
        /// </summary>
        private void grid_tickets_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((grid_tickets.RowCount != 0) && (cb_filtro.Text == "Aberto"))
            {
                DialogResult result = MessageBox.Show("Deseja fechar este ticket?\nNão serão possiveis novas alterações.", "Fechar Ticket", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string query = "UPDATE Tickets "
                                     + "SET estado = @estado, data_fim = @data_fim "
                                     + "WHERE id_ticket = @id_ticket";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.Add(new SqlParameter("@id_ticket", grid_tickets.Rows[grid_tickets.SelectedRows[0].Index].Cells["ID Ticket"].Value.ToString()));
                        command.Parameters.Add(new SqlParameter("@data_fim", DateTime.Now));
                        command.Parameters.Add(new SqlParameter("@estado", "Fechado"));

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        atualiza_grid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao fechar o registo.\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                    }
                }
            }
            else if ((grid_tickets.RowCount != 0) && ((cb_filtro.Text == "Pendente") || (cb_filtro.Text == "Fechado")))
            {
                AdicionarTickets f = new AdicionarTickets(ref user, grid_tickets.Rows[grid_tickets.SelectedRows[0].Index].Cells["ID Ticket"].Value.ToString(), true);
                f.MdiParent = ParentForm;
                f.Show();     
            }
        }
        #endregion

        #region Funções
        /// <summary>
        /// Preenche a grid.
        /// </summary>
        private void atualiza_grid()
        {
            grid_tickets.Rows.Clear();

            try
            {

                string query = "SELECT t.*, nome_funcionario "
                             + "FROM Tickets as t "
                             + "INNER JOIN Funcionarios as f "
                             + "ON t.id_funcionario = f.id_funcionario "
                             + "WHERE nome_departamento = @nome_departamento "
                             + "AND estado = @estado "
                             + "ORDER BY data_inicio DESC";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@nome_departamento", user.get_nome_dep()));
                command.Parameters.Add(new SqlParameter("@estado", cb_filtro.Text));

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string[] row = new string[grid_tickets.ColumnCount];
                    row[0] = reader["id_ticket"].ToString();
                    row[1] = reader["nome_funcionario"].ToString();
                    row[2] = reader["assunto"].ToString();
                    row[3] = reader["comentario_ticket"].ToString();
                    row[4] = reader["nome_departamento"].ToString();
                    row[5] = reader["prioridade_funcionario"].ToString();
                    row[6] = reader["data_inicio"].ToString();
                    row[7] = reader["data_fim"].ToString();
                    row[8] = reader["prioridade_gestor"].ToString();
                    row[9] = reader["estado"].ToString();

                    grid_tickets.Rows.Add(row);                  
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
        /// Função que inicia as DataTable para usar nas listbox.
        /// </summary>
        private void init_tables()
        {
            table_funcionarios = new DataTable();
            table_grupos = new DataTable();

            table_funcionarios.Columns.Add("nome_funcionario", typeof(string));
            table_funcionarios.Columns.Add("id_funcionario", typeof(int));
            table_grupos.Columns.Add("nome_funcionario", typeof(string));
            table_grupos.Columns.Add("id_funcionario", typeof(int));

            lb_funcionarios.DataSource = table_funcionarios;
            lb_funcionarios.DisplayMember = "nome_funcionario";
            lb_funcionarios.ValueMember = "id_funcionario";

            lb_grupos.DataSource = table_grupos;
            lb_grupos.DisplayMember = "nome_funcionario";
            lb_grupos.ValueMember = "id_funcionario";
        }

        /// <summary>
        /// Função que valida os dados inseridos.
        /// </summary>
        private bool valida_form()
        {
            string error = "";

            if (grid_tickets.RowCount != 0)
            {
                if (cb_prioridade.Text == "" || lb_grupos.Items.Count == 0)
                {
                    error += "Atribua uma prioridade e um grupo de utilizadores ao ticket.\n";
                }
            }
            else
            {
                error += "Não existem mais items.\n";
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
        /// Preenche a listbox dos grupos.
        /// E chama a função actualiza_funcionarios()
        /// </summary>
        private void actualiza_listboxs()
        {
            if ((cb_filtro.Text != "Pendente") && (grid_tickets.RowCount != 0))
            {
                try
                {
                    string query = "SELECT g.id_funcionario, f.id_funcionario, f.nome_funcionario "
                                 + "FROM Grupos as g "
                                 + "INNER JOIN Funcionarios as f "
                                 + "ON g.id_funcionario = f.id_funcionario "
                                 + "WHERE id_ticket = @id_ticket";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add(new SqlParameter("@id_ticket", grid_tickets.Rows[grid_tickets.SelectedRows[0].Index].Cells["ID Ticket"].Value.ToString()));

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    table_grupos.Clear();

                    while (reader.Read())
                    {
                        table_grupos.Rows.Add(reader["nome_funcionario"].ToString(), reader["id_funcionario"]);
                    }

                    reader.Close();
                    connection.Close();

                    actualiza_funcionarios();
                    cb_prioridade.Text = grid_tickets.Rows[grid_tickets.SelectedRows[0].Index].Cells["Prioridade Atribuída"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao ler os dados.\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }
            }
            else
            {
                table_grupos.Clear();
                actualiza_funcionarios();
            }
        }

        /// <summary>
        /// Função que lê os funcionários do departamento correspondente à conta corrente.
        /// A list funcionarios vai ser lida consoante o que estiver na list grupos que é preenchida pela funçao actualiza_listboxs().
        /// Esta função é chamada apenas pela função actualiza_listboxs();
        /// </summary>
        private void actualiza_funcionarios()
        {
            try
            {
                table_funcionarios.Clear();

                string query = "SELECT nome_funcionario, id_funcionario, f.id_departamento, d.id_departamento "
                             + "FROM Funcionarios as f "
                             + "INNER JOIN Departamentos as d "
                             + "ON f.id_departamento = d.id_departamento "
                             + "WHERE nome_departamento = @nome_departamento "
                             + "AND activo = @activo";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@nome_departamento", user.get_nome_dep()));
                command.Parameters.Add(new SqlParameter("@activo", true));

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string id_func = "";
                    string cr_func = reader["id_funcionario"].ToString();
                    bool accept = true;

                    for (int i = 0; i < lb_grupos.Items.Count; i++)
                    {
                        lb_grupos.SelectedIndex = i;
                        DataRowView drow = (DataRowView)lb_grupos.SelectedItem;
                        id_func = drow.Row.ItemArray[1].ToString();
                        lb_grupos.SelectedIndex = 0;

                        if (id_func == cr_func)
                        {
                            accept = false;
                        }
                    }

                    if (accept)
                    {
                        table_funcionarios.Rows.Add(reader["nome_funcionario"].ToString(), reader["id_funcionario"]);
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
        #endregion

    }
}
