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
    public partial class VentanaReporteVentas : Form
    {
        public VentanaReporteVentas()
        {
            InitializeComponent();
            dataGridView.DataSource = Modelo.ReporteVentas();
        }
    }
}
