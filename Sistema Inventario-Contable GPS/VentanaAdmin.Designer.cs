
namespace Sistema_Inventario_Contable_GPS
{
    partial class VentanaAdmin
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
            this.AdminmenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaDeAlmacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AlertProdList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.AdminmenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminmenuStrip1
            // 
            this.AdminmenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.AdminmenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.movimientosToolStripMenuItem,
            this.catalogoToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.AdminmenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.AdminmenuStrip1.Name = "AdminmenuStrip1";
            this.AdminmenuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.AdminmenuStrip1.Size = new System.Drawing.Size(800, 28);
            this.AdminmenuStrip1.TabIndex = 0;
            this.AdminmenuStrip1.Text = "menuStrip1";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarUsuarioToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem1});
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.cerrarSesionToolStripMenuItem.Text = "Sesión";
            // 
            // cambiarUsuarioToolStripMenuItem
            // 
            this.cambiarUsuarioToolStripMenuItem.Name = "cambiarUsuarioToolStripMenuItem";
            this.cambiarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.cambiarUsuarioToolStripMenuItem.Text = "Cambiar Usuario";
            this.cambiarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.cambiarUsuarioToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem1
            // 
            this.cerrarSesionToolStripMenuItem1.Name = "cerrarSesionToolStripMenuItem1";
            this.cerrarSesionToolStripMenuItem1.Size = new System.Drawing.Size(202, 26);
            this.cerrarSesionToolStripMenuItem1.Text = "Cerrar Sesión";
            this.cerrarSesionToolStripMenuItem1.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem1_Click);
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.entradasInventarioToolStripMenuItem,
            this.salidaDeAlmacenToolStripMenuItem});
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.movimientosToolStripMenuItem.Text = "Movimientos";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // entradasInventarioToolStripMenuItem
            // 
            this.entradasInventarioToolStripMenuItem.Name = "entradasInventarioToolStripMenuItem";
            this.entradasInventarioToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.entradasInventarioToolStripMenuItem.Text = "Entrada de Almacen";
            this.entradasInventarioToolStripMenuItem.Click += new System.EventHandler(this.entradasInventarioToolStripMenuItem_Click);
            // 
            // salidaDeAlmacenToolStripMenuItem
            // 
            this.salidaDeAlmacenToolStripMenuItem.Name = "salidaDeAlmacenToolStripMenuItem";
            this.salidaDeAlmacenToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.salidaDeAlmacenToolStripMenuItem.Text = "Salida de Almacen";
            this.salidaDeAlmacenToolStripMenuItem.Click += new System.EventHandler(this.salidaDeAlmacenToolStripMenuItem_Click);
            // 
            // catalogoToolStripMenuItem
            // 
            this.catalogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.materiaPrimaToolStripMenuItem,
            this.sucursalToolStripMenuItem});
            this.catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            this.catalogoToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.catalogoToolStripMenuItem.Text = "Catalogo";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem1.Text = "Usuarios";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // materiaPrimaToolStripMenuItem
            // 
            this.materiaPrimaToolStripMenuItem.Name = "materiaPrimaToolStripMenuItem";
            this.materiaPrimaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.materiaPrimaToolStripMenuItem.Text = "Materia prima";
            this.materiaPrimaToolStripMenuItem.Click += new System.EventHandler(this.materiaPrimaToolStripMenuItem_Click);
            // 
            // sucursalToolStripMenuItem
            // 
            this.sucursalToolStripMenuItem.Name = "sucursalToolStripMenuItem";
            this.sucursalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sucursalToolStripMenuItem.Text = "Sucursal";
            this.sucursalToolStripMenuItem.Click += new System.EventHandler(this.sucursalToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasToolStripMenuItem1,
            this.ventasToolStripMenuItem1,
            this.almacenToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // comprasToolStripMenuItem1
            // 
            this.comprasToolStripMenuItem1.Name = "comprasToolStripMenuItem1";
            this.comprasToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.comprasToolStripMenuItem1.Text = "Compras";
            this.comprasToolStripMenuItem1.Click += new System.EventHandler(this.comprasToolStripMenuItem1_Click);
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.ventasToolStripMenuItem1.Text = "Ventas";
            this.ventasToolStripMenuItem1.Click += new System.EventHandler(this.ventasToolStripMenuItem1_Click);
            // 
            // almacenToolStripMenuItem
            // 
            this.almacenToolStripMenuItem.Name = "almacenToolStripMenuItem";
            this.almacenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.almacenToolStripMenuItem.Text = "Almacen";
            this.almacenToolStripMenuItem.Click += new System.EventHandler(this.almacenToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sesionesToolStripMenuItem,
            this.movimientosToolStripMenuItem1});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // sesionesToolStripMenuItem
            // 
            this.sesionesToolStripMenuItem.Name = "sesionesToolStripMenuItem";
            this.sesionesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sesionesToolStripMenuItem.Text = "Sesiones";
            this.sesionesToolStripMenuItem.Click += new System.EventHandler(this.sesionesToolStripMenuItem_Click);
            // 
            // movimientosToolStripMenuItem1
            // 
            this.movimientosToolStripMenuItem1.Name = "movimientosToolStripMenuItem1";
            this.movimientosToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.movimientosToolStripMenuItem1.Text = "Movimientos";
            this.movimientosToolStripMenuItem1.Click += new System.EventHandler(this.movimientosToolStripMenuItem1_Click);
            // 
            // AlertProdList
            // 
            this.AlertProdList.FormattingEnabled = true;
            this.AlertProdList.ItemHeight = 16;
            this.AlertProdList.Location = new System.Drawing.Point(41, 66);
            this.AlertProdList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AlertProdList.Name = "AlertProdList";
            this.AlertProdList.Size = new System.Drawing.Size(329, 20);
            this.AlertProdList.TabIndex = 2;
            this.AlertProdList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alerta de existencias";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Location = new System.Drawing.Point(687, 0);
            this.labelnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(86, 17);
            this.labelnombre.TabIndex = 4;
            this.labelnombre.Text = "labelnombre";
            this.labelnombre.Click += new System.EventHandler(this.labelnombre_Click);
            // 
            // VentanaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AlertProdList);
            this.Controls.Add(this.AdminmenuStrip1);
            this.MainMenuStrip = this.AdminmenuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VentanaAdmin";
            this.Text = "Sistema Inventario-Contable";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentanaAdmin_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AdminmenuStrip1.ResumeLayout(false);
            this.AdminmenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AdminmenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidaDeAlmacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem almacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ListBox AlertProdList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem sesionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem catalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem materiaPrimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucursalToolStripMenuItem;
        private System.Windows.Forms.Label labelnombre;
    }
}

