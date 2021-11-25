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
    public partial class VentanaModificarSalida : Form
    {
        public VentanaModificarSalida(int fa)
        {
            InitializeComponent();
            int factura = fa;
            Salidas comp = new Salidas();
            comp = Modelo.porSalida(factura);
            txtfo.Text = comp.folio.ToString();
            txtid.Text = factura.ToString();
            txtfe.Text = comp.fecha.ToString();
            richTextBox1.Text = comp.observaciones.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Salidas comp = new Salidas();
                comp.fecha = DateTime.Parse(txtfe.Text);
                comp.folio = int.Parse(txtfo.Text);
                comp.observaciones = richTextBox1.Text;
                comp.id_empleado = Session.idempleados;
                Modelo.ModSalidas(comp);
                MessageBox.Show("Se ha modificado con exíto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
