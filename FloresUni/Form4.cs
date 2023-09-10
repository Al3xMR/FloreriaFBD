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
    public partial class frmVentasRealizadas : Form
    {
        public frmVentasRealizadas()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnRevisionF_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm12 = new frmMenu();
            frm12.Show();
        
        }

        private void cmbRevisionOp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbRevisionOp.SelectedItem.ToString()=="ID Empleado")
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

        private void btnRevisar_Click(object sender, EventArgs e)
        {
            if (cmbRevisionOp.SelectedItem.ToString() == "ID Empleado")
            {
                string strConn = "Data Source=(local); Initial Catalog = Floreria; Integrated Security = SSPI";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                string strComm = "SELECT nombre_cli, nombre_emp, tipo, fecha_fact FROM Clientes C INNER JOIN " +
                    "Facturas F ON (C.id_cliente = F.id_cliente) INNER JOIN Empleados E ON " +
                    "(F.id_empleado = E.id_empleado) INNER JOIN Items I ON (F.num_factura = I.num_factura) " +
                    "INNER JOIN Arreglos A ON (I.id_arreglo = A.id_arreglo) WHERE E.id_empleado = " + 
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
                string strComm = "SELECT nombre_cli, nombre_emp, tipo, fecha_fact FROM Clientes C INNER JOIN " +
                    "Facturas F ON (C.id_cliente = F.id_cliente) INNER JOIN Empleados E ON " +
                    "(F.id_empleado = E.id_empleado) INNER JOIN Items I ON (F.num_factura = I.num_factura) " +
                    "INNER JOIN Arreglos A ON (I.id_arreglo = A.id_arreglo)";
                SqlDataAdapter adapter = new SqlDataAdapter(strComm, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvListaFacturas.DataSource = dataTable;
                conn.Close();
            }
            dgvListaFacturas.Columns["nombre_cli"].HeaderText = "Cliente";
            dgvListaFacturas.Columns["nombre_emp"].HeaderText = "Vendedor";
            dgvListaFacturas.Columns["tipo"].HeaderText = "Compra";
            dgvListaFacturas.Columns["fecha_fact"].HeaderText = "Fecha";

        }

        private void frmVentasRealizadas_Load(object sender, EventArgs e)
        {
            cmbRevisionOp.SelectedIndex = 0;

        }

        private void dgvListaFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
