using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_pagos__lab7_
{
    internal class datosPropietarios
    {
        string dpi;
        string nombre;
        string apellido;

        public string Dpi { get => dpi; set => dpi = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public static List<datosPropietarios> listaPropietarios = new List<datosPropietarios>();
        public static void guardarenTxt()
        {
            FileStream abrir = new FileStream("Propietarios.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter escribir = new StreamWriter(abrir);
            foreach (var propietario in listaPropietarios)
            {
                escribir.WriteLine(propietario.dpi);
                escribir.WriteLine(propietario.nombre);
                escribir.WriteLine(propietario.apellido);
                datosPropietarios.listaPropietarios.Add(propietario);
            }
            escribir.Close();
            abrir.Close();
        }
        public static void cargarLista()
        {
            FileStream abrir = new FileStream("Propietarios.txt", FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(abrir);
            while (leer.Peek() > -1)
            {
                datosPropietarios propietario = new datosPropietarios();
                propietario.dpi = leer.ReadLine();
                propietario.nombre = leer.ReadLine();
                propietario.apellido = leer.ReadLine();
                datosPropietarios.listaPropietarios.Add(propietario);
            }
            abrir.Close();
            leer.Close();
        }
    }
}
