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
using Tickets.Classes;
using System.Data.SqlClient;
using System.Configuration;

namespace Tickets.Forms
{
    partial class VisualizarTickets : Form
    {
        private Utilizador user;
        private SqlConnection connection;

        public VisualizarTickets(ref Utilizador vuser)
        {
            InitializeComponent();
            user = vuser;
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        }

        #region Form
        /// <summary>
        /// Adiciona os headers e chama a função que preenche a grid tickets e updates.
        /// </summary>
        private void VisualizarTickets_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.Clone() as Icon;

            // grid tickets
            grid_tickets.ColumnCount = 10;
            grid_tickets.Columns[0].Name = "ID Ticket";
            grid_tickets.Columns[1].Name = "Funcionário";
            grid_tickets.Columns[2].Name = "Assunto";
            grid_tickets.Columns[3].Name = "Comentário Ticket";
            grid_tickets.Columns[4].Name = "Departamento";
            grid_tickets.Columns[5].Name = "Prioridade Funcionário";
            grid_tickets.Columns[6].Name = "Data Início";
            grid_tickets.Columns[7].Name = "Data Fim";
            grid_tickets.Columns[8].Name = "Prioridade Gestor";
            grid_tickets.Columns[9].Name = "Estado";

            // grid updates
            grid_updates.ColumnCount = 4;
            grid_updates.Columns[0].Name = "ID Funcionário";
            grid_updates.Columns[1].Name = "Funcionário";
            grid_updates.Columns[2].Name = "Comentário Update";
            grid_updates.Columns[3].Name = "Data Update";

            actualiza_grid_tickets();
            if (grid_tickets.RowCount != 0)
            {
                actualiza_grid_updates(grid_tickets.Rows[grid_tickets.SelectedRows[0].Index].Cells["ID Ticket"].Value.ToString());
            }
            else
            {
                btn_adicionarupdate.Enabled = false;
            }
        }

        /// <summary>
        /// Bloqueia a escrita nas combobox.
        /// </summary>
        private void cb_filtro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Da refresh na grid e mantem a posição selecionada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VisualizarTickets_Activated(object sender, EventArgs e)
        {
            int index = -1;
            if (grid_tickets.RowCount != 0)
            {
                index = grid_tickets.SelectedCells[0].RowIndex;
            }
            actualiza_grid_tickets();

            if (grid_tickets.RowCount != 0)
            {
                if ((grid_tickets.RowCount >= index) && (index > 0))
                {
                    grid_tickets.FirstDisplayedScrollingRowIndex = index;
                    grid_tickets.Rows[index].Selected = true;
                }
                actualiza_grid_updates(grid_tickets.Rows[grid_tickets.SelectedRows[0].Index].Cells["ID Ticket"].Value.ToString());
            }
        }
        #endregion

        #region Botões
        /// <summary>
        /// Actualiza ao mudar o filtro.
        /// </summary>
        private void cb_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualiza_grid_tickets();

