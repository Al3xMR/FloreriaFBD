namespace FloresUni
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlProveedores = new System.Windows.Forms.Panel();
            this.btnTotalProvee = new System.Windows.Forms.Button();
            this.btnNuevoProvee = new System.Windows.Forms.Button();
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.btnTipo = new System.Windows.Forms.Button();
            this.btnDisponible = new System.Windows.Forms.Button();
            this.btnNuevoP = new System.Windows.Forms.Button();
            this.pnlOpVentas = new System.Windows.Forms.Panel();
            this.btnRealizadoV = new System.Windows.Forms.Button();
            this.btnNuevoV = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnProvee = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.pnlProveedores.SuspendLayout();
            this.pnlProductos.SuspendLayout();
            this.pnlOpVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnlMenu.Controls.Add(this.btnCerrar);
            this.pnlMenu.Controls.Add(this.pnlProveedores);
            this.pnlMenu.Controls.Add(this.pnlProductos);
            this.pnlMenu.Controls.Add(this.pnlOpVentas);
            this.pnlMenu.Controls.Add(this.btnCliente);
            this.pnlMenu.Controls.Add(this.btnProvee);
            this.pnlMenu.Controls.Add(this.btnProductos);
            this.pnlMenu.Controls.Add(this.btnFacturas);
            this.pnlMenu.Controls.Add(this.btnVentas);
            this.pnlMenu.Controls.Add(this.pictureBox2);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(679, 482);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Thistle;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.Brown;
            this.btnCerrar.Location = new System.Drawing.Point(498, 30);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(121, 31);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar Caja ";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlProveedores
            // 
            this.pnlProveedores.Controls.Add(this.btnTotalProvee);
            this.pnlProveedores.Controls.Add(this.btnNuevoProvee);
            this.pnlProveedores.Location = new System.Drawing.Point(152, 371);
            this.pnlProveedores.Name = "pnlProveedores";
            this.pnlProveedores.Size = new System.Drawing.Size(103, 65);
            this.pnlProveedores.TabIndex = 8;
            this.pnlProveedores.Visible = false;
            // 
            // btnTotalProvee
            // 
            this.btnTotalProvee.BackColor = System.Drawing.Color.AliceBlue;
            this.btnTotalProvee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTotalProvee.ForeColor = System.Drawing.Color.Indigo;
            this.btnTotalProvee.Location = new System.Drawing.Point(0, 29);
            this.btnTotalProvee.Name = "btnTotalProvee";
            this.btnTotalProvee.Size = new System.Drawing.Size(103, 30);
            this.btnTotalProvee.TabIndex = 1;
            this.btnTotalProvee.Text = "Existentes";
            this.btnTotalProvee.UseVisualStyleBackColor = false;
            this.btnTotalProvee.Click += new System.EventHandler(this.btnTotalProvee_Click);
            // 
            // btnNuevoProvee
            // 
            this.btnNuevoProvee.BackColor = System.Drawing.Color.AliceBlue;
            this.btnNuevoProvee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoProvee.ForeColor = System.Drawing.Color.Indigo;
            this.btnNuevoProvee.Location = new System.Drawing.Point(-1, 0);
            this.btnNuevoProvee.Name = "btnNuevoProvee";
            this.btnNuevoProvee.Size = new System.Drawing.Size(104, 30);
            this.btnNuevoProvee.TabIndex = 0;
            this.btnNuevoProvee.Text = "Nuevo";
            this.btnNuevoProvee.UseVisualStyleBackColor = false;
            this.btnNuevoProvee.Click += new System.EventHandler(this.btnNuevoProvee_Click);
            // 
            // pnlProductos
            // 
            this.pnlProductos.Controls.Add(this.btnTipo);
            this.pnlProductos.Controls.Add(this.btnDisponible);
            this.pnlProductos.Controls.Add(this.btnNuevoP);
            this.pnlProductos.Location = new System.Drawing.Point(283, 181);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Size = new System.Drawing.Size(103, 98);
            this.pnlProductos.TabIndex = 6;
            this.pnlProductos.Visible = false;
            // 
            // btnTipo
            // 
            this.btnTipo.BackColor = System.Drawing.Color.AliceBlue;
            this.btnTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTipo.ForeColor = System.Drawing.Color.Indigo;
            this.btnTipo.Location = new System.Drawing.Point(0, 57);
            this.btnTipo.Name = "btnTipo";
            this.btnTipo.Size = new System.Drawing.Size(103, 30);
            this.btnTipo.TabIndex = 2;
            this.btnTipo.Text = "Arreglos";
            this.btnTipo.UseVisualStyleBackColor = false;
            this.btnTipo.Click += new System.EventHandler(this.btnTipo_Click);
            // 
            // btnDisponible
            // 
            this.btnDisponible.BackColor = System.Drawing.Color.AliceBlue;
            this.btnDisponible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisponible.ForeColor = System.Drawing.Color.Indigo;
            this.btnDisponible.Location = new System.Drawing.Point(0, 29);
            this.btnDisponible.Name = "btnDisponible";
            this.btnDisponible.Size = new System.Drawing.Size(103, 30);
            this.btnDisponible.TabIndex = 1;
            this.btnDisponible.Text = "Existentes";
            this.btnDisponible.UseVisualStyleBackColor = false;
            this.btnDisponible.Click += new System.EventHandler(this.btnDisponible_Click);
            // 
            // btnNuevoP
            // 
            this.btnNuevoP.BackColor = System.Drawing.Color.AliceBlue;
            this.btnNuevoP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoP.ForeColor = System.Drawing.Color.Indigo;
            this.btnNuevoP.Location = new System.Drawing.Point(-1, 0);
            this.btnNuevoP.Name = "btnNuevoP";
            this.btnNuevoP.Size = new System.Drawing.Size(104, 30);
            this.btnNuevoP.TabIndex = 0;
            this.btnNuevoP.Text = "Nuevo";
            this.btnNuevoP.UseVisualStyleBackColor = false;
            this.btnNuevoP.Click += new System.EventHandler(this.btnNuevoP_Click);
            // 
            // pnlOpVentas
            // 
            this.pnlOpVentas.Controls.Add(this.btnRealizadoV);
            this.pnlOpVentas.Controls.Add(this.btnNuevoV);
            this.pnlOpVentas.Location = new System.Drawing.Point(72, 180);
            this.pnlOpVentas.Name = "pnlOpVentas";
            this.pnlOpVentas.Size = new System.Drawing.Size(103, 65);
            this.pnlOpVentas.TabIndex = 5;
            this.pnlOpVentas.Visible = false;
            // 
            // btnRealizadoV
            // 
            this.btnRealizadoV.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRealizadoV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealizadoV.ForeColor = System.Drawing.Color.Indigo;
            this.btnRealizadoV.Location = new System.Drawing.Point(0, 29);
            this.btnRealizadoV.Name = "btnRealizadoV";
            this.btnRealizadoV.Size = new System.Drawing.Size(103, 30);
            this.btnRealizadoV.TabIndex = 1;
            this.btnRealizadoV.Text = "Realizado";
            this.btnRealizadoV.UseVisualStyleBackColor = false;
            this.btnRealizadoV.Click += new System.EventHandler(this.btnRealizadoV_Click);
            // 
            // btnNuevoV
            // 
            this.btnNuevoV.BackColor = System.Drawing.Color.AliceBlue;
            this.btnNuevoV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoV.ForeColor = System.Drawing.Color.Indigo;
            this.btnNuevoV.Location = new System.Drawing.Point(-1, 0);
            this.btnNuevoV.Name = "btnNuevoV";
            this.btnNuevoV.Size = new System.Drawing.Size(104, 30);
            this.btnNuevoV.TabIndex = 0;
            this.btnNuevoV.Text = "Nuevo";
            this.btnNuevoV.UseVisualStyleBackColor = false;
            this.btnNuevoV.Click += new System.EventHandler(this.btnNuevoV_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.ForeColor = System.Drawing.Color.Indigo;
            this.btnCliente.Location = new System.Drawing.Point(427, 292);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(105, 79);
            this.btnCliente.TabIndex = 4;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnProvee
            // 
            this.btnProvee.BackColor = System.Drawing.Color.AliceBlue;
            this.btnProvee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProvee.ForeColor = System.Drawing.Color.Indigo;
            this.btnProvee.Location = new System.Drawing.Point(151, 292);
            this.btnProvee.Name = "btnProvee";
            this.btnProvee.Size = new System.Drawing.Size(105, 79);
            this.btnProvee.TabIndex = 3;
            this.btnProvee.Text = "Proveedores";
            this.btnProvee.UseVisualStyleBackColor = false;
            this.btnProvee.Click += new System.EventHandler(this.btnProvee_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.AliceBlue;
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.ForeColor = System.Drawing.Color.Indigo;
            this.btnProductos.Location = new System.Drawing.Point(281, 103);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(105, 79);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Flores";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.BackColor = System.Drawing.Color.AliceBlue;
            this.btnFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturas.ForeColor = System.Drawing.Color.Indigo;
            this.btnFacturas.Location = new System.Drawing.Point(483, 103);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(105, 79);
            this.btnFacturas.TabIndex = 1;
            this.btnFacturas.Text = "Facturas";
            this.btnFacturas.UseVisualStyleBackColor = false;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.AliceBlue;
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.ForeColor = System.Drawing.Color.Indigo;
            this.btnVentas.Location = new System.Drawing.Point(70, 103);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(105, 79);
            this.btnVentas.TabIndex = 0;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(215, 290);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(282, 189);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 155);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 482);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmMenu";
            this.Text = "La Flores de la U";
            this.pnlMenu.ResumeLayout(false);
            this.pnlProveedores.ResumeLayout(false);
            this.pnlProductos.ResumeLayout(false);
            this.pnlOpVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnProvee;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel pnlOpVentas;
        private System.Windows.Forms.Button btnNuevoV;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnRealizadoV;
        private System.Windows.Forms.Panel pnlProductos;
        private System.Windows.Forms.Button btnTipo;
        private System.Windows.Forms.Button btnDisponible;
        private System.Windows.Forms.Button btnNuevoP;
        private System.Windows.Forms.Panel pnlProveedores;
        private System.Windows.Forms.Button btnTotalProvee;
        private System.Windows.Forms.Button btnNuevoProvee;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}