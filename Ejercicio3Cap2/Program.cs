using System;

namespace Ejercicio3Cap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El cuadrado de 821\nes:");

            //674041
            int num = 821;
            double C = cuadrado(num);
            Console.WriteLine(C);
        }

        public static double cuadrado(int a)
        {
            double cuad = Math.Pow(a,2) ;
            return cuad;
        }
    }
}
