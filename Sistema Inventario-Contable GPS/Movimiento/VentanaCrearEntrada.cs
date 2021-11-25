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
    public partial class VentanaCrearEntrada : Form
    {
        public VentanaCrearEntrada(int fact)
        {
            InitializeComponent();
            txtfo.Text = fact.ToString();
            DateTime theDate = DateTime.Now;
            txtfe.Text = theDate.ToString("yyyy-MM-dd H:mm:ss");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Entradas comp = new Entradas();
                comp.id = int.Parse(txtid.Text);
                comp.fecha = DateTime.Parse(txtfe.Text);
                comp.folio = int.Parse(txtfo.Text);
                comp.observaciones = richTextBox1.Text;
                comp.id_empleado = Session.idempleados;
                Modelo.crearEntrada(comp);
                MessageBox.Show("Se ha introducido con exíto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
