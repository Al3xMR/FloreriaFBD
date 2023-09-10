using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FloresUni
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm12 = new frmMenu();
            frm12.Show();
        }

        private void btnContinuarV_Click(object sender, EventArgs e)
        {
            string strConn = "Data Source=(local); Initial Catalog = Floreria; Integrated Security=SSPI";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            decimal precio = ObtenerPrecio();
            string strComm = "INSERT INTO Facturas(num_factura, total, iva, fecha_fact, id_cliente, id_empleado)" +
                " VALUES (" + (ObtenerUltimoID_Factura() + 1).ToString() + ", " + precio.ToString() + ", " +
                (Convert.ToDouble(precio) * 0.12).ToString() + ", CAST('" + txtFecha.Text + "' AS DATE), " +
                Convert.ToString(ObtenerID_Cliente()) + ", " + txtIdEmpleado.Text + " )";
            SqlCommand comm = new SqlCommand(strComm, conn);
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Venta realizada con éxito.");
            Form frm1 = new frmMenu();
            frm1.Show();
            this.Close();
        }

        private int ObtenerUltimoID_Factura()
        {
            string strConn = "Data Source=(local); Initial Catalog = Floreria; Integrated Security=SSPI";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string strComm = "SELECT TOP 1 num_factura FROM Facturas ORDER BY num_factura DESC";
            SqlCommand comm = new SqlCommand(strComm, conn);
            int retorno = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();
            return retorno;
        }

        private int ObtenerID_Cliente()
        {

            string strConn = "Data Source=(local); Initial Catalog = Floreria; Integrated Security=SSPI";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string nombre = txtNombre.Text;
            string strComm = "SELECT id_cliente FROM Clientes WHERE nombre_cli = '" + nombre + "'";
            SqlCommand comm = new SqlCommand(strComm, conn);
            int retorno = Convert.ToInt32(comm.ExecuteScalar());
            if (retorno == 0)
            {
                conn.Close();
                string strConn2 = "Data Source=(local); Initial Catalog = Floreria; Integrated Security=SSPI";
                SqlConnection conn2 = new SqlConnection(strConn2);
                conn2.Open();
                string strComm2 = "SELECT TOP 1 id_cliente FROM Clientes ORDER BY id_cliente DESC";
                SqlCommand comm2 = new SqlCommand(strComm2, conn2);
                int nuevaID = Convert.ToInt32(comm2.ExecuteScalar()) + 1;
                conn2.Close();
                CrearCliente(nuevaID);
                return nuevaID;
            }
            else
            {
                conn.Close();
                return retorno;
            }

        }

        private void CrearCliente(int ID)
        {
            string strConn = "Data Source=(local); Initial Catalog = Floreria; Integrated Security=SSPI";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string strComm = "INSERT INTO Clientes VALUES (" + ID.ToString() + ", '" + txtNombre.Text + "', '" +
                txtDireccion.Text + "', '" + txtTelefono.Text + "', NULL)";
            SqlCommand comm = new SqlCommand(strComm, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }


        private decimal ObtenerPrecio()
        {
            string strConn = "Data Source=(local); Initial Catalog = Floreria; Integrated Security=SSPI";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string valorSeleccionado = ((DataRowView)cmbArreglo.SelectedItem)["tipo"].ToString();
            string strComm = "SELECT precio_arreglo FROM Arreglos WHERE tipo = '" + valorSeleccionado + "'";
            SqlCommand comm = new SqlCommand(strComm, conn);
            decimal retorno = Convert.ToDecimal(comm.ExecuteScalar());
            conn.Close();
            return retorno;
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            RellenarCmbArreglo();

        }

        private void RellenarCmbArreglo()
        {
            string strConn = "Data Source=(local); Initial Catalog = Floreria; Integrated Security=SSPI";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string strComm = "SELECT tipo FROM Arreglos";
            SqlDataAdapter adapter = new SqlDataAdapter(strComm, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cmbArreglo.DataSource = dataTable;
            cmbArreglo.DisplayMember = "tipo";
            conn.Close();
        }

        private void cmbFlores_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarPrecio();
        }

        private void MostrarPrecio()
        {
            string strConn = "Data Source=(local); Initial Catalog = Floreria; Integrated Security=SSPI";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string valorSeleccionado = ((DataRowView)cmbArreglo.SelectedItem)["tipo"].ToString();
            string strComm = "SELECT precio_arreglo FROM Arreglos WHERE tipo = '" + valorSeleccionado + "'";
            SqlCommand comm = new SqlCommand(strComm, conn);
            decimal precio = Convert.ToDecimal(comm.ExecuteScalar());
            txtPrecio.Text = " $ " + precio.ToString();
            conn.Close();
        }
    }
}
