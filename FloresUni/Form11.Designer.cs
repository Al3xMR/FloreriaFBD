namespace FloresUni
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.lblTituloCliente = new System.Windows.Forms.Label();
            this.btnFinalizarCliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dvgClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloCliente
            // 
            this.lblTituloCliente.AutoSize = true;
            this.lblTituloCliente.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCliente.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTituloCliente.Location = new System.Drawing.Point(284, 29);
            this.lblTituloCliente.Name = "lblTituloCliente";
            this.lblTituloCliente.Size = new System.Drawing.Size(111, 27);
            this.lblTituloCliente.TabIndex = 0;
            this.lblTituloCliente.Text = "Clientes ";
            // 
            // btnFinalizarCliente
            // 
            this.btnFinalizarCliente.BackColor = System.Drawing.Color.Thistle;
            this.btnFinalizarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizarCliente.FlatAppearance.BorderSize = 0;
            this.btnFinalizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarCliente.ForeColor = System.Drawing.Color.Brown;
            this.btnFinalizarCliente.Location = new System.Drawing.Point(290, 403);
            this.btnFinalizarCliente.Name = "btnFinalizarCliente";
            this.btnFinalizarCliente.Size = new System.Drawing.Size(98, 34);
            this.btnFinalizarCliente.TabIndex = 5;
            this.btnFinalizarCliente.Text = "Finalizar";
            this.btnFinalizarCliente.UseVisualStyleBackColor = false;
            this.btnFinalizarCliente.Click += new System.EventHandler(this.btnFinalizarCliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(197, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 189);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dvgClientes
            // 
            this.dvgClientes.AllowUserToAddRows = false;
            this.dvgClientes.AllowUserToDeleteRows = false;
            this.dvgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgClientes.Location = new System.Drawing.Point(45, 73);
            this.dvgClientes.Name = "dvgClientes";
            this.dvgClientes.ReadOnly = true;
            this.dvgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgClientes.Size = new System.Drawing.Size(588, 313);
            this.dvgClientes.TabIndex = 12;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(679, 458);
            this.Controls.Add(this.dvgClientes);
            this.Controls.Add(this.btnFinalizarCliente);
            this.Controls.Add(this.lblTituloCliente);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmCliente";
            this.Text = "Las Flores de la U";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCliente;
        private System.Windows.Forms.Button btnFinalizarCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dvgClientes;
    }
}