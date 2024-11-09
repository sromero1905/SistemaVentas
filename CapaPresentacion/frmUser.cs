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
using System.Net.Http.Headers;
using System.Windows.Media;


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




            //mostrar todos los usuarios
            List<Usuario> ListaUsuario = new CN_Usuario().Listar();
            foreach (Usuario item in ListaUsuario)
            {
                dgvdata.Rows.Add(new object[] { "", item.IdUsuario,item.NombreCompleto,item.Documento,item.Correo,item.Clave,
                item.oRol.IdRol,
                item.oRol.Descripcion,
                item.Estado == true ?1 :0,
                item.Estado == true ? "Activo" : "Inactivo"
            });

            }
           

        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Usuario objusuario = new Usuario()
            {
    
                IdUsuario = Convert.ToInt32(txtId.Text),
                Documento = txtDocumento.Text,
                NombreCompleto = txtNombreCompleto.Text,
                Correo = txtCorreo.Text,
                Clave = txtclave.Text,
                oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)cboRol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cboEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objusuario.IdUsuario == 0)
            {

                int IdUsuarioGenerado = new CN_Usuario().Registrar(objusuario, out mensaje);

                if (IdUsuarioGenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] { "", IdUsuarioGenerado, txtDocumento.Text, txtNombreCompleto.Text, txtCorreo.Text,txtclave.Text,
                            ((OpcionCombo)cboRol.SelectedItem).Valor.ToString(),
                            ((OpcionCombo)cboRol.SelectedItem).Texto.ToString(),
                            ((OpcionCombo)cboEstado.SelectedItem).Valor.ToString(),
                            ((OpcionCombo)cboEstado.SelectedItem).Texto.ToString(),
                        });
                    this.limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }


            }
            else
            {
               bool resultado = new CN_Usuario().Editar(objusuario, out mensaje);

                if (resultado == true)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["Id"].Value = txtId.Text;
                    row.Cells["Documento"].Value = txtDocumento.Text;
                    row.Cells["NombreCompleto"].Value = txtNombreCompleto.Text;
                    row.Cells["Correo"].Value = txtCorreo.Text;
                    row.Cells["Clave"].Value = txtclave.Text;
                    row.Cells["IdRol"].Value = ((OpcionCombo)cboRol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((OpcionCombo)cboRol.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboEstado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cboEstado.SelectedItem).Texto.ToString();

                    this.limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }


            }



            
           
        }

        private void limpiar()
        {
            txtIndice.Text = string.Empty;
            txtId.Text = "0";
            txtCorreo.Text = string.Empty;
            txtDocumento.Text = string.Empty;
            txtNombreCompleto.Text = string.Empty;
            txtclave.Text = string.Empty;
            txtConfirmarClave.Text = string.Empty;
            cboRol.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;
            txtDocumento.Select();

        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if(e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);


                var w = Properties.Resources.check_line.Width;
                var h = Properties.Resources.check_line.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check_line, new Rectangle(x, y, w, h));
                e.Handled = true;
            }



            
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if(indice>= 0){
                    txtIndice.Text = indice.ToString();
                    txtId.Text = dgvdata.Rows[indice].Cells["Id"].Value.ToString();
                    txtDocumento.Text = dgvdata.Rows[indice].Cells["Documento"].Value.ToString();
                    txtNombreCompleto.Text = dgvdata.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtclave.Text = dgvdata.Rows[indice].Cells["Clave"].Value.ToString();
                    txtCorreo.Text = dgvdata.Rows[indice].Cells["Correo"].Value.ToString();
                    txtConfirmarClave.Text = dgvdata.Rows[indice].Cells["Clave"].Value.ToString();

                    foreach (OpcionCombo oc in cboRol.Items)
                    {
                        if (Convert.ToInt32( oc.Valor) ==Convert.ToInt32(dgvdata.Rows[indice].Cells["IdRol"].Value))
                        {
                            int indice_combo = cboRol.Items.IndexOf(oc);
                            cboRol.SelectedIndex = indice_combo;
                            break;
                        }
                    }



                    foreach (OpcionCombo oc in cboEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cboEstado.Items.IndexOf(oc);
                            cboEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }




        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Usuario objusuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txtId.Text),
            };
            string mensaje = string.Empty;

            if (Convert.ToInt32(txtId.Text) !=0)
            {
                if (MessageBox.Show("Desea Elimninar El Usuario?","Mensaje",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool respuesta = new CN_Usuario().Eliminar ( objusuario, out mensaje);

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32( txtIndice.Text));
                        this.limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                } 
            }
        }
    }
}
