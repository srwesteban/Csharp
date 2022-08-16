using System;

namespace Ejercicio2Cap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 4 numeros");

            int[] num = new int[4];

            for(int i = 0; i < 4; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());                
            }

            int P = producto(num[0],num[1],num[2],num[3]);

            int S = suma(num[0], num[1], num[2], num[3]);

            double M = media(S);

            Console.WriteLine("El Producto es: " + P);
            Console.WriteLine("La suma es: "+ S);
            Console.WriteLine("La media es: " + M);

        }
        static int producto(int a,int b, int c ,int d )
        {
            int prod = a*b*c*d;            
            return prod;
        }
        static int suma(int a, int b, int c, int d)
        {
            int sum = a+b+c+d;
            return sum;
        }
        static double media(double a)
        {
            double med = a/4;
            return med; 
        }
    }
}
