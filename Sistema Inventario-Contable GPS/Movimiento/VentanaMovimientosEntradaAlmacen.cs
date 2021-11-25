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
    public partial class VentanaMovimientosEntradaAlmacen : Form
    {
        public VentanaMovimientosEntradaAlmacen()
        {
            InitializeComponent();
            Modelo.listaEntradas(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentanaNuevaEntradasAlmacen frm = new VentanaNuevaEntradasAlmacen();
            frm.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modelo.listaEntradas(dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VentanaTmodificarE frm = new VentanaTmodificarE();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VentaBorrarEntrada frm = new VentaBorrarEntrada();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Modelo.busquedalistaEntrada(int.Parse(textBox1.Text));
        }
    }
}
