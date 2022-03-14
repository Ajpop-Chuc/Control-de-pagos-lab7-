using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_pagos__lab7_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Propietarios form = new Propietarios();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Propiedades form = new Propiedades();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpcioneProyecto form = new OpcioneProyecto();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            datosPropiedades.cargarLista();
            datosPropietarios.cargarLista();
        }
    }
}
