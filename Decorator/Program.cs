using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Cafe
    {
        public double costo()
        {
            return 1;
        }

        public string ingredientes()
        {
            return "cafe";
        }
    }
    public class conleche
    {
        public conleche(Cafe c)
        {
            this.cafe;
        }
    }
}
