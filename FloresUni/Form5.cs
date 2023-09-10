using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FloresUni
{
    public partial class frmProductosN : Form
    {
        public frmProductosN()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFinalizarIngreso_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm12 = new frmMenu();
            frm12.Show();
        }

        private int ObtenerUltimoID_Flores()
        {
            string strConn = "Data Source=(local); Initial Catalog = Floreria; Integrated Security=SSPI";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string strComm = "SELECT TOP 1 id_flor FROM Flores ORDER BY id_flor DESC";
            SqlCommand comm = new SqlCommand(strComm, conn);
            int retorno = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();
            return retorno;
        }

        private int ObtenerCantidadFlores(int id_flor)
        {
            string strConn = "Data Source=(local); Initial Catalog = Floreria; Integrated Security=SSPI";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string strComm = "SELECT cantidad_dispo FROM Flores WHERE id_flor = " + id_flor.ToString();
            SqlCommand comm = new SqlCommand(strComm, conn);
            int retorno = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();
            return retorno;
        }

        private int ObtenerID_Flor(string nomCom)
        {
            string strConn = "Data Source=(local); Initial Catalog = Floreria; Integrated Security=SSPI";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string strComm = "SELECT id_flor FROM Flores WHERE nom_com = '" + nomCom +"'";
            SqlCommand comm = new SqlCommand(strComm, conn);
            int retorno = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();
            return retorno;
        }

        private void AgregarFlor(string nomCom, string nomCie, string color, string idProv, int cantidad)
        {
            string strConn = "Data Source=(local); Initial Catalog = Floreria; Integrated Security=SSPI";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string strComm = "INSERT INTO Flores VALUES (" + (ObtenerUltimoID_Flores() + 1) + ", '" + 
                nomCom + "', '" + nomCie + "', '" + color + "', " + idProv + ", " + cantidad + ")";
            SqlCommand comm = new SqlCommand(strComm, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreFlor = txtNombreCom.Text;
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int id = ObtenerID_Flor(nombreFlor);
            if (id == 0)
            {
                AgregarFlor(nombreFlor, txtNombCient.Text, txtColor.Text, txtIDProveedor.Text, cantidad);
            }
            else
            {
                cantidad = cantidad + ObtenerCantidadFlores(id);
                string strConn = "Data Source=(local); Initial Catalog = Floreria; Integrated Security=SSPI";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                string strComm = "UPDATE Flores SET cantidad_dispo = " + cantidad + "WHERE id_flor = " + id;
                SqlCommand comm = new SqlCommand(strComm, conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show("Flores ingresadas con éxito en la base de datos");
            this.Close();
            Form frm12 = new frmMenu();
            frm12.Show();
        }
    }
}
