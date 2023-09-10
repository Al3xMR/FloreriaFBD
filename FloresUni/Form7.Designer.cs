namespace FloresUni
{
    partial class frmTPrecio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTPrecio));
            this.lblTituloT = new System.Windows.Forms.Label();
            this.btnFinalizarTipo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvArreglos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArreglos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloT
            // 
            this.lblTituloT.AutoSize = true;
            this.lblTituloT.Font = new System.Drawing.Font("Georgia", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloT.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTituloT.Location = new System.Drawing.Point(246, 35);
            this.lblTituloT.Name = "lblTituloT";
            this.lblTituloT.Size = new System.Drawing.Size(187, 27);
            this.lblTituloT.TabIndex = 0;
            this.lblTituloT.Text = "Tipos y Precios";
            // 
            // btnFinalizarTipo
            // 
            this.btnFinalizarTipo.BackColor = System.Drawing.Color.Thistle;
            this.btnFinalizarTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizarTipo.FlatAppearance.BorderSize = 0;
            this.btnFinalizarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarTipo.ForeColor = System.Drawing.Color.Brown;
            this.btnFinalizarTipo.Location = new System.Drawing.Point(254, 406);
            this.btnFinalizarTipo.Name = "btnFinalizarTipo";
            this.btnFinalizarTipo.Size = new System.Drawing.Size(171, 43);
            this.btnFinalizarTipo.TabIndex = 2;
            this.btnFinalizarTipo.Text = "Finalizar";
            this.btnFinalizarTipo.UseVisualStyleBackColor = false;
            this.btnFinalizarTipo.Click += new System.EventHandler(this.btnFinalizarTipo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(493, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 264);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 189);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // dgvArreglos
            // 
            this.dgvArreglos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArreglos.Location = new System.Drawing.Point(44, 88);
            this.dgvArreglos.Name = "dgvArreglos";
            this.dgvArreglos.ReadOnly = true;
            this.dgvArreglos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArreglos.Size = new System.Drawing.Size(590, 285);
            this.dgvArreglos.TabIndex = 10;
            // 
            // frmTPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(678, 461);
            this.Controls.Add(this.dgvArreglos);
            this.Controls.Add(this.btnFinalizarTipo);
            this.Controls.Add(this.lblTituloT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmTPrecio";
            this.Text = "Las Flores de la U";
            this.Load += new System.EventHandler(this.frmTPrecio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArreglos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloT;
        private System.Windows.Forms.Button btnFinalizarTipo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvArreglos;
    }
}