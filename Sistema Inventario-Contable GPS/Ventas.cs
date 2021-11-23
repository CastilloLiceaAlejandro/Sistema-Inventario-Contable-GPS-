using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Inventario_Contable_GPS
{
    class Ventas
    {
        public int idVentas { get; set; }
        public DateTime fechaVentas { get; set; }
        public int subtotalVentas { get; set; }
        public int IVAVentas { get; set; }
        public int totalVentas { get; set; }
        public string observacionesVentas { get; set; }
        public int idEmpleado { get; set; }
    }
}
