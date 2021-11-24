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
    public partial class VentanaComprasAgregModif : Form
    {
        public VentanaComprasAgregModif(string fac)
        {
            InitializeComponent();
            string factura = fac;
            Compras comp = new Compras();
            comp = Modelo.porcompra(factura);
            txtfactura.Text = factura;
            txtfecha.Text = comp.fecha.ToString();
            txtIVA.Text = comp.IVA.ToString();
            txtsubtotal.Text = comp.subtotal.ToString();
            txttt.Text = comp.total.ToString();
            rtxtOb.Text = comp.observaciones.ToString();            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Compras comp = new Compras();
                comp.fecha = DateTime.Parse(txtfecha.Text);
                comp.subtotal = int.Parse(txtsubtotal.Text);
                comp.IVA = int.Parse(txtIVA.Text);
                comp.total = int.Parse(txttt.Text);
                comp.factura = txtfactura.Text;
                comp.observaciones = rtxtOb.Text;
                comp.id_empleado = Session.idempleados;
                Modelo.Modcompra(comp);
                MessageBox.Show("Se ha modificado con exíto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
