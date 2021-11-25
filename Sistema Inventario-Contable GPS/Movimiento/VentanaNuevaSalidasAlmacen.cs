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
    public partial class VentanaNuevaSalidasAlmacen : Form
    {
        public VentanaNuevaSalidasAlmacen()
        {
            InitializeComponent();
            Modelo.listaSalidas(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaCrearSalida frm = new VentanaCrearSalida(int.Parse(textBox1.Text));
            frm.ShowDialog();
        }
    }
}
