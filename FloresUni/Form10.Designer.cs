namespace FloresUni
{
    partial class frmTotalProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTotalProveedor));
            this.lblTituloProveedor = new System.Windows.Forms.Label();
            this.btnFinalizarRevision = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dvgProveedores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloProveedor
            // 
            this.lblTituloProveedor.AutoSize = true;
            this.lblTituloProveedor.Font = new System.Drawing.Font("Georgia", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProveedor.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTituloProveedor.Location = new System.Drawing.Point(257, 38);
            this.lblTituloProveedor.Name = "lblTituloProveedor";
            this.lblTituloProveedor.Size = new System.Drawing.Size(155, 27);
            this.lblTituloProveedor.TabIndex = 0;
            this.lblTituloProveedor.Text = "Proveedores";
            // 
            // btnFinalizarRevision
            // 
            this.btnFinalizarRevision.BackColor = System.Drawing.Color.Thistle;
            this.btnFinalizarRevision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizarRevision.FlatAppearance.BorderSize = 0;
            this.btnFinalizarRevision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarRevision.ForeColor = System.Drawing.Color.Brown;
            this.btnFinalizarRevision.Location = new System.Drawing.Point(276, 346);
            this.btnFinalizarRevision.Name = "btnFinalizarRevision";
            this.btnFinalizarRevision.Size = new System.Drawing.Size(96, 37);
            this.btnFinalizarRevision.TabIndex = 4;
            this.btnFinalizarRevision.Text = "Finalizar";
            this.btnFinalizarRevision.UseVisualStyleBackColor = false;
            this.btnFinalizarRevision.Click += new System.EventHandler(this.btnFinalizarRevision_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 184);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // dvgProveedores
            // 
            this.dvgProveedores.AllowUserToAddRows = false;
            this.dvgProveedores.AllowUserToDeleteRows = false;
            this.dvgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProveedores.Location = new System.Drawing.Point(71, 102);
            this.dvgProveedores.Name = "dvgProveedores";
            this.dvgProveedores.ReadOnly = true;
            this.dvgProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgProveedores.Size = new System.Drawing.Size(507, 219);
            this.dvgProveedores.TabIndex = 11;
            // 
            // frmTotalProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(648, 395);
            this.Controls.Add(this.dvgProveedores);
            this.Controls.Add(this.btnFinalizarRevision);
            this.Controls.Add(this.lblTituloProveedor);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmTotalProveedor";
            this.Text = "Las Flores de la U";
            this.Load += new System.EventHandler(this.frmTotalProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloProveedor;
        private System.Windows.Forms.Button btnFinalizarRevision;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dvgProveedores;
    }
}