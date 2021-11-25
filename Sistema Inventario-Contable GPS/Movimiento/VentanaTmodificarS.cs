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
    public partial class VentanaTmodificarS : Form
    {
        public VentanaTmodificarS()
        {
            InitializeComponent();
            Modelo.listaSalidas(dataGridView1);
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            try
            {
                VentanaModificarSalida frm = new VentanaModificarSalida(int.Parse(txtfac.Text));
                frm.ShowDialog();
                Modelo.listaSalidas(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
