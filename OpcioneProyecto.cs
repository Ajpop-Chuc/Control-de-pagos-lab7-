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
    public partial class OpcioneProyecto : Form
    {
        public OpcioneProyecto()
        {
            InitializeComponent();
        }

        private void OpcioneProyecto_Load(object sender, EventArgs e)
        {
            datosControl.cargarLista();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = datosControl.listaControl;
            dataGridView1.Refresh();
        }

        private void asdasdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ordenarPorGriedviewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cuotasDeMantenimientoMasAltasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
