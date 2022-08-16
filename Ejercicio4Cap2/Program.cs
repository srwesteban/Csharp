using System;

namespace Ejercicio4Cap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("suma de enteros del 1 al 10");
            int sum = sumaEnteros();
            Console.WriteLine("resultado: "+ sum);
        }
        public static int sumaEnteros()
        {
            int suma = 0;
            int contador = 1;
            for (int i = 0; i < 10; i++)
            {
                suma = suma + contador;
                contador = contador + 1;
            }
            return suma;
        }
 
    }
}
