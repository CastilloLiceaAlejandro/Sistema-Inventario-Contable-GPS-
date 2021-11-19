using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Inventario_Contable_GPS
{
    internal class Compras
    {
        public int idCOMPRAS { get; set; }
        public string fechaCOMPRAS { get; set; }
        public string productosCOMPRAS { get; set; }
        public int subtotalCOMPRAS { get; set; }
        public int ivaCOMPRAS { get; set; }
        public int totalCOMPRAS { get; set; }
        public string facturaCOMRPAS { get; set; }
        public string observacionesCOMPRAS { get; set; }
        public int idEMPLEADOS { get; set; }
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
