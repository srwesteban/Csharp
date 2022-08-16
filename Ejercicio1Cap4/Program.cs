using System;

namespace Ejercicio1Cap4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digita el año");
            int año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digita el mes");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digita el mes");
            int dia = Convert.ToInt32(Console.ReadLine());        
            Console.WriteLine("Fecha Introducida");
            DateTime fecha = new DateTime(año,mes,dia);
            Console.WriteLine(fecha);
            Console.WriteLine("\nFecha de mañana");
            DateTime fecha2 = new DateTime(año, mes ,dia+1);
            Console.WriteLine(fecha2);

        }

        
    }
}
