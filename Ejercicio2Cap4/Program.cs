using System;

namespace Ejercicio2Cap4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce dos numeros para saber si son divisores uno del otro\n");
            Console.Write("1 numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("2 numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            divisor(num,num2);
        
        }
        public static int divisor(int a, int b)
        {
            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("\nLos numeros son divisores");
            }
            else
            {
                Console.WriteLine("\nNo son divisores");
            }
            return default;
        }
    }
}
