using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Inventario_Contable_GPS
{
    public partial class VentanaAdmin : Form
    {
        public VentanaAdmin()
        {
            InitializeComponent();

            if (Session.id_puesto == 1)
            {
                labelnombre.Text = "Administrador";

            }

            if (Session.id_puesto == 2)
            {
                this.comprasToolStripMenuItem.Visible = false;
                this.entradasInventarioToolStripMenuItem.Visible = false;
                this.salidaDeAlmacenToolStripMenuItem.Visible = false;
                this.toolStripMenuItem1.Visible = false;
                this.sucursalToolStripMenuItem.Visible = false;
                this.usuariosToolStripMenuItem.Visible = false;

                labelnombre.Text = "Cajero";
            }

            if (Session.id_puesto == 3)
            {
                this.comprasToolStripMenuItem.Visible = false;
                this.ventasToolStripMenuItem.Visible = false;
                this.entradasInventarioToolStripMenuItem.Visible = false;
                this.salidaDeAlmacenToolStripMenuItem.Visible = false;
                this.toolStripMenuItem1.Visible = false;
                this.sucursalToolStripMenuItem.Visible = false;
                this.comprasToolStripMenuItem1.Visible = false;
                this.ventasToolStripMenuItem1.Visible = false;
                this.usuariosToolStripMenuItem.Visible = false;

                labelnombre.Text = "Almacenista";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Session.id_puesto == 1)
            {
                this.Text = "Administrador";
            }
            if (Session.id_puesto == 2)
            {
                this.Text = "Cajero";

            }
            if (Session.id_puesto == 3)
            {
                this.Text = "Almacenista";

            }
        }
        private void entradasInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaMovimientosEntradaAlmacen frm = new VentanaMovimientosEntradaAlmacen();
            frm.Visible = true;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cambiarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            LogInUsuario frm = new LogInUsuario();
            frm.Visible = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VentanaCatalogoUsuarios frm = new VentanaCatalogoUsuarios();
            frm.Visible = true;
        }

        private void labelnombre_Click(object sender, EventArgs e)
        {

        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaMovimientosCompras frm = new VentanaMovimientosCompras();
            frm.Visible = true;
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaMovimientosVentas frm = new VentanaMovimientosVentas();
            frm.Visible = true;
        }

        private void salidaDeAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaMovimientosSalidasAlmacen frm = new VentanaMovimientosSalidasAlmacen();
            frm.Visible = true;
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VentanaMovimientosRepisa frm = new VentanaMovimientosRepisa();
            frm.Visible = true;
        }

        private void materiaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaCatalogoMateriaPrima frm = new VentanaCatalogoMateriaPrima();
            frm.Visible = true;
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaCatalogoProducto frm = new VentanaCatalogoProducto();
            frm.Visible = true;
        }

        private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaCatalogoSucursal frm = new VentanaCatalogoSucursal();
            frm.Visible = true;
        }
    }
}
