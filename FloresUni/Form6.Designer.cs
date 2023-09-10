namespace FloresUni
{
    partial class frmExistentesF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExistentesF));
            this.lblTituloEF = new System.Windows.Forms.Label();
            this.btnFinalizarRevisionF = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvFlores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloEF
            // 
            this.lblTituloEF.AutoSize = true;
            this.lblTituloEF.Font = new System.Drawing.Font("Georgia", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEF.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTituloEF.Location = new System.Drawing.Point(173, 40);
            this.lblTituloEF.Name = "lblTituloEF";
            this.lblTituloEF.Size = new System.Drawing.Size(376, 27);
            this.lblTituloEF.TabIndex = 0;
            this.lblTituloEF.Text = "Flores Existentes en la Floreria ";
            // 
            // btnFinalizarRevisionF
            // 
            this.btnFinalizarRevisionF.BackColor = System.Drawing.Color.Thistle;
            this.btnFinalizarRevisionF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizarRevisionF.FlatAppearance.BorderSize = 0;
            this.btnFinalizarRevisionF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarRevisionF.ForeColor = System.Drawing.Color.Brown;
            this.btnFinalizarRevisionF.Location = new System.Drawing.Point(289, 401);
            this.btnFinalizarRevisionF.Name = "btnFinalizarRevisionF";
            this.btnFinalizarRevisionF.Size = new System.Drawing.Size(162, 45);
            this.btnFinalizarRevisionF.TabIndex = 2;
            this.btnFinalizarRevisionF.Text = "Finalizar";
            this.btnFinalizarRevisionF.UseVisualStyleBackColor = false;
            this.btnFinalizarRevisionF.Click += new System.EventHandler(this.btnFinalizarRevisionF_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(599, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 265);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, -9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(279, 260);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // dgvFlores
            // 
            this.dgvFlores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlores.Location = new System.Drawing.Point(58, 81);
            this.dgvFlores.Name = "dgvFlores";
            this.dgvFlores.ReadOnly = true;
            this.dgvFlores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFlores.Size = new System.Drawing.Size(624, 287);
            this.dgvFlores.TabIndex = 9;
            // 
            // frmExistentesF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(741, 489);
            this.Controls.Add(this.dgvFlores);
            this.Controls.Add(this.btnFinalizarRevisionF);
            this.Controls.Add(this.lblTituloEF);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmExistentesF";
            this.Text = "Las Flores de la U";
            this.Load += new System.EventHandler(this.frmExistentesF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloEF;
        private System.Windows.Forms.Button btnFinalizarRevisionF;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvFlores;
    }
}