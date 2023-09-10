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
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnFinalizarProvee_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm12 = new frmMenu();
            frm12.Show();
        }

        private void btnIngesarPro_Click(object sender, EventArgs e)
        {
            string strConn = "Data Source=(local); Initial Catalog = Floreria; Integrated Security=SSPI";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string strComm = "INSERT INTO Proveedores(id_prov, nombre_prov, ciudad_prov, dir_prov)" + 
                " VALUES(" + (ObtenerUltimoID_Proveedor()+1).ToString() + ", N'" + txtNombreProveed.Text + "', N'"
                + txtCiudad.Text + "', N'" + txtDirProvee.Text + "')";
            SqlCommand comm = new SqlCommand(strComm, conn);
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("El nuevo Proveedor se ha ingresado con exito");
            this.Close();
            Form frm12 = new frmMenu();
            frm12.Show();

        }
        private int ObtenerUltimoID_Proveedor()
        {
            string strConn = "Data Source=(local); Initial Catalog = Floreria; Integrated Security=SSPI";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string strComm = "SELECT TOP 1 id_prov FROM Proveedores ORDER BY id_prov DESC";
            SqlCommand comm = new SqlCommand(strComm, conn);
            int retorno = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();
            return retorno;
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
