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
    public partial class VentanaMovimientosCompras : Form
    {
        public VentanaMovimientosCompras()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentanaNuevaCompra frm = new VentanaNuevaCompra();
            frm.Visible = true;
        }
    }
}
