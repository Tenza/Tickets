namespace Tickets.Forms
{
    partial class menu_proxima_janela
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_proxima_janela));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menu_funcionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_visualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_adicionarticket = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_gestor = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_gerirtickets = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_administrador = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_gerirdepartamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_gerirfuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_outros = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sobre = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_janelas = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_janelas_cascata = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_janelas_horizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_janelas_vertical = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_info = new System.Windows.Forms.Panel();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_funcao = new System.Windows.Forms.Label();
            this.lbl_departamento = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_info_telefone = new System.Windows.Forms.Label();
            this.lbl_info_funcao = new System.Windows.Forms.Label();
            this.lbl_info_email = new System.Windows.Forms.Label();
            this.lbl_info_nome = new System.Windows.Forms.Label();
            this.lbl_info_departamento = new System.Windows.Forms.Label();
            this.lbl_info_id = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.panel_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_funcionario,
            this.menu_gestor,
            this.menu_administrador,
            this.menu_outros});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.MdiWindowListItem = this.menu_outros;
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(784, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menu";
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // menu_funcionario
            // 
            this.menu_funcionario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_visualizar,
            this.menu_adicionarticket});
            this.menu_funcionario.Name = "menu_funcionario";
            this.menu_funcionario.ShortcutKeyDisplayString = "";
            this.menu_funcionario.Size = new System.Drawing.Size(82, 20);
            this.menu_funcionario.Text = "&Funcionário";
            // 
            // menu_visualizar
            // 
            this.menu_visualizar.Image = global::Tickets.Properties.Resources.vizualisar_tickets;
            this.menu_visualizar.Name = "menu_visualizar";
            this.menu_visualizar.Size = new System.Drawing.Size(163, 22);
            this.menu_visualizar.Text = "&Visualizar Tickets";
            this.menu_visualizar.Click += new System.EventHandler(this.menu_visualizar_Click);
            // 
            // menu_adicionarticket
            // 
            this.menu_adicionarticket.Image = global::Tickets.Properties.Resources.adicionar_ticket;
            this.menu_adicionarticket.Name = "menu_adicionarticket";
            this.menu_adicionarticket.Size = new System.Drawing.Size(163, 22);
            this.menu_adicionarticket.Text = "&Adicionar Ticket";
            this.menu_adicionarticket.Click += new System.EventHandler(this.menu_adicionarticket_Click);
            // 
            // menu_gestor
            // 
            this.menu_gestor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_gerirtickets});
            this.menu_gestor.Name = "menu_gestor";
            this.menu_gestor.ShortcutKeyDisplayString = "";
            this.menu_gestor.Size = new System.Drawing.Size(53, 20);
            this.menu_gestor.Text = "&Gestor";
            // 
            // menu_gerirtickets
            // 
            this.menu_gerirtickets.Image = global::Tickets.Properties.Resources.gerir_tickets;
            this.menu_gerirtickets.Name = "menu_gerirtickets";
            this.menu_gerirtickets.Size = new System.Drawing.Size(152, 22);
            this.menu_gerirtickets.Text = "&Gerir Tickets";
            this.menu_gerirtickets.Click += new System.EventHandler(this.menu_gerirtickets_Click);
            // 
            // menu_administrador
            // 
            this.menu_administrador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_gerirdepartamentos,
            this.menu_gerirfuncionarios});
            this.menu_administrador.Name = "menu_administrador";
            this.menu_administrador.ShortcutKeyDisplayString = "";
            this.menu_administrador.Size = new System.Drawing.Size(95, 20);
            this.menu_administrador.Text = "&Administrador";
            // 
            // menu_gerirdepartamentos
            // 
            this.menu_gerirdepartamentos.Image = global::Tickets.Properties.Resources.gerir_departamentos;
            this.menu_gerirdepartamentos.Name = "menu_gerirdepartamentos";
            this.menu_gerirdepartamentos.Size = new System.Drawing.Size(183, 22);
            this.menu_gerirdepartamentos.Text = "&Gerir Departamentos";
            this.menu_gerirdepartamentos.Click += new System.EventHandler(this.menu_gerirdepartamentos_Click);
            // 
            // menu_gerirfuncionarios
            // 
            this.menu_gerirfuncionarios.Image = global::Tickets.Properties.Resources.gerir_funcionarios;
            this.menu_gerirfuncionarios.Name = "menu_gerirfuncionarios";
            this.menu_gerirfuncionarios.Size = new System.Drawing.Size(183, 22);
            this.menu_gerirfuncionarios.Text = "&Gerir Funcionários";
            this.menu_gerirfuncionarios.Click += new System.EventHandler(this.menu_gerirfuncionarios_Click);
            // 
            // menu_outros
            // 
            this.menu_outros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_sobre,
            this.toolStripSeparator1,
            this.menu_janelas});
            this.menu_outros.Name = "menu_outros";
            this.menu_outros.ShortcutKeyDisplayString = "";
            this.menu_outros.Size = new System.Drawing.Size(55, 20);
            this.menu_outros.Text = "&Outros";
            // 
            // menu_sobre
            // 
            this.menu_sobre.Image = global::Tickets.Properties.Resources.info;
            this.menu_sobre.Name = "menu_sobre";
            this.menu_sobre.Size = new System.Drawing.Size(155, 22);
            this.menu_sobre.Text = "&Sobre";
            this.menu_sobre.Click += new System.EventHandler(this.menu_sobre_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // menu_janelas
            // 
            this.menu_janelas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_janelas_cascata,
            this.menu_janelas_horizontal,
            this.menu_janelas_vertical});
            this.menu_janelas.Image = global::Tickets.Properties.Resources.janelas;
            this.menu_janelas.Name = "menu_janelas";
            this.menu_janelas.Size = new System.Drawing.Size(155, 22);
            this.menu_janelas.Text = "&Arranjar janelas";
            // 
            // menu_janelas_cascata
            // 
            this.menu_janelas_cascata.Image = global::Tickets.Properties.Resources.janelas_cascata;
            this.menu_janelas_cascata.Name = "menu_janelas_cascata";
            this.menu_janelas_cascata.Size = new System.Drawing.Size(152, 22);
            this.menu_janelas_cascata.Text = "&Cascata";
            this.menu_janelas_cascata.Click += new System.EventHandler(this.menu_janelas_cascata_Click);
            // 
            // menu_janelas_horizontal
            // 
            this.menu_janelas_horizontal.Image = global::Tickets.Properties.Resources.janelas_horizontal;
            this.menu_janelas_horizontal.Name = "menu_janelas_horizontal";
            this.menu_janelas_horizontal.Size = new System.Drawing.Size(152, 22);
            this.menu_janelas_horizontal.Text = "&Horizontal";
            this.menu_janelas_horizontal.Click += new System.EventHandler(this.menu_janelas_horizontal_Click);
            // 
            // menu_janelas_vertical
            // 
            this.menu_janelas_vertical.Image = global::Tickets.Properties.Resources.janelas_vertical;
            this.menu_janelas_vertical.Name = "menu_janelas_vertical";
            this.menu_janelas_vertical.Size = new System.Drawing.Size(152, 22);
            this.menu_janelas_vertical.Text = "&Vertical";
            this.menu_janelas_vertical.Click += new System.EventHandler(this.menu_janelas_vertical_Click);
            // 
            // panel_info
            // 
            this.panel_info.BackColor = System.Drawing.Color.White;
            this.panel_info.Controls.Add(this.lbl_email);
            this.panel_info.Controls.Add(this.lbl_telefone);
            this.panel_info.Controls.Add(this.lbl_funcao);
            this.panel_info.Controls.Add(this.lbl_departamento);
            this.panel_info.Controls.Add(this.lbl_nome);
            this.panel_info.Controls.Add(this.lbl_id);
            this.panel_info.Controls.Add(this.lbl_info_telefone);
            this.panel_info.Controls.Add(this.lbl_info_funcao);
            this.panel_info.Controls.Add(this.lbl_info_email);
            this.panel_info.Controls.Add(this.lbl_info_nome);
            this.panel_info.Controls.Add(this.lbl_info_departamento);
            this.panel_info.Controls.Add(this.lbl_info_id);
            this.panel_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_info.Location = new System.Drawing.Point(0, 24);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(784, 75);
            this.panel_info.TabIndex = 8;
            this.panel_info.Click += new System.EventHandler(this.panel_info_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(600, 46);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(27, 13);
            this.lbl_email.TabIndex = 11;
            this.lbl_email.Text = "N/A";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(600, 14);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(27, 13);
            this.lbl_telefone.TabIndex = 10;
            this.lbl_telefone.Text = "N/A";
            // 
            // lbl_funcao
            // 
            this.lbl_funcao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_funcao.AutoSize = true;
            this.lbl_funcao.Location = new System.Drawing.Point(355, 46);
            this.lbl_funcao.Name = "lbl_funcao";
            this.lbl_funcao.Size = new System.Drawing.Size(27, 13);
            this.lbl_funcao.TabIndex = 9;
            this.lbl_funcao.Text = "N/A";
            // 
            // lbl_departamento
            // 
            this.lbl_departamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_departamento.AutoSize = true;
            this.lbl_departamento.Location = new System.Drawing.Point(355, 14);
            this.lbl_departamento.Name = "lbl_departamento";
            this.lbl_departamento.Size = new System.Drawing.Size(27, 13);
            this.lbl_departamento.TabIndex = 8;
            this.lbl_departamento.Text = "N/A";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(79, 46);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(27, 13);
            this.lbl_nome.TabIndex = 7;
            this.lbl_nome.Text = "N/A";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(79, 14);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(27, 13);
            this.lbl_id.TabIndex = 6;
            this.lbl_id.Text = "N/A";
            // 
            // lbl_info_telefone
            // 
            this.lbl_info_telefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_info_telefone.AutoSize = true;
            this.lbl_info_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_telefone.Location = new System.Drawing.Point(520, 12);
            this.lbl_info_telefone.Name = "lbl_info_telefone";
            this.lbl_info_telefone.Size = new System.Drawing.Size(74, 16);
            this.lbl_info_telefone.TabIndex = 5;
            this.lbl_info_telefone.Text = "Telefone:";
            // 
            // lbl_info_funcao
            // 
            this.lbl_info_funcao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_info_funcao.AutoSize = true;
            this.lbl_info_funcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_funcao.Location = new System.Drawing.Point(286, 44);
            this.lbl_info_funcao.Name = "lbl_info_funcao";
            this.lbl_info_funcao.Size = new System.Drawing.Size(63, 16);
            this.lbl_info_funcao.TabIndex = 4;
            this.lbl_info_funcao.Text = "Função:";
            // 
            // lbl_info_email
            // 
            this.lbl_info_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_info_email.AutoSize = true;
            this.lbl_info_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_email.Location = new System.Drawing.Point(540, 44);
            this.lbl_info_email.Name = "lbl_info_email";
            this.lbl_info_email.Size = new System.Drawing.Size(51, 16);
            this.lbl_info_email.TabIndex = 3;
            this.lbl_info_email.Text = "Email:";
            // 
            // lbl_info_nome
            // 
            this.lbl_info_nome.AutoSize = true;
            this.lbl_info_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_nome.Location = new System.Drawing.Point(20, 44);
            this.lbl_info_nome.Name = "lbl_info_nome";
            this.lbl_info_nome.Size = new System.Drawing.Size(53, 16);
            this.lbl_info_nome.TabIndex = 2;
            this.lbl_info_nome.Text = "Nome:";
            // 
            // lbl_info_departamento
            // 
            this.lbl_info_departamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_info_departamento.AutoSize = true;
            this.lbl_info_departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_departamento.Location = new System.Drawing.Point(239, 12);
            this.lbl_info_departamento.Name = "lbl_info_departamento";
            this.lbl_info_departamento.Size = new System.Drawing.Size(110, 16);
            this.lbl_info_departamento.TabIndex = 1;
            this.lbl_info_departamento.Text = "Departamento:";
            // 
            // lbl_info_id
            // 
            this.lbl_info_id.AutoSize = true;
            this.lbl_info_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_id.Location = new System.Drawing.Point(46, 12);
            this.lbl_info_id.Name = "lbl_info_id";
            this.lbl_info_id.Size = new System.Drawing.Size(27, 16);
            this.lbl_info_id.TabIndex = 0;
            this.lbl_info_id.Text = "ID:";
            // 
            // menu_proxima_janela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panel_info);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "menu_proxima_janela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestão de Tickets";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel_info.ResumeLayout(false);
            this.panel_info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menu_gestor;
        private System.Windows.Forms.ToolStripMenuItem menu_gerirtickets;
        private System.Windows.Forms.ToolStripMenuItem menu_administrador;
        private System.Windows.Forms.ToolStripMenuItem menu_gerirfuncionarios;
        private System.Windows.Forms.ToolStripMenuItem menu_gerirdepartamentos;
        private System.Windows.Forms.ToolStripMenuItem menu_funcionario;
        private System.Windows.Forms.ToolStripMenuItem menu_visualizar;
        private System.Windows.Forms.ToolStripMenuItem menu_adicionarticket;
        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_funcao;
        private System.Windows.Forms.Label lbl_departamento;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_info_telefone;
        private System.Windows.Forms.Label lbl_info_funcao;
        private System.Windows.Forms.Label lbl_info_email;
        private System.Windows.Forms.Label lbl_info_nome;
        private System.Windows.Forms.Label lbl_info_departamento;
        private System.Windows.Forms.Label lbl_info_id;
        private System.Windows.Forms.ToolStripMenuItem menu_outros;
        private System.Windows.Forms.ToolStripMenuItem menu_janelas;
        private System.Windows.Forms.ToolStripMenuItem menu_janelas_cascata;
        private System.Windows.Forms.ToolStripMenuItem menu_janelas_horizontal;
        private System.Windows.Forms.ToolStripMenuItem menu_janelas_vertical;
        private System.Windows.Forms.ToolStripMenuItem menu_sobre;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}