using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Inventario_Contable_GPS
{
    class ReporteAlmacen
    {
        public int idEntrada { get; set; }
        public string fechaEntrada { get; set; }
        public int idEmpleado { get; set; }
    }
    class Reportes
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string edad { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string contraseña { get; set; }
        public string turno { get; set; }
        public int id_puesto { get; set; }

    }

}
