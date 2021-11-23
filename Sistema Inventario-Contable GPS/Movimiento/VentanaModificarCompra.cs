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
    public partial class VentanaModificarCompra : Form
    {
        public VentanaModificarCompra()
        {
            InitializeComponent();
            dataGridView1.DataSource = Modelo.listaCompras();
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            try
            {
                VentanaModificarCuentaD frm = new VentanaModificarCuentaD(txtfac.Text);
                frm.ShowDialog();
                dataGridView1.DataSource = Modelo.listaCompras();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
