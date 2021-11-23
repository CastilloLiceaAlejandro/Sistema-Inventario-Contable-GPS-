using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Inventario_Contable_GPS
{
    class Conexion
    {
        public static MySqlConnection getConexion()
        {
            string servidor = "localhost";
            /*string puerto = "3306";
            string usuario = "root";
            string password = "huesos99";
            string bd = "gddds";*/
           
             string puerto = "3306";
            string usuario = "root";
            string password = "123456";
            string bd = "gddds";

            string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario + "; password=" + password + "; database=" + bd;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            return conexion;

        }
    }
}
