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
    partial class AdicionarUpdates : Form
    {
        private Utilizador user;
        private SqlConnection connection;
        private string id_ticket;
        private string id_funcionario;
        private DateTime data_update;
        private bool ler_ticket;

        public AdicionarUpdates(ref Utilizador vuser, string vid_ticket)
        {
            InitializeComponent();
            user = vuser;
            id_ticket = vid_ticket;
            ler_ticket = false;
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        }

        public AdicionarUpdates(string vid_funcionario, DateTime vdata_update)
        {
            InitializeComponent();
            id_funcionario = vid_funcionario;
            data_update = vdata_update;
            ler_ticket = true;
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        }

        #region Form
        /// <summary>
        /// Verifica se o form abre em modo de leitura ou de adição.
        /// </summary>
        private void AdicionarUpdates_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.Clone() as Icon;

            if (ler_ticket)
            {
                this.Text = "Detalhes do Update";
                txt_comentario.ReadOnly = true;
                btn_enviar.Text = "Fechar";

                preenche_form();
            }
        }

        /// <summary>
        /// Ao clicar no form, faz focus na textbox
        /// </summary>
        private void AdicionarUpdate_Activated(object sender, EventArgs e)
        {
            txt_comentario.Focus();
        }
        #endregion

        #region Botão
        /// <summary>
        /// Adiciona um update.
        /// </summary>
        private void btn_enviar_Click(object sender, EventArgs e)
        {
            if (btn_enviar.Text == "Enviar")
            {
                if (valida_form())
                {
                    try
                    {
                        string query = "INSERT INTO Updates " 
                                     + "VALUES (@id_ticket, @id_funcionario_updates, @comentario_update, @data_update)";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.Add(new SqlParameter("@id_ticket", id_ticket));
                        command.Parameters.Add(new SqlParameter("@id_funcionario_updates", user.get_id()));
                        command.Parameters.Add(new SqlParameter("@comentario_update", txt_comentario.Text));
                        command.Parameters.Add(new SqlParameter("@data_update", DateTime.Now));

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao inserir os dados.\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                    }
                }
            }
            else if (btn_enviar.Text == "Fechar")
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

            if (txt_comentario.Text == "")
            {
                error += "O campo \"Comentário\" é obrigatório.\n";
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
        /// Carrega os dados para a form em modo de leitura.
        /// </summary>
        private void preenche_form()
        {
            try
            {
                string query = "SELECT comentario_update "
                             + "FROM Updates "
                             + "WHERE id_funcionario = @id_funcionario "
                             + "AND (DATEDIFF(s, data_update, @data_update) = 0)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@id_funcionario", id_funcionario));
                command.Parameters.Add(new SqlParameter("@data_update", data_update));

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txt_comentario.Text = reader["comentario_update"].ToString();
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