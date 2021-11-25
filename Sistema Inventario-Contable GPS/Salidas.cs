using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Inventario_Contable_GPS
{
    internal class Salidas
    {
        int idEmpleado, idSalida, folioSalida;
        DateTime fechaSalida;
        string observacionesSalida;
        public int id { get => idSalida; set => idSalida = value; }
        public DateTime fecha { get => fechaSalida; set => fechaSalida = value; }
        public int folio { get => folioSalida; set => folioSalida = value; }
        public string observaciones { get => observacionesSalida; set => observacionesSalida = value; }
        public int id_empleado { get => idEmpleado; set => idEmpleado = value; }
    }
}
