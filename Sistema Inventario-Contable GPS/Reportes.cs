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
    class ReporteSesiones
    {
        public int idEmpleadosesion { get; set; }
        public DateTime horaSesion { get; set; }
    }



}
