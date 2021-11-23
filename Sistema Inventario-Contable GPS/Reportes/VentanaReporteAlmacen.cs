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
    public partial class VentanaReporteAlmacen : Form
    {
        public VentanaReporteAlmacen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            dataGridViewEntradas.DataSource = Modelo.listaReporteAlmacen();
            dataGridViewSalidas.DataSource = Modelo.listaReporteAlmacen();
        }
    }
}
