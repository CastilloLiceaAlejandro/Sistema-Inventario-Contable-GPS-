using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Inventario_Contable_GPS
{
    public partial class VentanaModificarUsuario : Form
    {
        public VentanaModificarUsuario(string id2, string nombre, string edad, string telefono, string correo, string contrasena, string turno, string puesto)
        {
            Usuarios usuarios = new Usuarios();
            
            usuarios.Telefono = telefono;
            InitializeComponent();

            txtid.Text = id2;
            txtNombre.Text = nombre;
            txtEdad.Text = edad;
            txtTelefono.Text = telefono;
            txtCorreo.Text = correo;
            txtPassword.Text = "";
            txtConPassword.Text = "";

            if (puesto == "1")
            {
                comboBox1.SelectedIndex = 0;
            }
            if (puesto == "2")
            {
                comboBox1.SelectedIndex = 1;
            }
            if (puesto == "3")
            {
                comboBox1.SelectedIndex = 2;
            }

            if (turno == "Matutino")
            {
                comboBox2.SelectedIndex = 0;

            }
            if (turno == "Vespertino")
            {
                comboBox2.SelectedIndex = 1;
            }
            if (turno == "Ambos")
            {
                comboBox2.SelectedIndex = 2;
            }
            if (turno == "Ninguno")
            {
                comboBox2.SelectedIndex = 3;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Modelo modelo = new Modelo();
            Control control = new Control();
            Usuarios usuarios = new Usuarios();

            int puesto = 0;
            string turno = "";

            string id = txtid.Text;
            int id2 = Convert.ToInt32(id);
            string nombre = txtNombre.Text;
            string edad = txtEdad.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;
            string contrasena = txtPassword.Text;
            string conpassword = txtConPassword.Text;

            if (comboBox1.SelectedItem == null)
            {

            }
            if (comboBox2.SelectedItem == null)
            {

            }
            else
            {                             
                if (comboBox1.SelectedIndex == 0)
                {
                    puesto = 1;
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    puesto = 2;
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    puesto = 3;
                }

                if (comboBox2.SelectedIndex == 0)
                {
                    turno = "Matutino";
                }
                if (comboBox2.SelectedIndex == 1)
                {
                    turno = "Vespertino";
                }
                if (comboBox2.SelectedIndex == 2)
                {
                    turno = "Ambos";
                }
                if (comboBox2.SelectedIndex == 3)
                {
                    turno = "Ninguno";
                }

                if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contrasena) || string.IsNullOrEmpty(conpassword) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(turno) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(edad))
                {
                    MessageBox.Show("Debe llenar todos los campos");
                }
            }

            if (txtPassword.Text == txtConPassword.Text)
            {
                if(usuarios.Telefono == txtTelefono.Text)
                {
                    contrasena = control.generarSHA1(contrasena);
                    modelo.ModificarUsuario(id2, nombre, edad, telefono, correo, contrasena, turno, puesto);
                }
                else
                {
                    if (modelo.existeUsuario(txtCorreo.Text))
                    {
                        MessageBox.Show("El usuario con este telefono ya existe");
                    }
                    else
                    {
                        contrasena = control.generarSHA1(contrasena);
                        modelo.ModificarUsuario(id2, nombre, edad, telefono, correo, contrasena, turno, puesto);

                    }
                }
                               
                    
            }
            else
            {
                MessageBox.Show("Las contraseña no coinciden");
            }

        }
    }
}

