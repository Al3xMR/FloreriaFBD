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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnFinalizarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm12 = new frmMenu();
            frm12.Show();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            string strConn = "Data Source=(local); Initial Catalog = Floreria; Integrated Security = SSPI";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string strComm = "SELECT * FROM Clientes";
            SqlDataAdapter adapter = new SqlDataAdapter(strComm, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dvgClientes.DataSource = dataTable;
            conn.Close();

            dvgClientes.Columns["id_cliente"].HeaderText = "ID";
            dvgClientes.Columns["nombre_cli"].HeaderText = "Nombre de Cliente";
            dvgClientes.Columns["dir_cli"].HeaderText = "Domicilio";
            dvgClientes.Columns["tel_cli"].HeaderText = "Teléfono";
            dvgClientes.Columns["fecha_nac"].HeaderText = "Fecha de Nacimiento";
        }
    }
}
