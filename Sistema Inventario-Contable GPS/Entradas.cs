using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Inventario_Contable_GPS
{
    internal class Entradas
    {
        string observacionesEntrada;
        DateTime fechaEntrada;
        int idEmpleado, idEntrada, folioEntrada;

        public int id { get => idEntrada; set => idEntrada = value; }
        public DateTime fecha { get => fechaEntrada; set => fechaEntrada = value; }
        public int folio { get => folioEntrada; set => folioEntrada = value; }
        public string observaciones { get => observacionesEntrada; set => observacionesEntrada = value; }
        public int id_empleado { get => idEmpleado; set => idEmpleado = value; }
    }
}
