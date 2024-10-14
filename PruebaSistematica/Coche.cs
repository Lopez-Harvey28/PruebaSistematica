using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSistematica
{
    public class Coche
    {
       
        public string Marca {  get; set; }
        public string Modelo {  get; set; }
        public string Color {  get; set; }
        public double Speed {  get; set; }

        public Coche(string marca, string modelo, string color, double speed)
        {
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Speed = speed;
        }

        //metodo de mostrar info en la clase MostrarInfo
    }
}
