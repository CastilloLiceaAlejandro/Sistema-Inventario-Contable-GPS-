using MySql.Data.MySqlClient;
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
    public partial class VentanaCatalogoUsuarios : Form
    {
        Modelo modelo = new Modelo();
        public VentanaCatalogoUsuarios()
        {
            InitializeComponent();

            modelo.ListaUsuarios(dataGridView1);
        }
        

        private void button3_Click_1(object sender, EventArgs e)
        {
            RegistroDeUsuario frm = new RegistroDeUsuario();
            frm.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id2= Int32.Parse(id);
            VentanaModificarUsuario frm = new VentanaModificarUsuario(id, nombre, edad, telefono, correo, contrasena, turno, puesto);
            frm.Visible = true;
        }

        private void VentanaCatalogoUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            modelo.ListaUsuarios(dataGridView1);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            modelo.EliminarUsuario(textBox1);
            modelo.ListaUsuarios(dataGridView1);

        }

        string id;
        string nombre;
        string edad;
        string telefono;
        string correo;
        string contrasena;
        string turno;
        string puesto;



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            edad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            telefono = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            correo = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            contrasena = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            turno = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            puesto = dataGridView1.CurrentRow.Cells[7].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            modelo.BuscarUsuarios(dataGridView1, textBox1.Text);

        }
    }
}
