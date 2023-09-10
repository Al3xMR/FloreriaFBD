namespace FloresUni
{
    partial class frmProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedor));
            this.lblTituloProvee = new System.Windows.Forms.Label();
            this.lblNombreProvee = new System.Windows.Forms.Label();
            this.lblCiudadP = new System.Windows.Forms.Label();
            this.lblTelefonoP = new System.Windows.Forms.Label();
            this.txtNombreProveed = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtDirProvee = new System.Windows.Forms.TextBox();
            this.btnIngesarPro = new System.Windows.Forms.Button();
            this.btnFinalizarProvee = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloProvee
            // 
            this.lblTituloProvee.AutoSize = true;
            this.lblTituloProvee.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProvee.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTituloProvee.Location = new System.Drawing.Point(192, 24);
            this.lblTituloProvee.Name = "lblTituloProvee";
            this.lblTituloProvee.Size = new System.Drawing.Size(207, 27);
            this.lblTituloProvee.TabIndex = 0;
            this.lblTituloProvee.Text = "Nuevo Proveedor";
            // 
            // lblNombreProvee
            // 
            this.lblNombreProvee.AutoSize = true;
            this.lblNombreProvee.Location = new System.Drawing.Point(30, 127);
            this.lblNombreProvee.Name = "lblNombreProvee";
            this.lblNombreProvee.Size = new System.Drawing.Size(163, 18);
            this.lblNombreProvee.TabIndex = 3;
            this.lblNombreProvee.Text = "Nombre Proveedor";
            // 
            // lblCiudadP
            // 
            this.lblCiudadP.AutoSize = true;
            this.lblCiudadP.Location = new System.Drawing.Point(30, 180);
            this.lblCiudadP.Name = "lblCiudadP";
            this.lblCiudadP.Size = new System.Drawing.Size(68, 18);
            this.lblCiudadP.TabIndex = 4;
            this.lblCiudadP.Text = "Ciudad";
            // 
            // lblTelefonoP
            // 
            this.lblTelefonoP.AutoSize = true;
            this.lblTelefonoP.Location = new System.Drawing.Point(30, 234);
            this.lblTelefonoP.Name = "lblTelefonoP";
            this.lblTelefonoP.Size = new System.Drawing.Size(88, 18);
            this.lblTelefonoP.TabIndex = 5;
            this.lblTelefonoP.Text = "Dirección";
            // 
            // txtNombreProveed
            // 
            this.txtNombreProveed.Location = new System.Drawing.Point(220, 124);
            this.txtNombreProveed.Name = "txtNombreProveed";
            this.txtNombreProveed.Size = new System.Drawing.Size(241, 26);
            this.txtNombreProveed.TabIndex = 8;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(220, 177);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(241, 26);
            this.txtCiudad.TabIndex = 9;
            // 
            // txtDirProvee
            // 
            this.txtDirProvee.Location = new System.Drawing.Point(220, 226);
            this.txtDirProvee.Name = "txtDirProvee";
            this.txtDirProvee.Size = new System.Drawing.Size(241, 26);
            this.txtDirProvee.TabIndex = 10;
            // 
            // btnIngesarPro
            // 
            this.btnIngesarPro.BackColor = System.Drawing.Color.Thistle;
            this.btnIngesarPro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngesarPro.FlatAppearance.BorderSize = 0;
            this.btnIngesarPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngesarPro.ForeColor = System.Drawing.Color.Indigo;
            this.btnIngesarPro.Location = new System.Drawing.Point(131, 317);
            this.btnIngesarPro.Name = "btnIngesarPro";
            this.btnIngesarPro.Size = new System.Drawing.Size(138, 43);
            this.btnIngesarPro.TabIndex = 11;
            this.btnIngesarPro.Text = "Ingresar";
            this.btnIngesarPro.UseVisualStyleBackColor = false;
            this.btnIngesarPro.Click += new System.EventHandler(this.btnIngesarPro_Click);
            // 
            // btnFinalizarProvee
            // 
            this.btnFinalizarProvee.BackColor = System.Drawing.Color.Thistle;
            this.btnFinalizarProvee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizarProvee.FlatAppearance.BorderSize = 0;
            this.btnFinalizarProvee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarProvee.ForeColor = System.Drawing.Color.Brown;
            this.btnFinalizarProvee.Location = new System.Drawing.Point(323, 317);
            this.btnFinalizarProvee.Name = "btnFinalizarProvee";
            this.btnFinalizarProvee.Size = new System.Drawing.Size(138, 43);
            this.btnFinalizarProvee.TabIndex = 12;
            this.btnFinalizarProvee.Text = "Atrás";
            this.btnFinalizarProvee.UseVisualStyleBackColor = false;
            this.btnFinalizarProvee.Click += new System.EventHandler(this.btnFinalizarProvee_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 267);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(281, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(288, 220);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(570, 376);
            this.Controls.Add(this.btnFinalizarProvee);
            this.Controls.Add(this.btnIngesarPro);
            this.Controls.Add(this.txtDirProvee);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtNombreProveed);
            this.Controls.Add(this.lblTelefonoP);
            this.Controls.Add(this.lblCiudadP);
            this.Controls.Add(this.lblNombreProvee);
            this.Controls.Add(this.lblTituloProvee);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmProveedor";
            this.Text = "Las Flores de la U";
            this.Load += new System.EventHandler(this.frmProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloProvee;
        private System.Windows.Forms.Label lblNombreProvee;
        private System.Windows.Forms.Label lblCiudadP;
        private System.Windows.Forms.Label lblTelefonoP;
        private System.Windows.Forms.TextBox txtNombreProveed;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtDirProvee;
        private System.Windows.Forms.Button btnIngesarPro;
        private System.Windows.Forms.Button btnFinalizarProvee;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}