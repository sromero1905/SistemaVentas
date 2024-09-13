namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuMantedor = new FontAwesome.Sharp.IconMenuItem();
            this.subMneuCategoria = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuProducto = new FontAwesome.Sharp.IconMenuItem();
            this.menuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.menuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.menuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.menuAcercade = new FontAwesome.Sharp.IconMenuItem();
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.SubMenuRegistrar = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuVerDetalleVenta = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuRegistrarCompra = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuVerDetalleCompra = new FontAwesome.Sharp.IconMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuMantedor,
            this.menuVentas,
            this.menuCompras,
            this.menuClientes,
            this.menuProveedores,
            this.menuReportes,
            this.menuAcercade});
            this.menu.Location = new System.Drawing.Point(0, 54);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1087, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.AutoSize = false;
            this.menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UsersGear;
            this.menuUsuarios.IconColor = System.Drawing.Color.Black;
            this.menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUsuarios.IconSize = 50;
            this.menuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(80, 69);
            this.menuUsuarios.Text = "Usuarios";
            this.menuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click);
            // 
            // menuMantedor
            // 
            this.menuMantedor.AutoSize = false;
            this.menuMantedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMneuCategoria,
            this.SubmenuProducto});
            this.menuMantedor.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.menuMantedor.IconColor = System.Drawing.Color.Black;
            this.menuMantedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuMantedor.IconSize = 50;
            this.menuMantedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuMantedor.Name = "menuMantedor";
            this.menuMantedor.Size = new System.Drawing.Size(122, 69);
            this.menuMantedor.Text = "Mantedor";
            this.menuMantedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMneuCategoria
            // 
            this.subMneuCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMneuCategoria.IconColor = System.Drawing.Color.Black;
            this.subMneuCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMneuCategoria.Name = "subMneuCategoria";
            this.subMneuCategoria.Size = new System.Drawing.Size(180, 22);
            this.subMneuCategoria.Text = "Categoria";
            this.subMneuCategoria.Click += new System.EventHandler(this.subMneuCategoria_Click);
            // 
            // SubmenuProducto
            // 
            this.SubmenuProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubmenuProducto.IconColor = System.Drawing.Color.Black;
            this.SubmenuProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuProducto.Name = "SubmenuProducto";
            this.SubmenuProducto.Size = new System.Drawing.Size(180, 22);
            this.SubmenuProducto.Text = "Producto";
            this.SubmenuProducto.Click += new System.EventHandler(this.SubmenuProducto_Click);
            // 
            // menuVentas
            // 
            this.menuVentas.AutoSize = false;
            this.menuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuRegistrar,
            this.SubMenuVerDetalleVenta});
            this.menuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menuVentas.IconColor = System.Drawing.Color.Black;
            this.menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVentas.IconSize = 50;
            this.menuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.Size = new System.Drawing.Size(122, 69);
            this.menuVentas.Text = "Ventas";
            this.menuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuCompras
            // 
            this.menuCompras.AutoSize = false;
            this.menuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuRegistrarCompra,
            this.SubMenuVerDetalleCompra});
            this.menuCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.menuCompras.IconColor = System.Drawing.Color.Black;
            this.menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCompras.IconSize = 50;
            this.menuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.Size = new System.Drawing.Size(80, 69);
            this.menuCompras.Text = "Compras";
            this.menuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuClientes
            // 
            this.menuClientes.AutoSize = false;
            this.menuClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.menuClientes.IconColor = System.Drawing.Color.Black;
            this.menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuClientes.IconSize = 50;
            this.menuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(80, 69);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuProveedores
            // 
            this.menuProveedores.AutoSize = false;
            this.menuProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menuProveedores.IconColor = System.Drawing.Color.Black;
            this.menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuProveedores.IconSize = 50;
            this.menuProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuProveedores.Name = "menuProveedores";
            this.menuProveedores.Size = new System.Drawing.Size(80, 69);
            this.menuProveedores.Text = "Proveedores";
            this.menuProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuProveedores.Click += new System.EventHandler(this.menuProveedores_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.AutoSize = false;
            this.menuReportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.menuReportes.IconColor = System.Drawing.Color.Black;
            this.menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuReportes.IconSize = 50;
            this.menuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(80, 69);
            this.menuReportes.Text = "Reportes";
            this.menuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuReportes.Click += new System.EventHandler(this.menuReportes_Click);
            // 
            // menuAcercade
            // 
            this.menuAcercade.AutoSize = false;
            this.menuAcercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menuAcercade.IconColor = System.Drawing.Color.Black;
            this.menuAcercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAcercade.IconSize = 50;
            this.menuAcercade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAcercade.Name = "menuAcercade";
            this.menuAcercade.Size = new System.Drawing.Size(80, 69);
            this.menuAcercade.Text = "Acerca De";
            this.menuAcercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
          
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(1087, 54);
            this.menutitulo.TabIndex = 1;
            this.menutitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "SistemaVentas";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 127);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1087, 436);
            this.contenedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(886, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario: ";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuario.Location = new System.Drawing.Point(952, 18);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 20);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "lblUsuario";
            // 
            // SubMenuRegistrar
            // 
            this.SubMenuRegistrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuRegistrar.IconColor = System.Drawing.Color.Black;
            this.SubMenuRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuRegistrar.Name = "SubMenuRegistrar";
            this.SubMenuRegistrar.Size = new System.Drawing.Size(180, 22);
            this.SubMenuRegistrar.Text = "Registrar";
            this.SubMenuRegistrar.Click += new System.EventHandler(this.SubMenuRegistrar_Click);
            // 
            // SubMenuVerDetalleVenta
            // 
            this.SubMenuVerDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuVerDetalleVenta.IconColor = System.Drawing.Color.Black;
            this.SubMenuVerDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuVerDetalleVenta.Name = "SubMenuVerDetalleVenta";
            this.SubMenuVerDetalleVenta.Size = new System.Drawing.Size(180, 22);
            this.SubMenuVerDetalleVenta.Text = "Ver Detalle";
            this.SubMenuVerDetalleVenta.Click += new System.EventHandler(this.SubMenuVerDetalleVenta_Click);
            // 
            // SubMenuRegistrarCompra
            // 
            this.SubMenuRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuRegistrarCompra.IconColor = System.Drawing.Color.Black;
            this.SubMenuRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuRegistrarCompra.Name = "SubMenuRegistrarCompra";
            this.SubMenuRegistrarCompra.Size = new System.Drawing.Size(180, 22);
            this.SubMenuRegistrarCompra.Text = "Registrar Compra";
            this.SubMenuRegistrarCompra.Click += new System.EventHandler(this.SubMenuRegistrarCompra_Click);
            // 
            // SubMenuVerDetalleCompra
            // 
            this.SubMenuVerDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuVerDetalleCompra.IconColor = System.Drawing.Color.Black;
            this.SubMenuVerDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuVerDetalleCompra.Name = "SubMenuVerDetalleCompra";
            this.SubMenuVerDetalleCompra.Size = new System.Drawing.Size(180, 22);
            this.SubMenuVerDetalleCompra.Text = "Ver Detalle";
            this.SubMenuVerDetalleCompra.Click += new System.EventHandler(this.SubMenuVerDetalleCompra_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 563);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menutitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuMantedor;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuProveedores;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private FontAwesome.Sharp.IconMenuItem menuAcercade;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsuario;
        private FontAwesome.Sharp.IconMenuItem subMneuCategoria;
        private FontAwesome.Sharp.IconMenuItem SubmenuProducto;
        private FontAwesome.Sharp.IconMenuItem SubMenuRegistrar;
        private FontAwesome.Sharp.IconMenuItem SubMenuVerDetalleVenta;
        private FontAwesome.Sharp.IconMenuItem SubMenuRegistrarCompra;
        private FontAwesome.Sharp.IconMenuItem SubMenuVerDetalleCompra;
    }
}

