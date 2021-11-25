using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void ListaUsuarios(DataGridView grid)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            MySqlCommand cm = new MySqlCommand("select * from empleados", conexion);

            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();

            da.Fill(dt);

            grid.DataSource = dt;
            conexion.Close();

        }

        public void EliminarUsuario(TextBox selecciongrid)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            try {
                string sql = "DELETE FROM empleados where idEMPLEADOS = @idEMPLEADOS";
                MySqlCommand cm = new MySqlCommand(sql, conexion);
                cm.Parameters.AddWithValue("idEMPLEADOS", selecciongrid.Text);
                cm.ExecuteNonQuery();

                MessageBox.Show("Se elimino usuario correctamente");
                selecciongrid.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar usuario ", ex.Message);
            }
            conexion.Close();
        }

        public void ModificarUsuario(int id, string nombre, string edad, string telefono, string correo, string contrasena, string turno, int puesto)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            Usuarios usuarios = new Usuarios();
            try
            {
                string sql = "UPDATE empleados SET nombreEMPLEADOS=@nombreEMPLEADOS,edadEMPLEADOS=@edadEMPLEADOS, telefonoEMPLEADOS=@telefonoEMPLEADOS, correoEMPLEADOS=@correoEMPLEADOS, contrasenaEMPLEADOS=@contrasenaEMPLEADOS, turnoEMPLEADOS=@turnoEMPLEADOS, idPUESTO=@idPUESTO WHERE idEMPLEADOS =@idEMPLEADOS";
                MySqlCommand cm = new MySqlCommand(sql, conexion);
                cm.Parameters.AddWithValue("@idEMPLEADOS", id);
                cm.Parameters.AddWithValue("@nombreEMPLEADOS", nombre);
                cm.Parameters.AddWithValue("@edadEMPLEADOS", edad);
                cm.Parameters.AddWithValue("@telefonoEMPLEADOS", telefono);
                cm.Parameters.AddWithValue("@correoEMPLEADOS", correo);
                cm.Parameters.AddWithValue("@contrasenaEMPLEADOS", contrasena);
                cm.Parameters.AddWithValue("@turnoEMPLEADOS", turno);
                cm.Parameters.AddWithValue("@idPUESTO", puesto);
                cm.ExecuteNonQuery();

                MessageBox.Show("Se modifico el usuario correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar el usuario ", ex.Message);
            }
            conexion.Close();


        }

        public void BuscarUsuarios(DataGridView grid, string nombre)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();


            MySqlCommand cm = new MySqlCommand(string.Format("select * from empleados where nombreEMPLEADOS like '{0}%'",nombre ),conexion);


            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();

            da.Fill(dt);

            grid.DataSource = dt;
            conexion.Close();

            conexion.Close();

        }

        public static List<Compras> listaCompras ()
        {
            List<Compras> lista = new List<Compras> ();
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT idCOMPRAS, costoCOMPRAS, productosCOMPRAS, cantidadCOMPRAS, fechaCOMPRAS, subtotalCOMPRAS, ivaCOMPRAS, totalCOMPRAS, facturaCOMPRAS, observacionesCOMPRAS, idEMPLEADOS FROM compras";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            reader = comando.ExecuteReader();
            Compras comp = new Compras();
            while(reader.Read())
            {
                comp.id = reader.GetInt32(0);
                comp.costo= reader.GetInt32(1);
                comp.productos= reader.GetString(2);
                comp.cantidad = reader.GetInt32(3);
                comp.fecha = reader.GetDateTime(4);
                comp.subtotal = reader.GetInt32(5);
                comp.IVA = reader.GetInt32(6);
                comp.total = reader.GetInt32(7);
                comp.factura = reader.GetString(8);
                comp.observaciones = reader.GetString(9);
                comp.id_empleado = reader.GetInt32(10);
                lista.Add(comp);
            }
            conexion.Close();
            return lista;
        }

        public static List<Ventas> listaVentas()
        {
            List<Ventas> lista = new List<Ventas>();
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT idVentas, fechaVentas, totalVENTAS, totalVentas, idEmpleado from ventas";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            reader = comando.ExecuteReader();
            Ventas vent = new Ventas();
            while (reader.Read())
            {
                vent.idVentas = reader.GetInt32(0);
                vent.fechaVentas = reader.GetDateTime(1);
                vent.totalVentas = reader.GetInt32(2);
                vent.idEmpleado = reader.GetInt32(3);
                lista.Add(vent);
            }
            conexion.Close();
            return lista;
        }

        public static int crearCompra(Compras comp)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "INSERT INTO compras (costoCOMPRAS, productosCOMPRAS, cantidadCOMPRAS, fechaCOMPRAS, subtotalCOMPRAS, ivaCOMPRAS, totalCOMPRAS, facturaCOMPRAS, observacionesCOMPRAS, idEMPLEADOS) VALUES(@costoCOMPRAS, @productosCOMPRAS, @cantidadCOMPRAS, @fechaCOMPRAS, @subtotalCOMPRAS, @ivaCOMPRAS, @totalCOMPRAS, @facturaCOMPRAS, @observacionesCOMPRAS, @idEMPLEADOS)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@fechaCOMPRAS", comp.fecha);
            comando.Parameters.AddWithValue("@subtotalCOMPRAS", comp.subtotal);
            comando.Parameters.AddWithValue("@ivaCOMPRAS", comp.IVA);
            comando.Parameters.AddWithValue("@totalCOMPRAS", comp.total);
            comando.Parameters.AddWithValue("@facturaCOMPRAS", comp.factura);
            comando.Parameters.AddWithValue("@observacionesCOMPRAS", comp.observaciones);
            comando.Parameters.AddWithValue("@idEMPLEADOS", comp.id_empleado);
            comando.Parameters.AddWithValue("@costoCOMPRAS", comp.costo);
            comando.Parameters.AddWithValue("@productosCOMPRAS", comp.productos);
            comando.Parameters.AddWithValue("@cantidadCOMPRAS", comp.cantidad);
            int resultado = comando.ExecuteNonQuery();
            conexion.Close();
            return resultado;
        }

        public int crearVenta(Ventas vent)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "INSERT INTO ventas (idVentas, fechaVentas, subtotalVentas, IVAVentas, totalVentas, observacionesVentas, idEmpleado) VALUES(@idVentas, @fechaVentas, @subtotalVentas, @IVAVentas, @totalVentas, @observacionesVentas, @idEmpleados)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idVentas", vent.idVentas);
            comando.Parameters.AddWithValue("@fechaVentas", vent.fechaVentas);
            comando.Parameters.AddWithValue("@subtotalVentas", vent.subtotalVentas);
            comando.Parameters.AddWithValue("@IVAVentas", vent.ivaVentas);
            comando.Parameters.AddWithValue("@totalVentas", vent.totalVentas);
            comando.Parameters.AddWithValue("@observacionesVentas", vent.observacionesVentas);
            comando.Parameters.AddWithValue("@idEmpleados", vent.idEmpleado);

            int resultado = comando.ExecuteNonQuery();
            conexion.Close();
            return resultado;
        }
    

        public static List<ReporteCompras> ReporteCompras()
        {
            List<ReporteCompras> lista = new List<ReporteCompras>();
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT idCOMPRAS, fechaCOMPRAS, totalCOMPRAS, facturaCOMPRAS, idEmpleados from compras";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            reader = comando.ExecuteReader();
            ReporteCompras comp = new ReporteCompras();
            while (reader.Read())
            {
                comp.idCOMPRAS = reader.GetInt32(0);
                comp.fechaCOMPRAS = reader.GetDateTime(1);
                comp.totalCOMPRAS = reader.GetInt32(2);
                comp.facturaCOMPRAS = reader.GetString(3);
                comp.idEmpleado = reader.GetInt32(4);
            }
            conexion.Close();
            return lista;
        }

        public static List<ReporteVentas> ReporteVentas()
        {
            List<ReporteVentas> lista = new List<ReporteVentas>();
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT idVENTAS, fechaVENTAS, totalVENTAS, idEmpleado from ventas";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            reader = comando.ExecuteReader();
            ReporteVentas vent = new ReporteVentas();
            while (reader.Read())
            {
                vent.idVENTAS = reader.GetInt32(0);
                vent.fechaVENTAS = reader.GetDateTime(1);
                vent.totalVENTAS = reader.GetInt32(2);
                vent.idEmpleado = reader.GetInt32(3);
            }
            conexion.Close();
            return lista;
        }

        public static List<ReporteAlmacenE> ReporteAlmacenE()
        {
            List<ReporteAlmacenE> lista = new List<ReporteAlmacenE>();
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT idEntrada, fechaEntrada, idEmpleado from entradas";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            reader = comando.ExecuteReader();
            ReporteAlmacenE E = new ReporteAlmacenE();
            while (reader.Read())
            {
                E.idEntrada = reader.GetInt32(0);
                E.fechaEntrada = reader.GetDateTime(1);
                E.idEmpleado = reader.GetInt32(2);
            }
            conexion.Close();
            return lista;
        }

        public static List<ReporteAlmacenS> ReporteAlmacenS()
        {
            List<ReporteAlmacenS> lista = new List<ReporteAlmacenS>();
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT idEntrada, fechaEntrada, idEmpleado from entradas";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            reader = comando.ExecuteReader();
            ReporteAlmacenS S = new ReporteAlmacenS();
            while (reader.Read())
            {
                S.idSalida = reader.GetInt32(0);
                S.fechaSalida = reader.GetDateTime(1);
                S.idEmpleado = reader.GetInt32(2);
            }
            conexion.Close();
            return lista;
        }

        public static List<ReporteSesiones> ReporteSesiones()
        {
            List<ReporteSesiones> lista = new List<ReporteSesiones>();
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT idEmpleadoSesion, HoraSesion from sesiones";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            reader = comando.ExecuteReader();
            ReporteSesiones rs = new ReporteSesiones();
            while (reader.Read())
            {
                rs.idEmpleadosesion = reader.GetInt32(0);
                rs.horaSesion = reader.GetDateTime(1);
            }
            conexion.Close();
            return lista;
        }        
        public static Compras porcompra(string fact)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT idCOMPRAS, costoCOMPRAS, productosCOMRPAS, cantidadCOMPRAS, fechaCOMPRAS, subtotalCOMPRAS, ivaCOMPRAS, totalCOMPRAS, facturaCOMPRAS, observacionesCOMPRAS, idEMPLEADOS FROM compras WHERE facturaCOMPRAS LIKE @facturaCOMPRAS";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@facturaCOMPRAS", fact);

            reader = comando.ExecuteReader();

            Compras comp = new Compras();

            while (reader.Read())
            {
                comp.id = reader.GetInt32(0);
                comp.costo = reader.GetInt32(1);
                comp.productos = reader.GetString(2);
                comp.cantidad = reader.GetInt32(3);
                comp.fecha = reader.GetDateTime(4);
                comp.subtotal = reader.GetInt32(5);
                comp.IVA = reader.GetInt32(6);
                comp.total = reader.GetInt32(7);
                comp.factura = reader.GetString(8);
                comp.observaciones = reader.GetString(9);
                comp.id_empleado = reader.GetInt32(10);
            }
            conexion.Close();
            return comp;
        }
        public static void Modcompra(Compras comp)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();
            string sql = "UPDATE compras SET costoCOMPRAS=@costoCOMPRAS, productosCOMPRAS=@productosCOMPRAS, cantidadCOMPRAS=@cantidadCOMPRAS, idCOMPRAS=@idCOMPRAS, fechaCOMPRAS=@fechaCOMPRAS, subtotalCOMPRAS=@subtotalCOMPRAS, ivaCOMPRAS=@ivaCOMPRAS, totalCOMPRAS=@totalCOMPRAS, facturaCOMPRAS=@facturaCOMPRAS, observacionesCOMPRAS=@observacionesCOMPRAS, idEMPLEADOS=@idEMPLEADOS WHERE facturaCOMPRAS =@facturaCOMPRAS";
            MySqlCommand cm = new MySqlCommand(sql, conexion);
            cm.Parameters.AddWithValue("@idCOMPRAS", comp.id);
            cm.Parameters.AddWithValue("@fechaCOMPRAS", comp.fecha);
            cm.Parameters.AddWithValue("@subtotalCOMPRAS", comp.subtotal);
            cm.Parameters.AddWithValue("@ivaCOMPRAS", comp.IVA);
            cm.Parameters.AddWithValue("@totalCOMPRAS", comp.total);
            cm.Parameters.AddWithValue("@facturaCOMPRAS", comp.factura);
            cm.Parameters.AddWithValue("@observacionesCOMPRAS", comp.observaciones);
            cm.Parameters.AddWithValue("@idEMPLEADOS", comp.id_empleado);
            cm.Parameters.AddWithValue("@costoCOMPRAS", comp.costo);
            cm.Parameters.AddWithValue("@productosCOMPRAS", comp.productos);
            cm.Parameters.AddWithValue("@cantidadCOMPRAS", comp.cantidad);
            cm.ExecuteNonQuery();

            conexion.Close();
        }
        public static void EliminarCompra(string fac)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            try
            {
                string sql = "DELETE FROM compras where idCOMPRAS = @idCOMPRAS";
                MySqlCommand cm = new MySqlCommand(sql, conexion);
                cm.Parameters.AddWithValue("idCOMPRAS", fac);
                cm.ExecuteNonQuery();

                MessageBox.Show("Se elimino la compra correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar la compra ", ex.Message);
            }
            conexion.Close();
        }

        public static List<ReporteCompras> ReporteMCompras()
        {
            List<ReporteCompras> lista = new List<ReporteCompras>();
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT idCOMPRAS, fechaCOMPRAS, totalCOMPRAS, facturaCOMPRAS, idEmpleados from compras";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            reader = comando.ExecuteReader();
            ReporteCompras comp = new ReporteCompras();
            while (reader.Read())
            {
                comp.idCOMPRAS = reader.GetInt32(0);
                comp.fechaCOMPRAS = reader.GetDateTime(1);
                comp.totalCOMPRAS = reader.GetInt32(2);
                comp.facturaCOMPRAS = reader.GetString(3);
                comp.idEmpleado = reader.GetInt32(4);
            }
            conexion.Close();
            return lista;
        }

        public static void Modventa(Ventas vent)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();
            string sql = "UPDATE ventas SET idVENTAS=@idVENTAS, fechaVENTAS=@fechaVENTAS, subtotalVENTAS=@subtotalVENTAS, ivaVENTAS=@ivaVENTAS, totalVENTAS=@totalVENTAS, observacionesCOMPRAS=@observacionesCOMPRAS, idEMPLEADO=@idEMPLEADO WHERE idVENTAS=@idVENTAS";
            MySqlCommand cm = new MySqlCommand(sql, conexion);
            cm.Parameters.AddWithValue("@idVENTAS", vent.idVentas);
            cm.Parameters.AddWithValue("@fechaVENTAS", vent.fechaVentas);
            cm.Parameters.AddWithValue("@subtotalVENTAS", vent.subtotalVentas);
            cm.Parameters.AddWithValue("@ivaVENTAS", vent.ivaVentas);
            cm.Parameters.AddWithValue("@totalVENTAS", vent.totalVentas);
            cm.Parameters.AddWithValue("@observacionesCOMPRAS", vent.observacionesVentas);
            cm.Parameters.AddWithValue("@idEMPLEADO", vent.idEmpleado);
            cm.ExecuteNonQuery();

            conexion.Close();
        }
       public static void Eliminarventa(string idventa)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            try
            {
                string sql = "DELETE FROM ventas where idVENTAS = @idVENTAS";
                MySqlCommand cm = new MySqlCommand(sql, conexion);
                cm.Parameters.AddWithValue("idVENTAS", idventa);
                cm.ExecuteNonQuery();

                MessageBox.Show("Se elimino la venta correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar la venta ", ex.Message);
            }
            conexion.Close();
        }

        public static List<ReporteVentas> ReporteMVentas()
        {
            List<ReporteVentas> lista = new List<ReporteVentas>();
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT idVENTAS, fechaVENTAS, totalVENTAS, idEmpleado from ventas";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            reader = comando.ExecuteReader();
            ReporteVentas vent = new ReporteVentas();
            while (reader.Read())
            {
                vent.idVENTAS = reader.GetInt32(0);
                vent.fechaVENTAS = reader.GetDateTime(1);
                vent.totalVENTAS = reader.GetInt32(2);
                vent.idEmpleado = reader.GetInt32(3);
            }
            conexion.Close();
            return lista;
        }

        public static List<ReporteAlmacenE> ReporteMAlmacenE()
        {
            List<ReporteAlmacenE> lista = new List<ReporteAlmacenE>();
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT idEntrada, fechaEntrada, idEmpleado from entradas";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            reader = comando.ExecuteReader();
            ReporteAlmacenE E = new ReporteAlmacenE();
            while (reader.Read())
            {
                E.idEntrada = reader.GetInt32(0);
                E.fechaEntrada = reader.GetDateTime(1);
                E.idEmpleado = reader.GetInt32(2);
            }
            conexion.Close();
            return lista;
        }

        public static List<ReporteAlmacenS> ReporteMAlmacenS()
        {
            List<ReporteAlmacenS> lista = new List<ReporteAlmacenS>();
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT idEntrada, fechaEntrada, idEmpleado from entradas";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            reader = comando.ExecuteReader();
            ReporteAlmacenS S = new ReporteAlmacenS();
            while (reader.Read())
            {
                S.idSalida = reader.GetInt32(0);
                S.fechaSalida = reader.GetDateTime(1);
                S.idEmpleado = reader.GetInt32(2);
            }
            conexion.Close();
            return lista;
        }
    }
}
