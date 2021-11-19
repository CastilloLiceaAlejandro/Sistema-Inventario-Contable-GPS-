using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Inventario_Contable_GPS
{
    internal class Compras
    {
        public int id { get; set; }
        public string fecha { get; set; }
        public string productos { get; set; }
        public int subtotal { get; set; }
        public int IVA { get; set; }
        public int total { get; set; }
        public string factura { get; set; }
        public string observaciones { get; set; }
        public int id_empleados { get; set; }
        /*public Compras (int idC, DateTime fechaC, string productosC, int subtotalC, int ivaC, int totalC, char facturaC, string observacionesC, int idE)
        {
            this.idCOMPRAS = idC;
            this.fechaCOMPRAS = fechaC;
            this.productosCOMPRAS = productosC;
            this.subtotalCOMPRAS = subtotalC;
            this.ivaCOMPRAS = ivaC; ;
            this.totalCOMPRAS = totalC;
            this.facturaCOMRPAS = facturaC;
            this.observacionesCOMPRAS = observacionesC;
            this.idEMPLEADOS = idE;
        }*/
    }
}
