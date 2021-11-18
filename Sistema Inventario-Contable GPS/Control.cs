using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Inventario_Contable_GPS
{
    class Control
    {
        public string ctrlRegistro(Usuarios usuarionuevo)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if (string.IsNullOrEmpty(usuarionuevo.Correo) || string.IsNullOrEmpty(usuarionuevo.Password) || string.IsNullOrEmpty(usuarionuevo.ConPassword) || string.IsNullOrEmpty(usuarionuevo.Nombre) || string.IsNullOrEmpty(usuarionuevo.Turno) || string.IsNullOrEmpty(usuarionuevo.Telefono) || string.IsNullOrEmpty(usuarionuevo.Edad))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                if (usuarionuevo.Password == usuarionuevo.ConPassword)
                {
                    if (modelo.existeUsuario(usuarionuevo.Correo))
                    {
                        respuesta = "El usuario ya existe";
                    }
                    else
                    {
                        usuarionuevo.Password = generarSHA1(usuarionuevo.Password);
                        modelo.registro(usuarionuevo);
                    }
                }
                else
                {
                    respuesta = "Las contraseña no coinciden";
                }
            }
            return respuesta;

        }

        public string ctrlLogin(string usuariocorreo, string password)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            Usuarios datosUsuario = null;

            if (string.IsNullOrEmpty(usuariocorreo) || string.IsNullOrEmpty(password))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                datosUsuario = modelo.porUsuario(usuariocorreo);

                if (datosUsuario == null)
                {
                    respuesta = "El usuario no existe";
                }
                else
                {
                    if (datosUsuario.Password != generarSHA1(password))
                    {
                        respuesta = "El usuario y/o contraseña no coinciden";
                    }
                    else
                    {
                        Session.idempleados = datosUsuario.IdEmpleados;
                        Session.correo = usuariocorreo;
                        Session.nombre = datosUsuario.Correo;
                        Session.turno = datosUsuario.Turno;
                        Session.id_puesto = datosUsuario.Id_puesto;
                        Session.edad = datosUsuario.Edad;
                        Session.telefono = datosUsuario.Telefono;


                    }
                }
            }
            return respuesta;
        }
        private string generarSHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {

                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }

            return sb.ToString();
        }
    }
}
