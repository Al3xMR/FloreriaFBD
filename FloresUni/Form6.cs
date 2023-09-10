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
    public partial class frmExistentesF : Form
    {
        public frmExistentesF()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnFinalizarRevisionF_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm12 = new frmMenu();
            frm12.Show();
        }

        private void cmbListaOPRevisar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmExistentesF_Load(object sender, EventArgs e)
        {
            string strConn = "Data Source=(local); Initial Catalog = Floreria; Integrated Security = SSPI";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string strComm = "SELECT * FROM Flores";
            SqlDataAdapter adapter = new SqlDataAdapter(strComm, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvFlores.DataSource = dataTable;
            conn.Close();

            dgvFlores.Columns["id_flor"].HeaderText = "ID";
            dgvFlores.Columns["nom_com"].HeaderText = "Nombre Común";
            dgvFlores.Columns["nom_cie"].HeaderText = "Nombre Científico";
            dgvFlores.Columns["color"].HeaderText = "Color";
            dgvFlores.Columns["id_prov"].HeaderText = "ID Proveedor";
            dgvFlores.Columns["cantidad_dispo"].HeaderText = "Cantidad Disponible";
        }
    }
}
