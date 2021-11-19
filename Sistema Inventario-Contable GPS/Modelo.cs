using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Inventario_Contable_GPS
{
    class Modelo
    {
        public int registro(Usuarios usuarionuevo)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "INSERT INTO empleados (nombreEMPLEADOS, edadEMPLEADOS, telefonoEMPLEADOS, correoEMPLEADOS, contrasenaEMPLEADOS, turnoEMPLEADOS, idPUESTO) VALUES(@nombreEMPLEADOS, @edadEMPLEADOS, @telefonoEMPLEADOS, @correoEMPLEADOS, @contrasenaEMPLEADOS, @turnoEMPLEADOS, @idPUESTO)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombreEMPLEADOS", usuarionuevo.Nombre);
            comando.Parameters.AddWithValue("@edadEMPLEADOS", usuarionuevo.Edad);
            comando.Parameters.AddWithValue("@telefonoEMPLEADOS", usuarionuevo.Telefono);
            comando.Parameters.AddWithValue("@correoEMPLEADOS", usuarionuevo.Correo);
            comando.Parameters.AddWithValue("@contrasenaEMPLEADOS", usuarionuevo.Password);
            comando.Parameters.AddWithValue("@turnoEMPLEADOS", usuarionuevo.Turno);
            comando.Parameters.AddWithValue("@idPUESTO", usuarionuevo.Id_puesto);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }

        public bool existeUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT idEMPLEADOS FROM empleados WHERE telefonoEMPLEADOS LIKE @telefonoEMPLEADOS";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@telefonoEMPLEADOS", usuario);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Usuarios porUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT idEMPLEADOS, nombreEMPLEADOS, edadEMPLEADOS, telefonoEMPLEADOS, contrasenaEMPLEADOS, turnoEMPLEADOS, idPUESTO FROM empleados WHERE correoEMPLEADOS LIKE @correoEMPLEADOS";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@correoEMPLEADOS", usuario);

            reader = comando.ExecuteReader();

            Usuarios usr = null;

            while (reader.Read())
            {
                usr = new Usuarios();
                usr.IdEmpleados = int.Parse(reader["idEMPLEADOS"].ToString());
                usr.Nombre = reader["nombreEMPLEADOS"].ToString();
                usr.Edad = reader["edadEMPLEADOS"].ToString();
                usr.Telefono = reader["telefonoEMPLEADOS"].ToString();
                usr.Password = reader["contrasenaEMPLEADOS"].ToString();
                usr.Turno = reader["turnoEMPLEADOS"].ToString();
                usr.Id_puesto = int.Parse(reader["idPUESTO"].ToString());
            }
            return usr;
        }
        public static List<Compras> listaCompras ()
        {
            List<Compras> lista = new List<Compras> ();
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT idCOMPRAS, fechaCOMPRAS, productosCOMPRAS, subtotalCOMPRAS, ivaCOMPRAS, totalCOMPRAS, facturaCOMPRAS, observacionesCOMPRAS, idEMPLEADOS FROM compras";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            reader = comando.ExecuteReader();
            Compras comp = new Compras();
            while(reader.Read())
            {
                comp.idCOMPRAS = reader.GetInt32(0);
                comp.fechaCOMPRAS = reader.GetString(1);
                comp.productosCOMPRAS = reader.GetString(2);
                comp.subtotalCOMPRAS = reader.GetInt32(3);
                comp.ivaCOMPRAS = reader.GetInt32(4);
                comp.totalCOMPRAS = reader.GetInt32(5);
                comp.facturaCOMRPAS = reader.GetString(6);
                comp.observacionesCOMPRAS = reader.GetString(7);
                comp.idEMPLEADOS = reader.GetInt32(8);
                lista.Add(comp);
            }
            return lista;
        }
    }
}
