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
    partial class menu_proxima_janela : Form
    {
        private Utilizador user;
        private SqlConnection connection;

        public menu_proxima_janela(ref Utilizador vuser)
        {
            InitializeComponent();
            user = vuser;
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        }

        #region Form
        /// <summary>
        /// Preenche informação no painel.
        /// Ao abrir o form, inicia a janela principal de visualizar tickets.
        /// </summary>
        private void Main_Load(object sender, EventArgs e)
        {
            this.menu.Items.Add(new ToolStripSeparator());
            this.menu.Items.Add(new ToolStripMenuItem("&Próxima Janela", null, menu_proximajanela_Click));

            if (user.get_id() == 0)
            {
                menu_funcionario.Visible = false;
                menu_gestor.Visible = false;
            }
            else
            {
                VisualizarTickets f = new VisualizarTickets(ref user);
                f.MdiParent = this;
                f.Show();
                f.WindowState = FormWindowState.Maximized;
            }

            get_painel();

            if (user.get_permissao() == "Funcionário")
            {
                menu_gestor.Visible = false;
                menu_administrador.Visible = false;
            }
            else if (user.get_permissao() == "Gestor")
            {
                menu_administrador.Visible = false;
            }

            //btn_proxima_janela.FlatAppearance.BorderSize = 0;
            //btn_proxima_janela.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            //btn_proxima_janela.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
        }

        /// <summary>
        /// Termina a aplicação ao fechar este form.
        /// </summary>
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Reload do user.
        /// </summary>
        private void menu_Click(object sender, EventArgs e)
        {
            reload_user();
        }

        private void panel_info_Click(object sender, EventArgs e)
        {
            reload_user();
        }
        #endregion

        #region Menu

        //--- Funcionarios
        private void menu_visualizar_Click(object sender, EventArgs e)
        {
            VisualizarTickets f = new VisualizarTickets(ref user);
            f.MdiParent = this;
            f.Show();
        }

        private void menu_adicionarticket_Click(object sender, EventArgs e)
        {
            AdicionarTickets f = new AdicionarTickets(ref user);
            f.MdiParent = this;
            f.Show();
        }

        //--- Gestor
        private void menu_gerirtickets_Click(object sender, EventArgs e)
        {
            GerirTickets f = new GerirTickets(ref user);
            f.MdiParent = this;
            f.Show();
        }

        //--- Administrador
        private void menu_gerirdepartamentos_Click(object sender, EventArgs e)
        {
            GerirDepartamentos f = new GerirDepartamentos();
            f.MdiParent = this;
            f.Show();
        }

        private void menu_gerirfuncionarios_Click(object sender, EventArgs e)
        {
            GerirFuncionarios f = new GerirFuncionarios();
            f.MdiParent = this;
            f.Show();
        }

        private void menu_sobre_Click(object sender, EventArgs e)
        {
            Sobre f = new Sobre();
            f.MdiParent = this;
            f.Show();
        }

        private void menu_janelas_cascata_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void menu_janelas_horizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menu_janelas_vertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void menu_proximajanela_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl != null)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }
        #endregion

        #region Funções
        /// <summary>
        /// Função que lê os dados do utilizador para a classe utilizador.
        /// </summary>
        private void reload_user()
        {
            try
            {
                string query = "SELECT id_funcionario, nome_funcionario, email_funcionario, telefone_funcionario, funcao, permissao, f.id_departamento, d.nome_departamento "
                             + "FROM Funcionarios as f "
                             + "INNER JOIN Departamentos as d "
                             + "ON f.id_departamento = d.id_departamento "
                             + "WHERE id_funcionario = @id_funcionario";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@id_funcionario", user.get_id()));

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    user.set_id(Convert.ToInt32(reader["id_funcionario"]));
                    user.set_nome(reader["nome_funcionario"].ToString());
                    user.set_email(reader["email_funcionario"].ToString());
                    user.set_telefone(reader["telefone_funcionario"].ToString());
                    user.set_funcao(reader["funcao"].ToString());
                    user.set_permissao(reader["permissao"].ToString());
                    user.set_id_dep(Convert.ToInt32(reader["id_departamento"]));
                    user.set_nome_dep(reader["nome_departamento"].ToString());
                }

                reader.Close();
                connection.Close();

                get_painel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao ler os dados.\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        /// <summary>
        /// Mostra a informação no painel superior.
        /// </summary>
        private void get_painel()
        {
            lbl_id.Text = user.get_id().ToString();
            lbl_nome.Text = user.get_nome();
            lbl_departamento.Text = user.get_nome_dep();
            lbl_funcao.Text = user.get_funcao();
            lbl_telefone.Text = user.get_telefone();
            lbl_email.Text = user.get_email();
        }
        #endregion

    }
}
