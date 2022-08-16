using System;

namespace Ejercicio4Cap4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero dentro del 10 al 100");
            int num = Convert.ToInt32(Console.ReadLine());
            string l = leer(num);
            Console.WriteLine(l);
        }
        public static string leer(int a)
        {
            string d;

            if (a >= 10 && a <= 100)
            {
               d = "el numero esta dentro del rango de 10 a 100";
            }
            else
            {
                d = "el numero \"NO\" esta dentro del rango de 10 a 100";
            }
            return d;
        }
    }
    
}
