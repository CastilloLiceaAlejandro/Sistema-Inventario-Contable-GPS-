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
    public partial class VentanaMovimientosVentas : Form
    {
        public VentanaMovimientosVentas()
        {
            InitializeComponent();
            dataGridView.DataSource = Modelo.listaVentas();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentanaNuevaVenta frm = new VentanaNuevaVenta();
            frm.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = Modelo.listaVentas();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            VentanaModificarVenta frm = new VentanaModificarVenta();
            frm.Visible = true;
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            VentanaBorrarVenta frm = new VentanaBorrarVenta();
            frm.Visible = true;
        }
    }
}
