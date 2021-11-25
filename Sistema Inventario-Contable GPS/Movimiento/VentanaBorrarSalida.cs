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
    public partial class VentanaBorrarSalida : Form
    {
        public VentanaBorrarSalida()
        {
            InitializeComponent();
            Modelo.listaSalidas(dataGridView1);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo.EliminarSalida(txtid.Text);
                Modelo.listaSalidas(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
