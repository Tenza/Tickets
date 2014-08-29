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
    partial class AdicionarTickets : Form
    {
        private Utilizador user;
        private SqlConnection connection;
        private string id_ticket;
        private bool ler_ticket;

        public AdicionarTickets(ref Utilizador vuser, string vid_ticket = "", bool vler_ticket = false)
        {
            InitializeComponent();
            user = vuser;
            id_ticket = vid_ticket;
            ler_ticket = vler_ticket;
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        }

        #region Form
        /// <summary>
        /// Verifica se o form abre em modo de leitura ou de adição.
        /// </summary>
        private void AdicionarTickets_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.Clone() as Icon;

            if (ler_ticket)
            {
                this.Text = "Detalhes do Ticket";
                txt_assunto.ReadOnly = true;
                txt_comentario.ReadOnly = true;
                cb_prioridade.Enabled = false;
                cb_departamento.Enabled = false;
                btn_adicionar.Text = "Fechar";

                preenche_form();
            }
        }

        /// <summary>
        /// Ao clicar no form, faz focus na textbox
        /// </summary>
        private void AdicionarTickets_Activated(object sender, EventArgs e)
        {
            if (!ler_ticket)
            {
                obtem_departamentos();
                txt_assunto.Focus();
            }
        }

        /// <summary>
        /// Bloqueia a escrita nas combobox.
        /// </summary>
        private void txt_prioridade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_departamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        #endregion

        #region Botão
        /// <summary>
        /// Adiciona um ticket.
        /// </summary>
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (btn_adicionar.Text == "Adicionar")
            {
                if (valida_form())
                {
                    try
                    {
                        string query = "INSERT INTO Tickets "
                                     + "VALUES (@id_funcionario, @assunto, @comentario_ticket, @nome_departamento, "
                                     + "@prioridade_funcionario, @data_inicio, @data_fim, @prioridade_gestor, @estado)";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.Add(new SqlParameter("@id_funcionario", user.get_id()));
                        command.Parameters.Add(new SqlParameter("@assunto", txt_assunto.Text));
                        command.Parameters.Add(new SqlParameter("@comentario_ticket", txt_comentario.Text));
                        command.Parameters.Add(new SqlParameter("@nome_departamento", cb_departamento.Text));
                        command.Parameters.Add(new SqlParameter("@prioridade_funcionario", cb_prioridade.Text));
                        command.Parameters.Add(new SqlParameter("@data_inicio", DateTime.Now));
                        command.Parameters.Add(new SqlParameter("@data_fim", DBNull.Value));
                        command.Parameters.Add(new SqlParameter("@prioridade_gestor", DBNull.Value));
                        command.Parameters.Add(new SqlParameter("@estado", "Pendente"));

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        reset_form();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao inserir os dados.\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                    }
                }
            }
            else if (btn_adicionar.Text == "Fechar")
            {
                this.Close();
            }
        }
        #endregion

        #region Funções
        /// <summary>
        /// Função que valida os dados inseridos.
        /// </summary>
        private bool valida_form()
        {
            string error = "";

            if (txt_assunto.Text == "" || txt_comentario.Text == "" || cb_prioridade.Text == "" || cb_departamento.Text == "")
            {
                error += "Todos os campos são obrigatórios.\n";
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
                cb_departamento.Text = "";

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
        /// Restaura as predefinições.
        /// </summary>
        private void reset_form()
        {
            txt_assunto.Text = "";
            txt_comentario.Text = "";
            cb_prioridade.Text = "";
            cb_departamento.Text = "";
            txt_assunto.Focus();
        }

        /// <summary>
        /// Carrega os dados para a form em modo de leitura.
        /// </summary>
        private void preenche_form()
        {
            try
            {
                string query = "SELECT * "
                             + "FROM Tickets " 
                             + "WHERE id_ticket = @id_ticket";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@id_ticket", id_ticket));

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txt_assunto.Text = reader["assunto"].ToString();
                    txt_comentario.Text = reader["comentario_ticket"].ToString();
                    cb_prioridade.Text = reader["prioridade_funcionario"].ToString();
                    cb_departamento.Text = reader["nome_departamento"].ToString();
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