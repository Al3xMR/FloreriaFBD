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
    public partial class frmTPrecio : Form
    {
        public frmTPrecio()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnFinalizarTipo_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm12 = new frmMenu();
            frm12.Show();
        }

        private void frmTPrecio_Load(object sender, EventArgs e)
        {
            string strConn = "Data Source=(local); Initial Catalog = Floreria; Integrated Security = SSPI";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string strComm = "SELECT tipo, tamanio, precio_arreglo, disponibilidad, ocasion FROM Arreglos";
            SqlDataAdapter adapter = new SqlDataAdapter(strComm, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvArreglos.DataSource = dataTable;
            conn.Close();

            dgvArreglos.Columns["tipo"].HeaderText = "Nombre del arreglo";
            dgvArreglos.Columns["tamanio"].HeaderText = "Tamaño";
            dgvArreglos.Columns["precio_arreglo"].HeaderText = "Precio unitario";
            dgvArreglos.Columns["disponibilidad"].HeaderText = "Disponibilidad";
            dgvArreglos.Columns["ocasion"].HeaderText = "Ocasión";
        }
    }
}
