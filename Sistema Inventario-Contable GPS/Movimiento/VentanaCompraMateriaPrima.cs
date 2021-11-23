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
    public partial class VentanaCompraMateriaPrima : Form
    {
        public VentanaCompraMateriaPrima()
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
            Compras comp = new Compras();
            comp.fecha = DateTime.Parse(txtfecha.Text);
            comp.subtotal = int.Parse(txtsubtotal.Text);
            comp.IVA = int.Parse(txtIVA.Text);
            comp.total = int.Parse(txttt.Text);
            comp.factura = txtfactura.Text;
            comp.observaciones = rtxtOb.Text;
            comp.id_empleado = Session.idempleados;
            Modelo.crearCompra(comp);
        }
    }
}
