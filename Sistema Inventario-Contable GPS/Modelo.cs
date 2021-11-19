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
            conexion.Close();
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
            conexion.Close();
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
            conexion.Close();
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
                comp.id = reader.GetInt32(0);
                comp.fecha = reader.GetString(1);
                comp.productos = reader.GetString(2);
                comp.subtotal = reader.GetInt32(3);
                comp.IVA = reader.GetInt32(4);
                comp.total = reader.GetInt32(5);
                comp.factura = reader.GetString(6);
                comp.observaciones = reader.GetString(7);
                comp.id_empleados = reader.GetInt32(8);
                lista.Add(comp);
            }
            conexion.Close();
            return lista;
        }
        
        public int crearCompra(Compras comp)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "INSERT INTO compras (fechaCOMPRAS, productosCOMPRAS, subtotalCOMPRAS, ivaCOMPRAS, totalCOMPRAS, facturaCOMPRAS, observacionesCOMPRAS, idEMPLEADOS) VALUES(@fechaCOMPRAS, @productosCOMPRAS, @subtotalCOMPRAS, @ivaCOMPRAS, @totalCOMPRAS, @facturaCOMPRAS, @observacionesCOMPRAS, @idEMPLEADOS)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@fechaCOMPRAS", comp.fecha);
            comando.Parameters.AddWithValue("@productosCOMPRAS", comp.productos);
            comando.Parameters.AddWithValue("@subtotalCOMPRAS", comp.subtotal);
            comando.Parameters.AddWithValue("@ivaCOMPRAS", comp.IVA);
            comando.Parameters.AddWithValue("@totalCOMPRAS", comp.total);
            comando.Parameters.AddWithValue("@facturaCOMPRAS", comp.factura);
            comando.Parameters.AddWithValue("@observacionesCOMPRAS", comp.observaciones);
            comando.Parameters.AddWithValue("@idEMPLEADOS", comp.id_empleados);

            int resultado = comando.ExecuteNonQuery();
            conexion.Close();
            return resultado;
        }
    }
}
