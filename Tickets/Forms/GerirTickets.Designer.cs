namespace Tickets.Forms
{
    partial class GerirTickets
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirTickets));
            this.grid_tickets = new System.Windows.Forms.DataGridView();
            this.lb_funcionarios = new System.Windows.Forms.ListBox();
            this.lb_grupos = new System.Windows.Forms.ListBox();
            this.cb_prioridade = new System.Windows.Forms.ComboBox();
            this.lbl_prioridade = new System.Windows.Forms.Label();
            this.btn_aplicar = new System.Windows.Forms.Button();
            this.lbl_filtro = new System.Windows.Forms.Label();
            this.cb_filtro = new System.Windows.Forms.ComboBox();
            this.lbl_funcionarios = new System.Windows.Forms.Label();
            this.lbl_grupo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tickets)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_tickets
            // 
            this.grid_tickets.AllowUserToAddRows = false;
            this.grid_tickets.AllowUserToDeleteRows = false;
            this.grid_tickets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_tickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_tickets.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_tickets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_tickets.Location = new System.Drawing.Point(269, 12);
            this.grid_tickets.MultiSelect = false;
            this.grid_tickets.Name = "grid_tickets";
            this.grid_tickets.ReadOnly = true;
            this.grid_tickets.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid_tickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_tickets.Size = new System.Drawing.Size(503, 388);
            this.grid_tickets.TabIndex = 6;
            this.grid_tickets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_tickets_CellClick);
            this.grid_tickets.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_tickets_CellDoubleClick);
            // 
            // lb_funcionarios
            // 
            this.lb_funcionarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_funcionarios.FormattingEnabled = true;
            this.lb_funcionarios.Location = new System.Drawing.Point(12, 77);
            this.lb_funcionarios.Name = "lb_funcionarios";
            this.lb_funcionarios.Size = new System.Drawing.Size(120, 238);
            this.lb_funcionarios.TabIndex = 0;
            this.lb_funcionarios.DoubleClick += new System.EventHandler(this.lb_funcionarios_DoubleClick);
            // 
            // lb_grupos
            // 
            this.lb_grupos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_grupos.FormattingEnabled = true;
            this.lb_grupos.Location = new System.Drawing.Point(138, 77);
            this.lb_grupos.Name = "lb_grupos";
            this.lb_grupos.Size = new System.Drawing.Size(120, 238);
            this.lb_grupos.TabIndex = 1;
            this.lb_grupos.DoubleClick += new System.EventHandler(this.lb_grupos_DoubleClick);
            // 
            // cb_prioridade
            // 
            this.cb_prioridade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_prioridade.FormattingEnabled = true;
            this.cb_prioridade.Items.AddRange(new object[] {
            "Baixa",
            "Média",
            "Alta"});
            this.cb_prioridade.Location = new System.Drawing.Point(12, 341);
            this.cb_prioridade.Name = "cb_prioridade";
            this.cb_prioridade.Size = new System.Drawing.Size(246, 21);
            this.cb_prioridade.TabIndex = 2;
            this.cb_prioridade.Text = "Média";
            this.cb_prioridade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_prioridade_KeyPress);
            // 
            // lbl_prioridade
            // 
            this.lbl_prioridade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_prioridade.AutoSize = true;
            this.lbl_prioridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prioridade.Location = new System.Drawing.Point(19, 325);
            this.lbl_prioridade.Name = "lbl_prioridade";
            this.lbl_prioridade.Size = new System.Drawing.Size(68, 13);
            this.lbl_prioridade.TabIndex = 6;
            this.lbl_prioridade.Text = "Prioridade:";
            // 
            // btn_aplicar
            // 
            this.btn_aplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_aplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aplicar.Location = new System.Drawing.Point(12, 368);
            this.btn_aplicar.Name = "btn_aplicar";
            this.btn_aplicar.Size = new System.Drawing.Size(246, 32);
            this.btn_aplicar.TabIndex = 5;
            this.btn_aplicar.Text = "Abrir Ticket";
            this.btn_aplicar.UseVisualStyleBackColor = true;
            this.btn_aplicar.Click += new System.EventHandler(this.btn_aplicar_Click);
            // 
            // lbl_filtro
            // 
            this.lbl_filtro.AutoSize = true;
            this.lbl_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtro.Location = new System.Drawing.Point(19, 12);
            this.lbl_filtro.Name = "lbl_filtro";
            this.lbl_filtro.Size = new System.Drawing.Size(39, 13);
            this.lbl_filtro.TabIndex = 9;
            this.lbl_filtro.Text = "Filtro:";
            // 
            // cb_filtro
            // 
            this.cb_filtro.FormattingEnabled = true;
            this.cb_filtro.Items.AddRange(new object[] {
            "Pendente",
            "Aberto",
            "Fechado"});
            this.cb_filtro.Location = new System.Drawing.Point(12, 28);
            this.cb_filtro.Name = "cb_filtro";
            this.cb_filtro.Size = new System.Drawing.Size(246, 21);
            this.cb_filtro.TabIndex = 4;
            this.cb_filtro.Text = "Pendente";
            this.cb_filtro.SelectedIndexChanged += new System.EventHandler(this.cb_filtro_SelectedIndexChanged);
            this.cb_filtro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_filtro_KeyPress);
            // 
            // lbl_funcionarios
            // 
            this.lbl_funcionarios.AutoSize = true;
            this.lbl_funcionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_funcionarios.Location = new System.Drawing.Point(19, 61);
            this.lbl_funcionarios.Name = "lbl_funcionarios";
            this.lbl_funcionarios.Size = new System.Drawing.Size(83, 13);
            this.lbl_funcionarios.TabIndex = 10;
            this.lbl_funcionarios.Text = "Funcionarios:";
            // 
            // lbl_grupo
            // 
            this.lbl_grupo.AutoSize = true;
            this.lbl_grupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grupo.Location = new System.Drawing.Point(146, 61);
            this.lbl_grupo.Name = "lbl_grupo";
            this.lbl_grupo.Size = new System.Drawing.Size(45, 13);
            this.lbl_grupo.TabIndex = 11;
            this.lbl_grupo.Text = "Grupo:";
            // 
            // GerirTickets
            // 
            this.AcceptButton = this.btn_aplicar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.lbl_grupo);
            this.Controls.Add(this.lbl_funcionarios);
            this.Controls.Add(this.lbl_filtro);
            this.Controls.Add(this.cb_filtro);
            this.Controls.Add(this.btn_aplicar);
            this.Controls.Add(this.lbl_prioridade);
            this.Controls.Add(this.cb_prioridade);
            this.Controls.Add(this.lb_grupos);
            this.Controls.Add(this.lb_funcionarios);
            this.Controls.Add(this.grid_tickets);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 350);
            this.Name = "GerirTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerir Tickets";
            this.Activated += new System.EventHandler(this.GerirTickets_Activated);
            this.Load += new System.EventHandler(this.GerirTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_tickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_tickets;
        private System.Windows.Forms.ListBox lb_funcionarios;
        private System.Windows.Forms.ListBox lb_grupos;
        private System.Windows.Forms.ComboBox cb_prioridade;
        private System.Windows.Forms.Label lbl_prioridade;
        private System.Windows.Forms.Button btn_aplicar;
        private System.Windows.Forms.Label lbl_filtro;
        private System.Windows.Forms.ComboBox cb_filtro;
        private System.Windows.Forms.Label lbl_funcionarios;
        private System.Windows.Forms.Label lbl_grupo;
    }
}