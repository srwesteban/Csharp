using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton
    {

        // instancia interna de si misma
        private static Singleton instance = null; // no es accesible desde afuera 
        public string mensaje = "";
        protected Singleton()
        {
            mensaje = "hola mundo";

        }
        public static Singleton Instance // se accede a la clase con esta funcion 
        {
            get
            {
                if (instance == null) instance = new Singleton(); // una instancia unica en esta clase
                return instance;
            }
        }
    }
}
