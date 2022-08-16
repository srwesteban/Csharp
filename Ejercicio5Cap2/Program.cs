using System;

namespace Ejercicio5Cap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("potencias del 2 de 0 hasta 10");

            potencia();
        }
        public static double potencia()
        {
            double pot = 0;
            for(int i = 0;i < 10;i++)
            {
                pot = Math.Pow(i, 2);
                Console.WriteLine(i +"^"+2+"="+ pot);

            }
            return pot;
        }
    }
}
