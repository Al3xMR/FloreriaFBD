namespace FloresUni
{
    partial class frmFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTituloFactura = new System.Windows.Forms.Label();
            this.btnFinalizarFactu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvListaFacturas = new System.Windows.Forms.DataGridView();
            this.cmbSelectorIdVendedor = new System.Windows.Forms.ComboBox();
            this.btnRevisar = new System.Windows.Forms.Button();
            this.cmbRevisionOp = new System.Windows.Forms.ComboBox();
            this.lblRevision = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloFactura
            // 
            this.lblTituloFactura.AutoSize = true;
            this.lblTituloFactura.Location = new System.Drawing.Point(305, 56);
            this.lblTituloFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloFactura.Name = "lblTituloFactura";
            this.lblTituloFactura.Size = new System.Drawing.Size(116, 27);
            this.lblTituloFactura.TabIndex = 0;
            this.lblTituloFactura.Text = "Facturas";
            // 
            // btnFinalizarFactu
            // 
            this.btnFinalizarFactu.BackColor = System.Drawing.Color.Thistle;
            this.btnFinalizarFactu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizarFactu.FlatAppearance.BorderSize = 0;
            this.btnFinalizarFactu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarFactu.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarFactu.ForeColor = System.Drawing.Color.Brown;
            this.btnFinalizarFactu.Location = new System.Drawing.Point(294, 468);
            this.btnFinalizarFactu.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizarFactu.Name = "btnFinalizarFactu";
            this.btnFinalizarFactu.Size = new System.Drawing.Size(139, 40);
            this.btnFinalizarFactu.TabIndex = 5;
            this.btnFinalizarFactu.Text = "Finalizar";
            this.btnFinalizarFactu.UseVisualStyleBackColor = false;
            this.btnFinalizarFactu.Click += new System.EventHandler(this.btnFinalizarFactu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 236);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(384, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(331, 163);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // dgvListaFacturas
            // 
            this.dgvListaFacturas.AllowUserToAddRows = false;
            this.dgvListaFacturas.AllowUserToDeleteRows = false;
            this.dgvListaFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaFacturas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaFacturas.Location = new System.Drawing.Point(64, 198);
            this.dgvListaFacturas.Name = "dgvListaFacturas";
            this.dgvListaFacturas.ReadOnly = true;
            this.dgvListaFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaFacturas.Size = new System.Drawing.Size(598, 239);
            this.dgvListaFacturas.TabIndex = 10;
            // 
            // cmbSelectorIdVendedor
            // 
            this.cmbSelectorIdVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectorIdVendedor.FormattingEnabled = true;
            this.cmbSelectorIdVendedor.Location = new System.Drawing.Point(367, 126);
            this.cmbSelectorIdVendedor.Name = "cmbSelectorIdVendedor";
            this.cmbSelectorIdVendedor.Size = new System.Drawing.Size(135, 33);
            this.cmbSelectorIdVendedor.TabIndex = 14;
            this.cmbSelectorIdVendedor.SelectedIndexChanged += new System.EventHandler(this.cmbSelectorIdVendedor_SelectedIndexChanged);
            // 
            // btnRevisar
            // 
            this.btnRevisar.BackColor = System.Drawing.Color.Thistle;
            this.btnRevisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevisar.FlatAppearance.BorderSize = 0;
            this.btnRevisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevisar.ForeColor = System.Drawing.Color.Indigo;
            this.btnRevisar.Location = new System.Drawing.Point(522, 120);
            this.btnRevisar.Name = "btnRevisar";
            this.btnRevisar.Size = new System.Drawing.Size(142, 36);
            this.btnRevisar.TabIndex = 13;
            this.btnRevisar.Text = "Revisar";
            this.btnRevisar.UseVisualStyleBackColor = false;
            this.btnRevisar.Click += new System.EventHandler(this.btnRevisar_Click);
            // 
            // cmbRevisionOp
            // 
            this.cmbRevisionOp.AutoCompleteCustomSource.AddRange(new string[] {
            "Todos",
            "ID Empleado"});
            this.cmbRevisionOp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbRevisionOp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRevisionOp.FormattingEnabled = true;
            this.cmbRevisionOp.Items.AddRange(new object[] {
            "Todos",
            "ID Empleado"});
            this.cmbRevisionOp.Location = new System.Drawing.Point(166, 126);
            this.cmbRevisionOp.Name = "cmbRevisionOp";
            this.cmbRevisionOp.Size = new System.Drawing.Size(182, 33);
            this.cmbRevisionOp.TabIndex = 12;
            this.cmbRevisionOp.SelectedIndexChanged += new System.EventHandler(this.cmbRevisionOp_SelectedIndexChanged);
            // 
            // lblRevision
            // 
            this.lblRevision.AutoSize = true;
            this.lblRevision.Location = new System.Drawing.Point(63, 129);
            this.lblRevision.Name = "lblRevision";
            this.lblRevision.Size = new System.Drawing.Size(91, 27);
            this.lblRevision.TabIndex = 11;
            this.lblRevision.Text = "Filtrar";
            this.lblRevision.Click += new System.EventHandler(this.lblRevision_Click);
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(727, 531);
            this.Controls.Add(this.cmbSelectorIdVendedor);
            this.Controls.Add(this.btnRevisar);
            this.Controls.Add(this.cmbRevisionOp);
            this.Controls.Add(this.lblRevision);
            this.Controls.Add(this.dgvListaFacturas);
            this.Controls.Add(this.btnFinalizarFactu);
            this.Controls.Add(this.lblTituloFactura);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Georgia", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "frmFacturas";
            this.Text = "Las Flores de la U";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloFactura;
        private System.Windows.Forms.Button btnFinalizarFactu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvListaFacturas;
        private System.Windows.Forms.ComboBox cmbSelectorIdVendedor;
        private System.Windows.Forms.Button btnRevisar;
        private System.Windows.Forms.ComboBox cmbRevisionOp;
        private System.Windows.Forms.Label lblRevision;
    }
}