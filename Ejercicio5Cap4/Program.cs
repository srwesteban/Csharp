using System;

namespace Ejercicio5Cap4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa exponenciacion\n");
            Console.Write("Ingresa un numero:");
            int num = Convert.ToInt32(Console.ReadLine());
            validar(num);
            Console.Write("Ingresa el exponente:");
            int exponente = Convert.ToInt32(Console.ReadLine());
            expo(num, exponente);
        }
        public static int validar(int a)
        {
            while (a == 0)
            {
                Console.WriteLine("Ingrese un numero diferente de cero");
                a = Convert.ToInt32(Console.ReadLine());
            }
            return a;  
        }
        static void expo(int a, int b) => Console.WriteLine("\nEl resultado de "+a +"^"+ b +" es: "+Math.Pow(a, b));       

    }

    
}
