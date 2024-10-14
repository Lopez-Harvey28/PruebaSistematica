using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PruebaSistematica
{
    public static class MostrarInfo
    {
        public static void MostrarInfor(Coche coche)
        {
            Console.WriteLine("*====*====* Información del Coche *====*====*");
            Console.WriteLine($"\nMarca: {coche.Marca}\nModelo: {coche.Modelo}\nColor: {coche.Color}\nVelocidad: {coche.Speed}km/h");
        }
    }
}
