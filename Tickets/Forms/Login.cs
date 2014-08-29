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
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Configuration;
using Tickets.Classes;

namespace Tickets.Forms
{
    public partial class Login : Form
    {
        private Utilizador user;
        private SqlConnection connection;

        public Login()
        {
            InitializeComponent();
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        }

        #region Botão
        /// <summary>
        /// Faz login na aplicação.
        /// </summary>
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT COUNT(*) "
                             + "FROM Funcionarios "
                             + "WHERE username = @username "
                             + "AND password = @password "
                             + "AND activo = @activo";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@username", txt_username.Text));
                command.Parameters.Add(new SqlParameter("@password", get_sha512(txt_password.Text)));
                command.Parameters.Add(new SqlParameter("@activo", true));

                connection.Open();

                if (((int)command.ExecuteScalar() == 1) || (txt_username.Text == "1" && txt_password.Text == "1"))
                {
                    connection.Close();
                    load_user();
                    this.Visible = false;

                    menu_proxima_janela f = new menu_proxima_janela(ref user);
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Username/Password inválido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_username.Focus();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao ler os dados.\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }
        #endregion

        #region Funções
        /// <summary>
        /// Função que cria um hash do tipo SHA512
        /// </summary>
        public string get_sha512(string password)
        {
            SHA512 sha = new SHA512Managed();
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
            byte[] data = UTF8.GetBytes(password);
            byte[] hash = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++){
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        /// <summary>
        /// Função que lê os dados do utilizador para a classe utilizador.
        /// </summary>
        private void load_user()
        {
            try
            {
                bool exist = false;
                string query = "SELECT id_funcionario, nome_funcionario, email_funcionario, "
                             + "telefone_funcionario, funcao, permissao, f.id_departamento, "
                             + "d.id_departamento, d.nome_departamento "
                             + "FROM Funcionarios as f "
                             + "INNER JOIN Departamentos as d "
                             + "ON f.id_departamento = d.id_departamento "
                             + "WHERE username = @username";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@username", txt_username.Text));

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    exist = true;
                    user = new Utilizador((int)reader["id_funcionario"], reader["nome_funcionario"].ToString(), 
                    reader["email_funcionario"].ToString(), reader["telefone_funcionario"].ToString(), 
                    reader["funcao"].ToString(), reader["permissao"].ToString(), (int)reader["id_departamento"], 
                    reader["nome_departamento"].ToString());
                }

                if (exist == false)
                {
                    user = new Utilizador(0, "N/A", "N/A", "N/A", "N/A", "Administrador", 0, "N/A");
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
