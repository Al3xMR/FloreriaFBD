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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string contra = txtContraseña.Text;
            string contraC = "hola";
            if(contra== contraC)
            {
                
                Form from1 = new frmMenu();
                from1.Show();
                this.Hide();
            }
            else
            {
              
                MessageBox.Show("Contraseña Incorrecta, Ingrese de nuevo.");
                
            }
            
            txtContraseña.Clear();
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string contra = txtContraseña.Text;
                string contraC = "hola";
                if (contra == contraC)
                {

                    Form from1 = new frmMenu();
                    from1.Show();
                    this.Hide();
                }
                else
                {

                    MessageBox.Show("Contraseña Incorrecta, Ingrese de nuevo.");

                }

                txtContraseña.Clear();
            }
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            txtContraseña.Select();
        }
    }
}
