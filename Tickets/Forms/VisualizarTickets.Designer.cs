namespace Tickets.Forms
{
    partial class VisualizarTickets
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarTickets));
            this.cb_filtro = new System.Windows.Forms.ComboBox();
            this.split_container = new System.Windows.Forms.SplitContainer();
            this.gb_tickets = new System.Windows.Forms.GroupBox();
            this.pn_tickets = new System.Windows.Forms.Panel();
            this.grid_tickets = new System.Windows.Forms.DataGridView();
            this.gb_updates = new System.Windows.Forms.GroupBox();
            this.pn_updates = new System.Windows.Forms.Panel();
            this.grid_updates = new System.Windows.Forms.DataGridView();
            this.gb_filtro = new System.Windows.Forms.GroupBox();
            this.txt_procurar = new System.Windows.Forms.TextBox();
            this.lbl_procurar = new System.Windows.Forms.Label();
            this.btn_adicionarupdate = new System.Windows.Forms.Button();
            this.btn_adicionarticket = new System.Windows.Forms.Button();
            this.lbl_filtro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.split_container)).BeginInit();
            this.split_container.Panel1.SuspendLayout();
            this.split_container.Panel2.SuspendLayout();
            this.split_container.SuspendLayout();
            this.gb_tickets.SuspendLayout();
            this.pn_tickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tickets)).BeginInit();
            this.gb_updates.SuspendLayout();
            this.pn_updates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_updates)).BeginInit();
            this.gb_filtro.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_filtro
            // 
            this.cb_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cb_filtro.FormattingEnabled = true;
            this.cb_filtro.Items.AddRange(new object[] {
            "Tickets atribuídos",
            "Os meus tickets"});
            this.cb_filtro.Location = new System.Drawing.Point(61, 23);
            this.cb_filtro.Name = "cb_filtro";
            this.cb_filtro.Size = new System.Drawing.Size(150, 21);
            this.cb_filtro.TabIndex = 0;
            this.cb_filtro.Text = "Tickets atribuídos";
            this.cb_filtro.SelectedIndexChanged += new System.EventHandler(this.cb_filtro_SelectedIndexChanged);
            this.cb_filtro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_filtro_KeyPress);
            // 
            // split_container
            // 
            this.split_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.split_container.Location = new System.Drawing.Point(0, 0);
            this.split_container.Name = "split_container";
            this.split_container.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // split_container.Panel1
            // 
            this.split_container.Panel1.Controls.Add(this.gb_tickets);
            // 
            // split_container.Panel2
            // 
            this.split_container.Panel2.Controls.Add(this.gb_updates);
            this.split_container.Size = new System.Drawing.Size(784, 400);
            this.split_container.SplitterDistance = 194;
            this.split_container.TabIndex = 11;
            // 
            // gb_tickets
            // 
            this.gb_tickets.Controls.Add(this.pn_tickets);
            this.gb_tickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_tickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_tickets.Location = new System.Drawing.Point(0, 0);
            this.gb_tickets.Name = "gb_tickets";
            this.gb_tickets.Size = new System.Drawing.Size(784, 194);
            this.gb_tickets.TabIndex = 2;
            this.gb_tickets.TabStop = false;
            this.gb_tickets.Text = "Lista de Tickets";
            // 
            // pn_tickets
            // 
            this.pn_tickets.Controls.Add(this.grid_tickets);
            this.pn_tickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_tickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_tickets.Location = new System.Drawing.Point(3, 16);
            this.pn_tickets.Name = "pn_tickets";
            this.pn_tickets.Size = new System.Drawing.Size(778, 175);
            this.pn_tickets.TabIndex = 0;
            // 
            // grid_tickets
            // 
            this.grid_tickets.AllowUserToAddRows = false;
            this.grid_tickets.AllowUserToDeleteRows = false;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_tickets.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_tickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_tickets.Location = new System.Drawing.Point(0, 0);
            this.grid_tickets.MultiSelect = false;
            this.grid_tickets.Name = "grid_tickets";
            this.grid_tickets.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_tickets.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_tickets.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid_tickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_tickets.Size = new System.Drawing.Size(778, 175);
            this.grid_tickets.TabIndex = 0;
            this.grid_tickets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_tickets_CellClick);
            this.grid_tickets.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_tickets_CellDoubleClick);
            // 
            // gb_updates
            // 
            this.gb_updates.Controls.Add(this.pn_updates);
            this.gb_updates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_updates.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_updates.Location = new System.Drawing.Point(0, 0);
            this.gb_updates.Name = "gb_updates";
            this.gb_updates.Size = new System.Drawing.Size(784, 202);
            this.gb_updates.TabIndex = 3;
            this.gb_updates.TabStop = false;
            this.gb_updates.Text = "Updates do Ticket Seleccionado";
            // 
            // pn_updates
            // 
            this.pn_updates.Controls.Add(this.grid_updates);
            this.pn_updates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_updates.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_updates.Location = new System.Drawing.Point(3, 16);
            this.pn_updates.Name = "pn_updates";
            this.pn_updates.Size = new System.Drawing.Size(778, 183);
            this.pn_updates.TabIndex = 0;
            // 
            // grid_updates
            // 
            this.grid_updates.AllowUserToAddRows = false;
            this.grid_updates.AllowUserToDeleteRows = false;
            this.grid_updates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_updates.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_updates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_updates.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid_updates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_updates.Location = new System.Drawing.Point(0, 0);
            this.grid_updates.MultiSelect = false;
            this.grid_updates.Name = "grid_updates";
            this.grid_updates.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_updates.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_updates.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid_updates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_updates.Size = new System.Drawing.Size(778, 183);
            this.grid_updates.TabIndex = 0;
            this.grid_updates.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_updates_CellDoubleClick);
            // 
            // gb_filtro
            // 
            this.gb_filtro.Controls.Add(this.txt_procurar);
            this.gb_filtro.Controls.Add(this.lbl_procurar);
            this.gb_filtro.Controls.Add(this.btn_adicionarupdate);
            this.gb_filtro.Controls.Add(this.btn_adicionarticket);
            this.gb_filtro.Controls.Add(this.cb_filtro);
            this.gb_filtro.Controls.Add(this.lbl_filtro);
            this.gb_filtro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_filtro.Location = new System.Drawing.Point(0, 406);
            this.gb_filtro.Name = "gb_filtro";
            this.gb_filtro.Size = new System.Drawing.Size(784, 56);
            this.gb_filtro.TabIndex = 12;
            this.gb_filtro.TabStop = false;
            this.gb_filtro.Text = "Opções";
            // 
            // txt_procurar
            // 
            this.txt_procurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_procurar.Location = new System.Drawing.Point(289, 23);
            this.txt_procurar.Name = "txt_procurar";
            this.txt_procurar.Size = new System.Drawing.Size(150, 20);
            this.txt_procurar.TabIndex = 1;
            this.txt_procurar.TextChanged += new System.EventHandler(this.txt_procurar_TextChanged);
            // 
            // lbl_procurar
            // 
            this.lbl_procurar.AutoSize = true;
            this.lbl_procurar.Location = new System.Drawing.Point(224, 27);
            this.lbl_procurar.Name = "lbl_procurar";
            this.lbl_procurar.Size = new System.Drawing.Size(59, 13);
            this.lbl_procurar.TabIndex = 14;
            this.lbl_procurar.Text = "Procurar:";
            // 
            // btn_adicionarupdate
            // 
            this.btn_adicionarupdate.Location = new System.Drawing.Point(614, 21);
            this.btn_adicionarupdate.Name = "btn_adicionarupdate";
            this.btn_adicionarupdate.Size = new System.Drawing.Size(150, 25);
            this.btn_adicionarupdate.TabIndex = 3;
            this.btn_adicionarupdate.Text = "Adicionar Update";
            this.btn_adicionarupdate.UseVisualStyleBackColor = true;
            this.btn_adicionarupdate.Click += new System.EventHandler(this.btn_adicionarupdate_Click);
            // 
            // btn_adicionarticket
            // 
            this.btn_adicionarticket.Location = new System.Drawing.Point(458, 21);
            this.btn_adicionarticket.Name = "btn_adicionarticket";
            this.btn_adicionarticket.Size = new System.Drawing.Size(150, 25);
            this.btn_adicionarticket.TabIndex = 2;
            this.btn_adicionarticket.Text = "Adicionar Ticket";
            this.btn_adicionarticket.UseVisualStyleBackColor = true;
            this.btn_adicionarticket.Click += new System.EventHandler(this.btn_adicionarticket_Click);
            // 
            // lbl_filtro
            // 
            this.lbl_filtro.AutoSize = true;
            this.lbl_filtro.Location = new System.Drawing.Point(16, 27);
            this.lbl_filtro.Name = "lbl_filtro";
            this.lbl_filtro.Size = new System.Drawing.Size(39, 13);
            this.lbl_filtro.TabIndex = 10;
            this.lbl_filtro.Text = "Filtro:";
            // 
            // VisualizarTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.gb_filtro);
            this.Controls.Add(this.split_container);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "VisualizarTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Tickets";
            this.Activated += new System.EventHandler(this.VisualizarTickets_Activated);
            this.Load += new System.EventHandler(this.VisualizarTickets_Load);
            this.split_container.Panel1.ResumeLayout(false);
            this.split_container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_container)).EndInit();
            this.split_container.ResumeLayout(false);
            this.gb_tickets.ResumeLayout(false);
            this.pn_tickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_tickets)).EndInit();
            this.gb_updates.ResumeLayout(false);
            this.pn_updates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_updates)).EndInit();
            this.gb_filtro.ResumeLayout(false);
            this.gb_filtro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_filtro;
        private System.Windows.Forms.SplitContainer split_container;
        private System.Windows.Forms.GroupBox gb_filtro;
        private System.Windows.Forms.Label lbl_filtro;
        private System.Windows.Forms.GroupBox gb_tickets;
        private System.Windows.Forms.GroupBox gb_updates;
        private System.Windows.Forms.Button btn_adicionarticket;
        private System.Windows.Forms.Button btn_adicionarupdate;
        private System.Windows.Forms.Panel pn_tickets;
        private System.Windows.Forms.DataGridView grid_tickets;
        private System.Windows.Forms.Panel pn_updates;
        private System.Windows.Forms.DataGridView grid_updates;
        private System.Windows.Forms.TextBox txt_procurar;
        private System.Windows.Forms.Label lbl_procurar;

    }
}