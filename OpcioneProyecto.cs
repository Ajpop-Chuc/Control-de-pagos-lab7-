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
            CenterToScreen();
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
            double cuota1 = 0;
            double cuota2 = 0;
            double cuota3 = 0;
            int tamaño = datosControl.listaControl.Count();

            datosControl.listaControl = datosControl.listaControl.OrderByDescending(x => x.CuetoMantenimiento).ToList();
            if (tamaño > 0)
            {
                cuota1 = datosControl.listaControl[0].CuetoMantenimiento;
                if(tamaño>1)
                {
                    cuota2 = datosControl.listaControl[1].CuetoMantenimiento;
                    if(tamaño>2)
                        cuota3 = datosControl.listaControl[2].CuetoMantenimiento;
                }
                
            }
            

            MessageBox.Show("cuotas mas altas: 1)" + cuota1 + " 2)" + cuota2+" 3)"+cuota3);

        }

        private void ordenarPorMedioDeCutoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datosControl.listaControl = datosControl.listaControl.OrderBy(x => x.CuetoMantenimiento).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = datosControl.listaControl;
            dataGridView1.Refresh();
        }

        private void cuotasDeMantenimientoMasBajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double cuota1 = 0;
            double cuota2 = 0;
            double cuota3 = 0;
            int tamaño = datosControl.listaControl.Count();

            datosControl.listaControl = datosControl.listaControl.OrderBy(x => x.CuetoMantenimiento).ToList();
            if (tamaño > 0)
            {
                cuota1 = datosControl.listaControl[0].CuetoMantenimiento;
                if (tamaño > 1)
                {
                    cuota2 = datosControl.listaControl[1].CuetoMantenimiento;
                    if (tamaño > 2)
                        cuota3 = datosControl.listaControl[2].CuetoMantenimiento;
                }

            }


            MessageBox.Show("cuotas mas altas: 1)" + cuota1 + " 2)" + cuota2 + " 3)" + cuota3);
        }

        private void cuotasMasAltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datosControl.listaControl = datosControl.listaControl.OrderByDescending(x => x.CuetoMantenimiento).ToList();
            MessageBox.Show("La cuota mas alta la paga: " + datosControl.listaControl[0].Nombre +
                " pagando: " + datosControl.listaControl[0].CuetoMantenimiento);
        }
    }
}
