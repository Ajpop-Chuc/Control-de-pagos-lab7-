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
    public partial class Propiedades : Form
    {
        public Propiedades()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datosPropiedades propiedad = new datosPropiedades();
            propiedad.NoCasa = textBoxnoCasa.Text;
            propiedad.DpiDueño = textBoxDpi.Text;
            propiedad.CuotaMantenimietno = Convert.ToDouble(textBoxCuota.Text);
            datosPropiedades.listaPropiedades.Add(propiedad);
            datosPropiedades.guardarenTxt();
        }
    }
}
