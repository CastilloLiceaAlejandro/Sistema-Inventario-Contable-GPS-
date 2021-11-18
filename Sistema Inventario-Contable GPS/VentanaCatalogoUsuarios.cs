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
    public partial class VentanaCatalogoUsuarios : Form
    {
        public VentanaCatalogoUsuarios()
        {
            InitializeComponent();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            RegistroDeUsuario frm = new RegistroDeUsuario();
            frm.Visible = true;
        }
    }
}
