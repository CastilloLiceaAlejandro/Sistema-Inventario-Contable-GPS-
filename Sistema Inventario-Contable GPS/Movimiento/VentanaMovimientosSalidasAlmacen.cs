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
    public partial class VentanaMovimientosSalidasAlmacen : Form
    {
        public VentanaMovimientosSalidasAlmacen()
        {
            InitializeComponent();
            Modelo.listaSalidas(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentanaNuevaSalidasAlmacen frm = new VentanaNuevaSalidasAlmacen();
            frm.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modelo.listaSalidas(dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VentanaTmodificarS frm = new VentanaTmodificarS();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VentanaBorrarSalida frm = new VentanaBorrarSalida();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Modelo.busquedalistaSalida(int.Parse(textBox1.Text));
        }
    }
}
