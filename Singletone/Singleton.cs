﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton
    {

        // instancia interna de si misma
        private static Singleton instance = null;
        public string mensaje = "";
        protected Singleton()
        {
            mensaje = "hola mundo";

        }
        public static Singleton Instance
        {
            get
            {
                if (instance == null) instance = new Singleton();
                return instance;
            }
        }
    }
}
