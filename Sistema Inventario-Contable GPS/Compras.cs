using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Inventario_Contable_GPS
{
    internal class Compras
    {

        string facturaCOMRPAS, observacionesCOMPRAS;
        DateTime fechaCOMPRAS;
        int idCOMPRAS, subtotalCOMPRAS, ivaCOMPRAS, totalCOMPRAS, idEMPLEADOS;
        public DateTime fecha { get => fechaCOMPRAS; set => fechaCOMPRAS = value; }
        /*public string productos { get => productosCOMPRAS; set => productosCOMPRAS = value; }*/
        public string factura { get => facturaCOMRPAS; set => facturaCOMRPAS = value; }
        public string observaciones { get => observacionesCOMPRAS; set => observacionesCOMPRAS = value; }

        public int id { get => idCOMPRAS; set => idCOMPRAS = value; }
        public int subtotal { get => subtotalCOMPRAS; set => subtotalCOMPRAS = value; }
        public int IVA { get => ivaCOMPRAS; set => ivaCOMPRAS = value; }
        public int total { get => totalCOMPRAS; set => totalCOMPRAS = value; }
        public int id_empleado { get => idEMPLEADOS; set => idEMPLEADOS = value; }
        /*
        int idEMPLEADOS, idPUESTO;

        string nombreEMPLEADOS, correoEMPLEADOS, contrasenaEMPLEADOS, conPassword, turnoEMPLEADOS, telefonoEMPLEADOS, edadEMPLEADOS;

        public string Correo { get => correoEMPLEADOS; set => correoEMPLEADOS = value; }
        public string Password { get => contrasenaEMPLEADOS; set => contrasenaEMPLEADOS = value; }
        public string ConPassword { get => conPassword; set => conPassword = value; }
        public string Nombre { get => nombreEMPLEADOS; set => nombreEMPLEADOS = value; }
        public string Turno { get => turnoEMPLEADOS; set => turnoEMPLEADOS = value; }
        public int IdEmpleados { get => idEMPLEADOS; set => idEMPLEADOS = value; }
        public string Edad { get => edadEMPLEADOS; set => edadEMPLEADOS = value; }
        public string Telefono { get => telefonoEMPLEADOS; set => telefonoEMPLEADOS = value; }
        public int Id_puesto { get => idPUESTO; set => idPUESTO = value; }*/
    }
}
