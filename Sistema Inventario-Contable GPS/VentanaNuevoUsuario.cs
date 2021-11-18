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
    public partial class RegistroDeUsuario : Form
    {
        public RegistroDeUsuario()
        {
            InitializeComponent();
        }

        private void RegistroDeUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuarios usuarionuevo = new Usuarios();

            if (comboBox1.SelectedItem == null)
            {

            }
            if (comboBox2.SelectedItem == null)
            {

            }
            else {
                usuarionuevo.Nombre = txtNombre.Text;
                usuarionuevo.Edad = txtEdad.Text; 
                usuarionuevo.Telefono = txtTelefono.Text;
                usuarionuevo.Correo = txtCorreo.Text;
                usuarionuevo.Password = txtPassword.Text;
                usuarionuevo.ConPassword = txtConPassword.Text;

                if (comboBox1.SelectedIndex == 0)
                {
                    usuarionuevo.Id_puesto = 1;
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    usuarionuevo.Id_puesto = 2;
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    usuarionuevo.Id_puesto = 3;
                }

                if (comboBox2.SelectedIndex == 0)
                {
                    usuarionuevo.Turno = "Matutino";
                }
                if (comboBox2.SelectedIndex == 1)
                {
                    usuarionuevo.Turno = "Vespertino";
                }
                if (comboBox2.SelectedIndex == 2)
                {
                    usuarionuevo.Turno = "Ambos";
                }
                if (comboBox2.SelectedIndex == 3)
                {
                    usuarionuevo.Turno = "Ninguno";
                }
            }

            try
            {
                Control control = new Control();
                string respuesta = control.ctrlRegistro(usuarionuevo);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
