using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
      
            List<Usuario> TEST = new CN_Usuario().Listar();

            

            // Busca el usuario con el documento y clave especificados
            Usuario ousuario = TEST.Where(p => p.Documento == txtDocumento.Text && p.Clave == txtPassword.Text).FirstOrDefault();

            if (ousuario!= null)
            {
                Inicio Form = new Inicio(ousuario);
                Form.Show();
                this.Hide();
                Form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("Usuario Invalido","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

            
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtDocumento.Text = string.Empty;
            txtPassword.Text = string.Empty;
            this.Show();
        }
    }
}
