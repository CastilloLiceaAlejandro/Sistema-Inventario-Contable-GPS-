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
            Modelo.listaCompras(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentanaNuevaCompra frm = new VentanaNuevaCompra();
            frm.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modelo.listaCompras(dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VentanaModificarCompra frm = new VentanaModificarCompra();
            frm.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VentanaBorrarCompra frm = new VentanaBorrarCompra();
            frm.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Modelo.busquedalistaCompras(int.Parse(textBox1.Text));
        }
    }
}
