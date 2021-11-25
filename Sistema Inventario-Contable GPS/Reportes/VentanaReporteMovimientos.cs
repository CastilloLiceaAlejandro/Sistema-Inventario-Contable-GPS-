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
    public partial class VentanaReporteMovimientos : Form
    {
        public VentanaReporteMovimientos()
        {
            InitializeComponent();
            dataGridViewCompras.DataSource = Modelo.ReporteMCompras();
            dataGridViewVentas.DataSource = Modelo.ReporteMVentas();
            dataGridViewEntradas.DataSource = Modelo.ReporteMAlmacenE();
            dataGridViewSalidas.DataSource = Modelo.ReporteMAlmacenS();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewCompras.DataSource = Modelo.ReporteMCompras();
        }

        private void dataGridViewVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewVentas.DataSource = Modelo.ReporteMVentas();
        }

        private void dataGridViewEntradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewEntradas.DataSource = Modelo.ReporteMAlmacenE();
        }

        private void dataGridViewSalidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewSalidas.DataSource = Modelo.ReporteMAlmacenS();
        }
    }
}
