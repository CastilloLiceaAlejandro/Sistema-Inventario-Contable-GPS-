using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Inventario_Contable_GPS
{
    class ReporteAlmacenE
    {
        public int idEntrada { get; set; }
        public DateTime fechaEntrada { get; set; }
        public int idEmpleado { get; set; }
    }
    class ReporteAlmacenS
    {
        public int idSalida { get; set; }
        public DateTime fechaSalida { get; set; }
        public int idEmpleado { get; set; }
    }

    class ReporteCompras
    {
        public int idCOMPRAS { get; set; }
        public DateTime fechaCOMPRAS { get; set; }
        public int totalCOMPRAS { get; set; }
        public string facturaCOMPRAS { get; set; }
        public int idEmpleado { get; set; }
    }

    class ReporteVentas
    {
        public int idVENTAS { get; set; }
        public DateTime fechaVENTAS { get; set; }
        public int totalVENTAS { get; set; }
        public int idEmpleado { get; set; }
    }
    class ReporteSesiones
    {
        public int idEmpleadosesion { get; set; }
        public DateTime horaSesion { get; set; }
    }



}
