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

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            LogInUsuario frm = new LogInUsuario();
            frm.Visible = true;
            this.Visible = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VentanaCatalogoUsuarios frm = new VentanaCatalogoUsuarios();
            frm.Visible = true;
        }
    }
}
