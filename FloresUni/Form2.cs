using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloresUni
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            pnlOpVentas.Visible = true;
            pnlProductos.Visible = false;
            pnlProveedores.Visible = false;
        }

        private void btnNuevoV_Click(object sender, EventArgs e)
        {
            pnlOpVentas.Visible = false;
            Form frm2 = new frmVentas();
            frm2.Show();
            this.Hide();
        }

        private void btnRealizadoV_Click(object sender, EventArgs e)
        {
            pnlOpVentas.Visible = false;
            Form frm3 = new frmVentasRealizadas();
            frm3.Show();
            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            pnlProductos.Visible = true;

            pnlOpVentas.Visible = false;
            pnlProveedores.Visible = false;
        }

        private void btnNuevoP_Click(object sender, EventArgs e)
        {
            pnlProductos.Visible = false;
            Form frm4 = new frmProductosN();
            frm4.Show();
            this.Hide();
        }

        private void btnDisponible_Click(object sender, EventArgs e)
        {
            pnlProductos.Visible = false;
            Form frm5 = new frmExistentesF();
            frm5.Show();
            this.Hide();
        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            pnlProductos.Visible = false;
            Form frm6 = new frmTPrecio();
            frm6.Show();
            this.Hide();

        }

        private void btnProvee_Click(object sender, EventArgs e)
        {
            pnlProveedores.Visible = true;

            pnlOpVentas.Visible = false;
            pnlProductos.Visible = false;
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            pnlProveedores.Visible = false;
            pnlOpVentas.Visible = false;
            pnlProductos.Visible = false;

            Form frm7 = new frmFacturas();
            frm7.Show();
            this.Hide();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            pnlProveedores.Visible = false;
            pnlOpVentas.Visible = false;
            pnlProductos.Visible = false;

            Form frm8 = new frmCliente();
            frm8.Show();
            this.Hide();
        }

        private void btnNuevoProvee_Click(object sender, EventArgs e)
        {
            pnlProveedores.Visible = false;
            Form frm9 = new frmProveedor();
            frm9.Show();
            this.Hide();

        }

        private void btnTotalProvee_Click(object sender, EventArgs e)
        {
            pnlProveedores.Visible = false;
            Form frm10 = new frmTotalProveedor();
            frm10.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm11 = new frmInicio();
            frm11.Show();
            this.Hide();
        }
    }
}
