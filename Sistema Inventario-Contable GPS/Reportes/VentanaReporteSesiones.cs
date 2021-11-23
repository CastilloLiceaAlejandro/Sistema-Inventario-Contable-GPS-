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
    public partial class VentanaReporteSesiones : Form
    {
        public VentanaReporteSesiones()
        {
            InitializeComponent();
            dataGridViewSesiones.DataSource = Modelo.listaReporteSesiones();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewSesiones.DataSource = Modelo.listaReporteSesiones();
        }
    }
}
