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
            labelnombre.Text = Session.nombre;

            if (Session.id_tipo == 2)
            {
                this.comprasToolStripMenuItem.Visible = false;
                this.entradasInventarioToolStripMenuItem.Visible = false;
                this.salidaDeAlmacenToolStripMenuItem.Visible = false;
                this.toolStripMenuItem1.Visible = false;
                this.sucursalToolStripMenuItem.Visible = false;
                this.usuariosToolStripMenuItem.Visible = false;

            }

            if (Session.id_tipo == 3)
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

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Session.id_tipo == 1)
            {
                this.Text = "Administrador";
            }
            if (Session.id_tipo == 2)
            {
                this.Text = "Cajero";

            }
            if (Session.id_tipo == 3)
            {
                this.Text = "Almacenista";

            }
        }
        private void entradasInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

    }
}