            if (grid_tickets.RowCount != 0)
            {
                if (grid_tickets.Rows[grid_tickets.SelectedRows[0].Index].Cells["Estado"].Value.ToString() == "Fechado")
                {
                    btn_adicionarupdate.Enabled = false;
                }
                else
                {
                    btn_adicionarupdate.Enabled = true;
                }

                actualiza_grid_updates(grid_tickets.Rows[grid_tickets.SelectedRows[0].Index].Cells["ID Ticket"].Value.ToString());
            }
            else
            {
                btn_adicionarupdate.Enabled = false;
            }
        }

        /// <summary>
        /// Chama a função que adiciona cor às grids sempre que se escreve.
        /// </summary>
        private void txt_procurar_TextChanged(object sender, EventArgs e)
        {
            datagrid_color();
        }

        /// <summary>
        /// Abre o form AdicionarTickets no modo de adicção.
        /// </summary>
        private void btn_adicionarticket_Click(object sender, EventArgs e)
        {
            AdicionarTickets f = new AdicionarTickets(ref user);
            f.MdiParent = ParentForm;
            f.Show();
        }

        /// <summary>
        /// Abre o form AdicionarUpdate no modo de adicção.
        /// </summary>
        private void btn_adicionarupdate_Click(object sender, EventArgs e)
        {
            AdicionarUpdates f = new AdicionarUpdates(ref user, grid_tickets.Rows[grid_tickets.SelectedRows[0].Index].Cells["ID Ticket"].Value.ToString());
            f.MdiParent = ParentForm;
            f.Show();
        }
        #endregion

        #region Grid
        /// <summary>
        /// Ao clicar na celula os updates do ticket são apresentados na grid abaixo.
        /// Desactiva o botão update se o tichet estiver fechado
        /// </summary>
        private void grid_tickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid_tickets.RowCount != 0)
            {
                actualiza_grid_updates(grid_tickets.Rows[grid_tickets.SelectedRows[0].Index].Cells["ID Ticket"].Value.ToString());

                if (grid_tickets.Rows[grid_tickets.SelectedRows[0].Index].Cells["Estado"].Value.ToString() == "Fechado")
                {
                    btn_adicionarupdate.Enabled = false;
                }
                else
                {
                    btn_adicionarupdate.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Ao clicar no controlo, restaura a grid updates.
        /// </summary>
        private void grid_tickets_Click(object sender, EventArgs e)
        {
            grid_updates.Rows.Clear();
        }

        /// <summary>
        /// Abre o form AdicionarTickets em modo de leitura.
        /// </summary>
        private void grid_tickets_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid_tickets.RowCount != 0)
            {
                AdicionarTickets f = new AdicionarTickets(ref user, grid_tickets.Rows[grid_tickets.SelectedRows[0].Index].Cells["ID Ticket"].Value.ToString(), true);
                f.MdiParent = ParentForm;
                f.Show();
            }
        }

        /// <summary>
        /// Abre o form AdicionarUpdates em modo de leitura.
        /// </summary>
        private void grid_updates_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid_updates.RowCount != 0)
            {
                AdicionarUpdates f = new AdicionarUpdates(grid_updates.Rows[grid_updates.SelectedRows[0].Index].Cells["ID Funcionário"].Value.ToString(),
                Convert.ToDateTime(grid_updates.Rows[grid_updates.SelectedRows[0].Index].Cells["Data Update"].Value));
                f.MdiParent = ParentForm;
                f.Show();
            }
        }
        #endregion

        #region Funções
        /// <summary>
        /// Preenche a grid tickets.
        /// </summary>
        private void actualiza_grid_tickets()
        {
            grid_tickets.Rows.Clear();
            grid_updates.Rows.Clear();

            try
            {
                string query = "";

                if (cb_filtro.Text == "Tickets atribuídos")
                {
                    query = "SELECT t.*, f.nome_funcionario "
                          + "FROM Grupos as g "
                          + "INNER JOIN Tickets as t "
                          + "ON g.id_ticket = t.id_ticket "
                          + "INNER JOIN Funcionarios as f "
                          + "ON t.id_funcionario = f.id_funcionario "
                          + "WHERE g.id_funcionario = @id_funcionario "
                          + "AND t.estado like 'Aberto' "
                          + "ORDER BY data_inicio DESC";
                }
                else if (cb_filtro.Text == "Os meus tickets")
                {
                    query = "SELECT * "
                          + "FROM Tickets "
                          + "WHERE id_funcionario = @id_funcionario "
                          + "ORDER BY data_inicio DESC";
                }

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@id_funcionario", user.get_id()));

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string[] row = new string[grid_tickets.ColumnCount];
                    row[0] = reader["id_ticket"].ToString();
                    if (cb_filtro.Text == "Tickets atribuídos")
                    {
                        row[1] = reader["nome_funcionario"].ToString();
                    }
                    else if (cb_filtro.Text == "Os meus tickets")
                    {
                        row[1] = user.get_nome();
                    }
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
        /// Preenche a grid updates.
        /// </summary>
        private void actualiza_grid_updates(string id_ticket)
        {
            grid_updates.Rows.Clear();

            try
            {
                string query = "SELECT u.*, f.nome_funcionario "
                             + "FROM Updates as u "
                             + "INNER JOIN Funcionarios as f "
                             + "ON u.id_funcionario = f.id_funcionario "
                             + "WHERE u.id_ticket = @id_ticket "
                             + "ORDER BY data_update DESC";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@id_ticket", id_ticket));

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string[] row = new string[grid_tickets.ColumnCount];
                    row[0] = reader["id_funcionario"].ToString();
                    row[1] = reader["nome_funcionario"].ToString();
                    row[2] = reader["comentario_update"].ToString();
                    row[3] = reader["data_update"].ToString();

                    grid_updates.Rows.Add(row);
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
        /// Coloca cor na grid
        /// </summary>
        public void datagrid_color()
        {
            string search = txt_procurar.Text;
            DataGridView grid1 = grid_tickets;
            DataGridView grid2 = grid_updates;

            search = search.ToUpper();
            for (int x = 0; x < grid1.Rows.Count; x++)
            {
                for (int y = 0; y < grid1.Rows[x].Cells.Count; y++)
                {
                    if (grid1.Rows[x].Cells[y].Value.ToString().ToUpper().Contains(search) && search != "")
                    {
                        grid1.Rows[x].Cells[y].Style.BackColor = System.Drawing.Color.SpringGreen;
                    }
                    else
                    {
                        grid1.Rows[x].Cells[y].Style.BackColor = System.Drawing.Color.WhiteSmoke;
                    }
                }
            }

            for (int x = 0; x < grid2.Rows.Count; x++)
            {
                for (int y = 0; y < grid2.Rows[x].Cells.Count; y++)
                {
                    if (grid2.Rows[x].Cells[y].Value.ToString().ToUpper().Contains(search) && search != "")
                    {
                        grid2.Rows[x].Cells[y].Style.BackColor = System.Drawing.Color.SpringGreen;
                    }
                    else
                    {
                        grid2.Rows[x].Cells[y].Style.BackColor = System.Drawing.Color.WhiteSmoke;
                    }
                }
            }
        }
        #endregion

    }
}
