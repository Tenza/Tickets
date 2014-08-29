namespace Tickets.Forms
{
    partial class GerirFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirFuncionarios));
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_funcao = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.cb_departamento = new System.Windows.Forms.ComboBox();
            this.cb_permissao = new System.Windows.Forms.ComboBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_funcao = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_departamento = new System.Windows.Forms.Label();
            this.lbl_permissao = new System.Windows.Forms.Label();
            this.grid_funcionarios = new System.Windows.Forms.DataGridView();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckb_activos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_funcionarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(3, 3);
            this.txt_username.MaxLength = 50;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(204, 20);
            this.txt_username.TabIndex = 0;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(3, 63);
            this.txt_nome.MaxLength = 100;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(204, 20);
            this.txt_nome.TabIndex = 2;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(3, 93);
            this.txt_email.MaxLength = 254;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(204, 20);
            this.txt_email.TabIndex = 3;
            // 
            // txt_funcao
            // 
            this.txt_funcao.Location = new System.Drawing.Point(3, 153);
            this.txt_funcao.MaxLength = 50;
            this.txt_funcao.Name = "txt_funcao";
            this.txt_funcao.Size = new System.Drawing.Size(204, 20);
            this.txt_funcao.TabIndex = 5;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(3, 33);
            this.txt_password.MaxLength = 50;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.Size = new System.Drawing.Size(204, 20);
            this.txt_password.TabIndex = 1;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(25, 23);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(67, 13);
            this.lbl_username.TabIndex = 6;
            this.lbl_username.Text = "Username:";
            // 
            // cb_departamento
            // 
            this.cb_departamento.FormattingEnabled = true;
            this.cb_departamento.Location = new System.Drawing.Point(3, 183);
            this.cb_departamento.Name = "cb_departamento";
            this.cb_departamento.Size = new System.Drawing.Size(204, 21);
            this.cb_departamento.TabIndex = 6;
            this.cb_departamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_departamento_KeyPress);
            // 
            // cb_permissao
            // 
            this.cb_permissao.FormattingEnabled = true;
            this.cb_permissao.Items.AddRange(new object[] {
            "Funcionário",
            "Gestor",
            "Administrador"});
            this.cb_permissao.Location = new System.Drawing.Point(3, 214);
            this.cb_permissao.Name = "cb_permissao";
            this.cb_permissao.Size = new System.Drawing.Size(204, 21);
            this.cb_permissao.TabIndex = 7;
            this.cb_permissao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_permissao_KeyPress);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.Location = new System.Drawing.Point(3, 267);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(204, 32);
            this.btn_adicionar.TabIndex = 9;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(27, 53);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(65, 13);
            this.lbl_password.TabIndex = 11;
            this.lbl_password.Text = "Password:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(49, 83);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(43, 13);
            this.lbl_nome.TabIndex = 12;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(51, 113);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(41, 13);
            this.lbl_email.TabIndex = 13;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_funcao
            // 
            this.lbl_funcao.AutoSize = true;
            this.lbl_funcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_funcao.Location = new System.Drawing.Point(39, 173);
            this.lbl_funcao.Name = "lbl_funcao";
            this.lbl_funcao.Size = new System.Drawing.Size(53, 13);
            this.lbl_funcao.TabIndex = 14;
            this.lbl_funcao.Text = "Função:";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(31, 143);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(61, 13);
            this.lbl_telefone.TabIndex = 15;
            this.lbl_telefone.Text = "Telefone:";
            // 
            // lbl_departamento
            // 
            this.lbl_departamento.AutoSize = true;
            this.lbl_departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_departamento.Location = new System.Drawing.Point(2, 203);
            this.lbl_departamento.Name = "lbl_departamento";
            this.lbl_departamento.Size = new System.Drawing.Size(90, 13);
            this.lbl_departamento.TabIndex = 16;
            this.lbl_departamento.Text = "Departamento:";
            // 
            // lbl_permissao
            // 
            this.lbl_permissao.AutoSize = true;
            this.lbl_permissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_permissao.Location = new System.Drawing.Point(24, 233);
            this.lbl_permissao.Name = "lbl_permissao";
            this.lbl_permissao.Size = new System.Drawing.Size(68, 13);
            this.lbl_permissao.TabIndex = 17;
            this.lbl_permissao.Text = "Permissão:";
            // 
            // grid_funcionarios
            // 
            this.grid_funcionarios.AllowUserToAddRows = false;
            this.grid_funcionarios.AllowUserToDeleteRows = false;
            this.grid_funcionarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_funcionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_funcionarios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_funcionarios.Location = new System.Drawing.Point(310, 12);
            this.grid_funcionarios.MultiSelect = false;
            this.grid_funcionarios.Name = "grid_funcionarios";
            this.grid_funcionarios.ReadOnly = true;
            this.grid_funcionarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid_funcionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_funcionarios.Size = new System.Drawing.Size(412, 314);
            this.grid_funcionarios.TabIndex = 10;
            this.grid_funcionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_funcionarios_CellClick);
            this.grid_funcionarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_funcionarios_CellDoubleClick);
            this.grid_funcionarios.Click += new System.EventHandler(this.grid_funcionarios_Click);
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(3, 123);
            this.txt_telefone.Mask = "000000000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(204, 20);
            this.txt_telefone.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckb_activos);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.txt_telefone);
            this.panel1.Controls.Add(this.txt_nome);
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.txt_funcao);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.cb_departamento);
            this.panel1.Controls.Add(this.cb_permissao);
            this.panel1.Controls.Add(this.btn_adicionar);
            this.panel1.Location = new System.Drawing.Point(92, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 309);
            this.panel1.TabIndex = 19;
            // 
            // ckb_activos
            // 
            this.ckb_activos.AutoSize = true;
            this.ckb_activos.Location = new System.Drawing.Point(7, 244);
            this.ckb_activos.Name = "ckb_activos";
            this.ckb_activos.Size = new System.Drawing.Size(174, 17);
            this.ckb_activos.TabIndex = 10;
            this.ckb_activos.Text = "Ver funcionários desactivados?";
            this.ckb_activos.UseVisualStyleBackColor = true;
            this.ckb_activos.CheckedChanged += new System.EventHandler(this.ckb_activos_CheckedChanged);
            // 
            // GerirFuncionarios
            // 
            this.AcceptButton = this.btn_adicionar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 338);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grid_funcionarios);
            this.Controls.Add(this.lbl_permissao);
            this.Controls.Add(this.lbl_departamento);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_funcao);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 300);
            this.Name = "GerirFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerir Funcionários";
            this.Activated += new System.EventHandler(this.AdicionarFuncionarios_Activated);
            this.Load += new System.EventHandler(this.AdicionarFuncionarios_Load);
            this.Click += new System.EventHandler(this.AdicionarFuncionarios_Click);
            ((System.ComponentModel.ISupportInitialize)(this.grid_funcionarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_funcao;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.ComboBox cb_departamento;
        private System.Windows.Forms.ComboBox cb_permissao;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_funcao;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_departamento;
        private System.Windows.Forms.Label lbl_permissao;
        private System.Windows.Forms.DataGridView grid_funcionarios;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckb_activos;
    }
}