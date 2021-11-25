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
    public partial class VentaBorrarEntrada : Form
    {
        public VentaBorrarEntrada()
        {
            InitializeComponent();
            Modelo.listaEntradas(dataGridView1);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo.EliminarEntrada(txtid.Text);
                Modelo.listaEntradas(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
