namespace FloresUni
{
    partial class frmVentasRealizadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentasRealizadas));
            this.lblTituloRealizado = new System.Windows.Forms.Label();
            this.lblRevision = new System.Windows.Forms.Label();
            this.cmbRevisionOp = new System.Windows.Forms.ComboBox();
            this.btnRevisar = new System.Windows.Forms.Button();
            this.btnRevisionF = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvListaFacturas = new System.Windows.Forms.DataGridView();
            this.cmbSelectorIdVendedor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloRealizado
            // 
            this.lblTituloRealizado.AutoSize = true;
            this.lblTituloRealizado.Font = new System.Drawing.Font("Georgia", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRealizado.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTituloRealizado.Location = new System.Drawing.Point(265, 46);
            this.lblTituloRealizado.Name = "lblTituloRealizado";
            this.lblTituloRealizado.Size = new System.Drawing.Size(225, 27);
            this.lblTituloRealizado.TabIndex = 0;
            this.lblTituloRealizado.Text = "Ventas Realizadas";
            // 
            // lblRevision
            // 
            this.lblRevision.AutoSize = true;
            this.lblRevision.Location = new System.Drawing.Point(70, 119);
            this.lblRevision.Name = "lblRevision";
            this.lblRevision.Size = new System.Drawing.Size(65, 18);
            this.lblRevision.TabIndex = 1;
            this.lblRevision.Text = "Filtrar";
            // 
            // cmbRevisionOp
            // 
            this.cmbRevisionOp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbRevisionOp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRevisionOp.FormattingEnabled = true;
            this.cmbRevisionOp.Items.AddRange(new object[] {
            "Todos",
            "ID Empleado"});
            this.cmbRevisionOp.Location = new System.Drawing.Point(173, 116);
            this.cmbRevisionOp.Name = "cmbRevisionOp";
            this.cmbRevisionOp.Size = new System.Drawing.Size(182, 26);
            this.cmbRevisionOp.TabIndex = 2;
            this.cmbRevisionOp.SelectedIndexChanged += new System.EventHandler(this.cmbRevisionOp_SelectedIndexChanged);
            // 
            // btnRevisar
            // 
            this.btnRevisar.BackColor = System.Drawing.Color.Thistle;
            this.btnRevisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevisar.FlatAppearance.BorderSize = 0;
            this.btnRevisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevisar.ForeColor = System.Drawing.Color.Indigo;
            this.btnRevisar.Location = new System.Drawing.Point(529, 110);
            this.btnRevisar.Name = "btnRevisar";
            this.btnRevisar.Size = new System.Drawing.Size(142, 36);
            this.btnRevisar.TabIndex = 3;
            this.btnRevisar.Text = "Revisar";
            this.btnRevisar.UseVisualStyleBackColor = false;
            this.btnRevisar.Click += new System.EventHandler(this.btnRevisar_Click);
            // 
            // btnRevisionF
            // 
            this.btnRevisionF.BackColor = System.Drawing.Color.Thistle;
            this.btnRevisionF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevisionF.FlatAppearance.BorderSize = 0;
            this.btnRevisionF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevisionF.ForeColor = System.Drawing.Color.Brown;
            this.btnRevisionF.Location = new System.Drawing.Point(276, 413);
            this.btnRevisionF.Name = "btnRevisionF";
            this.btnRevisionF.Size = new System.Drawing.Size(202, 36);
            this.btnRevisionF.TabIndex = 6;
            this.btnRevisionF.Text = "Revisión Finalizada";
            this.btnRevisionF.UseVisualStyleBackColor = false;
            this.btnRevisionF.Click += new System.EventHandler(this.btnRevisionF_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(463, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 214);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(38, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 204);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // dgvListaFacturas
            // 
            this.dgvListaFacturas.AllowUserToAddRows = false;
            this.dgvListaFacturas.AllowUserToDeleteRows = false;
            this.dgvListaFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaFacturas.Location = new System.Drawing.Point(78, 166);
            this.dgvListaFacturas.Name = "dgvListaFacturas";
            this.dgvListaFacturas.ReadOnly = true;
            this.dgvListaFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaFacturas.Size = new System.Drawing.Size(598, 222);
            this.dgvListaFacturas.TabIndex = 9;
            this.dgvListaFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaFacturas_CellContentClick);
            // 
            // cmbSelectorIdVendedor
            // 
            this.cmbSelectorIdVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectorIdVendedor.FormattingEnabled = true;
            this.cmbSelectorIdVendedor.Location = new System.Drawing.Point(374, 116);
            this.cmbSelectorIdVendedor.Name = "cmbSelectorIdVendedor";
            this.cmbSelectorIdVendedor.Size = new System.Drawing.Size(135, 26);
            this.cmbSelectorIdVendedor.TabIndex = 10;
            // 
            // frmVentasRealizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(755, 471);
            this.Controls.Add(this.cmbSelectorIdVendedor);
            this.Controls.Add(this.dgvListaFacturas);
            this.Controls.Add(this.btnRevisionF);
            this.Controls.Add(this.btnRevisar);
            this.Controls.Add(this.cmbRevisionOp);
            this.Controls.Add(this.lblRevision);
            this.Controls.Add(this.lblTituloRealizado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmVentasRealizadas";
            this.Text = "Las Flores de la U";
            this.Load += new System.EventHandler(this.frmVentasRealizadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloRealizado;
        private System.Windows.Forms.Label lblRevision;
        private System.Windows.Forms.ComboBox cmbRevisionOp;
        private System.Windows.Forms.Button btnRevisar;
        private System.Windows.Forms.Button btnRevisionF;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvListaFacturas;
        private System.Windows.Forms.ComboBox cmbSelectorIdVendedor;
    }
}