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
    public partial class frmFacturas : Form
    {
        public frmFacturas()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnFinalizarFactu_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm12 = new frmMenu();
            frm12.Show();
        }

        private void btnRevisarFactura_Click(object sender, EventArgs e)
        {

        }

        private void lblRevision_Click(object sender, EventArgs e)
        {

        }

        private void cmbRevisionOp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRevisionOp.SelectedItem.ToString() == "ID Empleado")
            {
                cmbSelectorIdVendedor.Enabled = true;
                string strConn = "Data Source=(local); Initial Catalog = Floreria; Integrated Security=SSPI";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                string strComm = "SELECT id_empleado FROM Empleados WHERE cargo_emp = 'Vendedor'";
                SqlDataAdapter adapter = new SqlDataAdapter(strComm, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                conn.Close();
                cmbSelectorIdVendedor.DataSource = dataTable;
                cmbSelectorIdVendedor.DisplayMember = "id_empleado";
            }
            else
            {
                cmbSelectorIdVendedor.Enabled = false;
            }
        }

        private void cmbSelectorIdVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRevisar_Click(object sender, EventArgs e)
        {
            if (cmbRevisionOp.SelectedItem.ToString() == "ID Empleado")
            {
                string strConn = "Data Source=(local); Initial Catalog = Floreria; Integrated Security = SSPI";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                string strComm = "SELECT * FROM Facturas WHERE id_empleado = " +
                    ((DataRowView)cmbSelectorIdVendedor.SelectedItem)["id_empleado"].ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(strComm, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvListaFacturas.DataSource = dataTable;
                conn.Close();

            }
            else
            {
                string strConn = "Data Source=(local); Initial Catalog = Floreria; Integrated Security = SSPI";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                string strComm = "SELECT * FROM Facturas";
                SqlDataAdapter adapter = new SqlDataAdapter(strComm, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvListaFacturas.DataSource = dataTable;
                conn.Close();
            }
            dgvListaFacturas.Columns["num_factura"].HeaderText = "# Fact.";
            dgvListaFacturas.Columns["total"].HeaderText = "Total";
            dgvListaFacturas.Columns["iva"].HeaderText = "IVA";
            dgvListaFacturas.Columns["fecha_fact"].HeaderText = "Fecha";
            dgvListaFacturas.Columns["id_cliente"].HeaderText = "ID Cliente";
            dgvListaFacturas.Columns["id_empleado"].HeaderText = "ID Vendedor";

        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            cmbRevisionOp.SelectedIndex = 0;
        }
    }
}
