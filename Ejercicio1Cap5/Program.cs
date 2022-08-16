using System;

namespace Ejercicio1Cap5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Numeros Decimales a Romanos\n");
            Console.WriteLine("Ingrese un numero (no mayor de 3999)");
            int num = Convert.ToInt32(Console.ReadLine());
            int millar = Math.Abs(num / 1000) % 10;
            int centena = Math.Abs(num / 100) % 10;
            int decena = Math.Abs(num / 10) % 10;
            int unidades = Math.Abs(num / 1) % 10;            
            if (millar > 3)
            {
                Console.WriteLine("El numero no puede exeder a 3999");
                return;
            }
            Console.WriteLine("Conversion:");

            M(millar);
            C(centena);
            D(decena);
            U(unidades);             
        }
        public static void U(int a)
        {
            switch (a)
            {
                case 1:
                    Console.Write("I");
                    break;
                case 2:
                    Console.Write("II");
                    break;
                case 3:
                    Console.Write("III");
                    break;
                case 4:
                    Console.Write("IV");
                    break;
                case 5:
                    Console.Write("V");
                    break;
                case 6:
                    Console.Write("VI");
                    break;
                case 7:
                    Console.Write("VII");
                    break;
                case 8:
                    Console.Write("VIII");
                    break;
                case 9:
                    Console.Write("IX");
                    break;
            }

        }
        public static void D(int a)
        {
            switch (a)
            {
                case 1:
                    Console.Write("X");
                    break;
                case 2:
                    Console.Write("XX");
                    break;
                case 3:
                    Console.Write("XXX");
                    break;
                case 4:
                    Console.Write("XL");
                    break;
                case 5:
                    Console.Write("L");
                    break;
                case 6:
                    Console.Write("LX");
                    break;
                case 7:
                    Console.Write("LXX");
                    break;
                case 8:
                    Console.Write("LXXX");
                    break;
                case 9:
                    Console.Write("XC");
                    break;
            }

        }
        public static void C(int a)
        {
            switch (a)
            {
                case 1:
                    Console.Write("C");
                    break;
                case 2:
                    Console.Write("CC");
                    break;
                case 3:
                    Console.Write("CCC");
                    break;
                case 4:
                    Console.Write("CD");
                    break;
                case 5:
                    Console.Write("D");
                    break;
                case 6:
                    Console.Write("DC");
                    break;
                case 7:
                    Console.Write("DCC");
                    break;
                case 8:
                    Console.Write("DCCC");
                    break;
                case 9:
                    Console.Write("CM");
                    break;
            }


        }
        public static void M(int a)
        {
            switch (a)
            {
                case 1:
                    Console.Write("M");
                    break;
                case 2:
                    Console.Write("MM");
                    break;
                case 3:
                    Console.Write("MMM");
                    break;
            }

        } 
    }
}
