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
    public partial class VentanaNuevaVenta : Form
    {
        string idVenta;
        public VentanaNuevaVenta()
        {
            InitializeComponent();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            VentanaVentaMateriaPrima ventaMateriaPrima = new VentanaVentaMateriaPrima(idVenta);
            ventaMateriaPrima.Show();
            dataGridView1.DataSource = Modelo.listaCompras();
        }
    }
}
