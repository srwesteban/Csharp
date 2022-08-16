using System;

namespace Ejercicio1Cap3
{
    class Program
    {
        static void Main(string[] args)
        {
            Articulo articulo = new Articulo();

            Console.WriteLine("Compra de articulo\n");
            Console.WriteLine("Nombre del articulo: "+ articulo.Nombre);
            Console.WriteLine("Precio unitario: " + articulo.Precio);
            Console.WriteLine("\nCuantas unidades comprara?");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            double fact = factura(articulo.Precio,cantidad);
            Console.WriteLine("\nfactura:");
            Console.WriteLine("Precio sin descuento: $"+ fact);
            double des = Descuento(fact);
            Console.WriteLine("Descuento: " + des);
            Console.WriteLine("Precio con descuento:"+ (fact - des));           
        }
        public static double factura(int a, int b)
        {

            int comp = a*b;
            double iva = comp * 0.12;
            double total = comp + iva;
            return total;
        }
        public static double Descuento(double a)
        {
            double des = 0;
            if (a > 50000)
            {
                des = a * 0.05;
                a = a - des;
            }
            return des;
        }
    }
    class Articulo
    {
        public String Nombre = "Tapabocas";
        public Int32 Precio = 5000;
    }
}
