using System;

namespace Ejercicio1Cap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            int resultado = Doble(numero);
            Console.WriteLine(resultado);
            Multiplicar(resultado);
        }

        public static int Doble(int a)            
        {
            int doble = a*2;
            return doble;        
        }
        public static int Multiplicar(int a)
        {
            int multi = a * 25;
            Console.WriteLine(multi);
            return multi;            
        }

    }
    
}
