using System;

namespace Ejercicio3Cap4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Funcion Suma o Resta\n");
            Console.WriteLine("Ingresa 2 numeros");
            int num = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Elige S para suma y R para restar");
            string funcion = Console.ReadLine(); 

            if (funcion == "S"|| funcion == "s")
            {
                int S = suma(num, num2);
                Console.WriteLine("La Suma de: "+num+" + "+num2+" es: "+S);
            }
            if (funcion == "R"|| funcion == "r")
            {
                int R = resta(num,num2);
                Console.WriteLine("La Resta de: "+num+" - "+num2+" es: "+R);
            } 
        }
        static int suma(int a, int b) => a + b;
        static int resta(int a, int b) => a - b;
    }

}
