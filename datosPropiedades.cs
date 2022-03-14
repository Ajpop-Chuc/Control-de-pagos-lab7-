using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Control_de_pagos__lab7_
{
    internal class datosPropiedades
    {
        string noCasa;
        string dpiDueño;
        double cuotaMantenimietno;

        public string NoCasa { get => noCasa; set => noCasa = value; }
        public string DpiDueño { get => dpiDueño; set => dpiDueño = value; }
        public double CuotaMantenimietno { get => cuotaMantenimietno; set => cuotaMantenimietno = value; }

        public static List<datosPropiedades> listaPropiedades = new List<datosPropiedades>();

        public static void guardarenTxt()
        {
            FileStream abrir = new FileStream("Propiedades.txt", FileMode.OpenOrCreate,FileAccess.Write);
            StreamWriter escribir = new StreamWriter(abrir);
            foreach (var propiedad in listaPropiedades)
            {
                escribir.WriteLine(propiedad.noCasa);
                escribir.WriteLine(propiedad.dpiDueño);
                escribir.WriteLine(propiedad.cuotaMantenimietno);
            }
            escribir.Close();
            abrir.Close();
        }
        public static void cargarLista()
        {
            FileStream abrir = new FileStream("Propiedades.txt", FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(abrir);
            while (leer.Peek() > -1)
            {
                datosPropiedades propiedad = new datosPropiedades();
                propiedad.noCasa = leer.ReadLine();
                propiedad.dpiDueño = leer.ReadLine();
                propiedad.cuotaMantenimietno= Convert.ToDouble(leer.ReadLine());
                datosPropiedades.listaPropiedades.Add(propiedad);
            }
            abrir.Close();
            leer.Close();
        }
    }
}
