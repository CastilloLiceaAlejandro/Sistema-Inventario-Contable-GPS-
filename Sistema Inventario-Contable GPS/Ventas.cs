using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Inventario_Contable_GPS
{
    class Ventas
    {
        string observacionesCOMPRAS;
        DateTime fechaVENTAS;
        int idVENTAS, subtotalVENTAS, ivaVENTAS, totalVENTAS, idEMPLEADO;

        public int idVentas { get => idVENTAS; set => idVENTAS = value; }
        public DateTime fechaVentas { get => fechaVENTAS; set => fechaVENTAS = value; }
        public int subtotalVentas { get => subtotalVENTAS; set => subtotalVENTAS = value; }
        public int ivaVentas { get => ivaVENTAS; set => ivaVENTAS = value; }
        public int totalVentas { get => totalVENTAS; set => totalVENTAS = value; }
        public string observacionesVentas { get => observacionesCOMPRAS; set => observacionesCOMPRAS = value; }
        public int idEmpleado { get => idEMPLEADO; set => idEMPLEADO = value; }
    }
}
