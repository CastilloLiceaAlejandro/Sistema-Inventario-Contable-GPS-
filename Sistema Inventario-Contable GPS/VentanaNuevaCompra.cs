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
    public partial class VentanaNuevaCompra : Form
    {
        public VentanaNuevaCompra()
        {
            InitializeComponent();
            dataGridView1.DataSource = Modelo.listaCompras();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaCompraMateriaPrima compraMateria = new VentanaCompraMateriaPrima();
            compraMateria.Show();
            dataGridView1.DataSource = Modelo.listaCompras();
        }
    }
}
