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
    public partial class Propietarios : Form
    {
        public Propietarios()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            datosPropietarios propietario = new datosPropietarios();
            propietario.Dpi = textBoxDpi.Text;
            propietario.Nombre = textBoxNombre.Text;
            propietario.Apellido = textBoxApellido.Text;
            datosPropietarios.listaPropietarios.Add(propietario);
            datosPropietarios.guardarenTxt();
        }
    }
}
