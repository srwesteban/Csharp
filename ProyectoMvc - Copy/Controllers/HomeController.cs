using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoMvc.Models;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoMvc.Controllers
{
    public class HomeController : Controller
    {

        private static string conexion = ConfigurationManager.ConnectionStrings["cadena"].ToString();

        private static List<Contacto> olista = new List<Contacto>();

        //GET CONTACTO
        public ActionResult Index()
        {
            using (SqlConnection oconexion = new SqlConnection(conexion) )
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM CONTACTO", oconexion);
                cmd.CommandType = CommandType.Text;
                oconexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Contacto nuevoContacto = new Contacto();

                        nuevoContacto.IdContacto = Convert.ToInt32(dr["IdContacto"]);
                        nuevoContacto.Nombres = dr["Nombres"].ToString();
                        nuevoContacto.Apeliidos = dr["Apellidos"].ToString();
                        nuevoContacto.Telefono = dr["Telefono"].ToString();
                        nuevoContacto.Correo = dr["Correo"].ToString(); 

                        olista.Add(nuevoContacto);

                    }


                }

            }
                return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Aplicacion para tomar apuntes de clases";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Pagina de contacto.";

            return View();
        }
    }
}