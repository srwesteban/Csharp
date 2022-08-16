using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoMvc.Models
{
    public class Contacto
    {
        public int IdContacto { get; set; }
        public string Nombres { get; set; }
        public string Apeliidos { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
    }
}