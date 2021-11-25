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
    public partial class VentanaVentaMateriaPrima : Form
    {
        public VentanaVentaMateriaPrima(string idVenta)
        {
            InitializeComponent();
            DateTime theDate = DateTime.Now;
            txtfecha.Text = theDate.ToString("yyyy-MM-dd H:mm:ss");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Ventas vent = new Ventas();
                vent.idVentas = int.Parse(textidVenta.Text);
                vent.fechaVentas = DateTime.Parse(txtfecha.Text);
                vent.subtotalVentas = int.Parse(txtcant.Text);
                vent.ivaVentas = int.Parse(txtsubtotal.Text);
                vent.totalVentas = int.Parse(txtIVA.Text);
                vent.observacionesVentas = rtxtOb.Text;
                vent.idEmpleado = Session.idempleados;
                //Modelo.crearVenta(vent);
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
