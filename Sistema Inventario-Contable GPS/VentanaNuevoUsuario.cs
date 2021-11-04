﻿using System;
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
            Usuarios usuario = new Usuarios();

            if (comboBox1.SelectedItem == null)
            {

            }
            else { 
                usuario.Usuario = txtUsuario.Text;
                usuario.Password = txtPassword.Text;
                if (comboBox1.SelectedIndex == 0)
                {
                    usuario.Id_tipo = 1;
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    usuario.Id_tipo = 2;
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    usuario.Id_tipo = 3;
                }
            }

            try
            {
                Control control = new Control();
                string respuesta = control.ctrlRegistro(usuario);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
