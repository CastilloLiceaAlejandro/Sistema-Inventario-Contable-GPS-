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
    public partial class VentanaMovimientosSalidasAlmacen : Form
    {
        public VentanaMovimientosSalidasAlmacen()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentanaNuevaSalidasAlmacen frm = new VentanaNuevaSalidasAlmacen();
            frm.Visible = true;
        }
    }
}