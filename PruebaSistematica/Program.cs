using System;

namespace PruebaSistematica
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Coche coche = new Coche("Mazda","RX-7","Anaranjado",80.7);
            MostrarInfo.MostrarInfor(coche);

        }
    }
}