namespace Tickets.Forms
{
    partial class AdicionarTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarTickets));
            this.lbl_assunto = new System.Windows.Forms.Label();
            this.lbl_comentario = new System.Windows.Forms.Label();
            this.txt_assunto = new System.Windows.Forms.TextBox();
            this.txt_comentario = new System.Windows.Forms.TextBox();
            this.cb_prioridade = new System.Windows.Forms.ComboBox();
            this.cb_departamento = new System.Windows.Forms.ComboBox();
            this.lbl_prioridade = new System.Windows.Forms.Label();
            this.lbl_departamento = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_assunto
            // 
            this.lbl_assunto.AutoSize = true;
            this.lbl_assunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_assunto.Location = new System.Drawing.Point(32, 11);
            this.lbl_assunto.Name = "lbl_assunto";
            this.lbl_assunto.Size = new System.Drawing.Size(56, 13);
            this.lbl_assunto.TabIndex = 0;
            this.lbl_assunto.Text = "Assunto:";
            // 
            // lbl_comentario
            // 
            this.lbl_comentario.AutoSize = true;
            this.lbl_comentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comentario.Location = new System.Drawing.Point(17, 37);
            this.lbl_comentario.Name = "lbl_comentario";
            this.lbl_comentario.Size = new System.Drawing.Size(74, 13);
            this.lbl_comentario.TabIndex = 1;
            this.lbl_comentario.Text = "Comentário:";
            // 
            // txt_assunto
            // 
            this.txt_assunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_assunto.Location = new System.Drawing.Point(94, 8);
            this.txt_assunto.MaxLength = 50;
            this.txt_assunto.Name = "txt_assunto";
            this.txt_assunto.Size = new System.Drawing.Size(280, 20);
            this.txt_assunto.TabIndex = 0;
            // 
            // txt_comentario
            // 
            this.txt_comentario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_comentario.Location = new System.Drawing.Point(94, 34);
            this.txt_comentario.MaxLength = 8000;
            this.txt_comentario.Multiline = true;
            this.txt_comentario.Name = "txt_comentario";
            this.txt_comentario.Size = new System.Drawing.Size(280, 175);
            this.txt_comentario.TabIndex = 1;
            // 
            // cb_prioridade
            // 
            this.cb_prioridade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_prioridade.FormattingEnabled = true;
            this.cb_prioridade.Items.AddRange(new object[] {
            "Baixa",
            "Média",
            "Alta"});
            this.cb_prioridade.Location = new System.Drawing.Point(94, 215);
            this.cb_prioridade.Name = "cb_prioridade";
            this.cb_prioridade.Size = new System.Drawing.Size(281, 21);
            this.cb_prioridade.TabIndex = 2;
            this.cb_prioridade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prioridade_KeyPress);
            // 
            // cb_departamento
            // 
            this.cb_departamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_departamento.FormattingEnabled = true;
            this.cb_departamento.Location = new System.Drawing.Point(94, 242);
            this.cb_departamento.Name = "cb_departamento";
            this.cb_departamento.Size = new System.Drawing.Size(281, 21);
            this.cb_departamento.TabIndex = 3;
            this.cb_departamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_departamento_KeyPress);
            // 
            // lbl_prioridade
            // 
            this.lbl_prioridade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_prioridade.AutoSize = true;
            this.lbl_prioridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prioridade.Location = new System.Drawing.Point(23, 218);
            this.lbl_prioridade.Name = "lbl_prioridade";
            this.lbl_prioridade.Size = new System.Drawing.Size(68, 13);
            this.lbl_prioridade.TabIndex = 6;
            this.lbl_prioridade.Text = "Prioridade:";
            // 
            // lbl_departamento
            // 
            this.lbl_departamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_departamento.AutoSize = true;
            this.lbl_departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_departamento.Location = new System.Drawing.Point(3, 245);
            this.lbl_departamento.Name = "lbl_departamento";
            this.lbl_departamento.Size = new System.Drawing.Size(90, 13);
            this.lbl_departamento.TabIndex = 7;
            this.lbl_departamento.Text = "Departamento:";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.Location = new System.Drawing.Point(93, 269);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(281, 32);
            this.btn_adicionar.TabIndex = 4;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // AdicionarTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 312);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.lbl_departamento);
            this.Controls.Add(this.lbl_prioridade);
            this.Controls.Add(this.cb_departamento);
            this.Controls.Add(this.cb_prioridade);
            this.Controls.Add(this.txt_comentario);
            this.Controls.Add(this.txt_assunto);
            this.Controls.Add(this.lbl_comentario);
            this.Controls.Add(this.lbl_assunto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "AdicionarTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Tickets";
            this.Activated += new System.EventHandler(this.AdicionarTickets_Activated);
            this.Load += new System.EventHandler(this.AdicionarTickets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_assunto;
        private System.Windows.Forms.Label lbl_comentario;
        private System.Windows.Forms.TextBox txt_assunto;
        private System.Windows.Forms.TextBox txt_comentario;
        private System.Windows.Forms.ComboBox cb_prioridade;
        private System.Windows.Forms.ComboBox cb_departamento;
        private System.Windows.Forms.Label lbl_prioridade;
        private System.Windows.Forms.Label lbl_departamento;
        private System.Windows.Forms.Button btn_adicionar;
    }
}