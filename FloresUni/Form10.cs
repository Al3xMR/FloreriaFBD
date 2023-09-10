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
    public partial class frmTotalProveedor : Form
    {
        public frmTotalProveedor()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnFinalizarRevision_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm12 = new frmMenu();
            frm12.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmTotalProveedor_Load(object sender, EventArgs e)
        {
            string strConn = "Data Source=(local); Initial Catalog = Floreria; Integrated Security = SSPI";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string strComm = "SELECT * FROM Proveedores";
            SqlDataAdapter adapter = new SqlDataAdapter(strComm, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dvgProveedores.DataSource = dataTable;
            conn.Close();

            dvgProveedores.Columns["id_prov"].HeaderText = "ID";
            dvgProveedores.Columns["nombre_prov"].HeaderText = "Nombre del Proveedor";
            dvgProveedores.Columns["ciudad_prov"].HeaderText = "Ciudad";
            dvgProveedores.Columns["dir_prov"].HeaderText = "Dirección";
        }
    }
}
