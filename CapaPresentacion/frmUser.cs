using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;
using CapaEntidad;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            cboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";
            cboEstado.SelectedIndex = 0;



            List<Rol> listaRol = new CN_Rol().Listar();

            foreach (Rol item in listaRol)
            {
                cboRol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });

            }
            cboRol.DisplayMember = "Texto";
            cboRol.ValueMember = "Valor";
            cboRol.SelectedIndex = 0;



            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {

                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    cboBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;

        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            dgvdata.Rows.Add(new object[] { "", txtId.Text, txtDocumento.Text, txtNombreCompleto.Text, txtCorreo.Text,txtclave.Text,
                ((OpcionCombo)cboRol.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cboRol.SelectedItem).Texto.ToString(),
                ((OpcionCombo)cboEstado.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cboEstado.SelectedItem).Texto.ToString(),
            });
            this.limpiar();
        }

        private void limpiar()
        {
            txtId.Text = "0";
            txtCorreo.Text = string.Empty;
            txtDocumento.Text = string.Empty;
            txtNombreCompleto.Text = string.Empty;
            txtclave.Text = string.Empty;
            txtConfirmarClave.Text = string.Empty;
            cboRol.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;

        }
    }
}
