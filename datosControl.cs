using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_pagos__lab7_
{
    internal class datosControl
    {
        string nombre;
        string apellido;
        string noCasa;
        double cuetoMantenimiento;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string NoCasa { get => noCasa; set => noCasa = value; }
        public double CuetoMantenimiento { get => cuetoMantenimiento; set => cuetoMantenimiento = value; }

        public static List<datosControl> listaControl = new List<datosControl>();
        public static void cargarLista()
        {
            foreach(var propiedad in datosPropiedades.listaPropiedades)
            {
                datosControl control = new datosControl();
                datosPropietarios propietario = datosPropietarios.listaPropietarios.Find(x => x.Dpi == propiedad.DpiDueño);
                control.Nombre = propietario.Nombre;
                control.Apellido = propietario.Apellido;
                control.NoCasa = propiedad.NoCasa;
                control.CuetoMantenimiento = propiedad.CuotaMantenimietno;
                datosControl.listaControl.Add(control);
            }
        }
    }
}
