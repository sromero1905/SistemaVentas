using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual ;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public Inicio(Usuario objusuario = null)
        {
            if (objusuario == null) 
                usuarioActual = new Usuario() { NombreCompleto = "ADMIN1", IdUsuario = 1 };

            else
                usuarioActual = objusuario;



          
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);

            foreach (IconMenuItem iconMenu in menu.Items)
            {
                bool encontrado = ListaPermisos.Any(m=>m.NombreMenu == iconMenu.Name);
                if(encontrado == false)
                {
                    iconMenu.Visible = false;
                } 


            }


            lblUsuario.Text = usuarioActual.NombreCompleto;
        }


        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {


            if (MenuActivo!= null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;


            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;
            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender,new frmUser());

        }

        private void subMneuCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuMantedor, new frmCategoria());
        }

        private void SubmenuProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuMantedor, new frmProducto());
        }

        private void SubMenuRegistrar_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuVentas, new frmVentas());
        }

        private void SubMenuVerDetalleVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuVentas, new frmDetalleVenta());
        }

        private void SubMenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuCompras, new frmCompras());
        }

        private void SubMenuVerDetalleCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuCompras, new DetalleCompra());
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedores());
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmReportes());
        }

      
    }
}
