using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Singleton.Instance.mensaje);

            Singleton.Instance.mensaje = "hola marte"; // unico objeto

            Console.WriteLine(Singleton.Instance.mensaje);

            //  Singleton hola = new Singleton(); // no es accesible debido a su nivel de proteccion

            Console.WriteLine();
        }
    }
}
