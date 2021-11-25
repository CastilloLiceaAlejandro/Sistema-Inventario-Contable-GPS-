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
            string puerto = "3306";
            string usuario = "root";

            //contraseñas solo desmarcar la suya
            //string password = "huesos99";
            string password = "Hikari300";
            //string password = "123456";

            //bases de datos solo desmarcar la suya
            //string bd = "gddds"; 
            string bd = "sistemacontable";


            string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario + "; password=" + password + "; database=" + bd;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            return conexion;

        }
    }
}
