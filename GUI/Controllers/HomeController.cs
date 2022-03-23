using System;
using capa_entidad;
using capa_negocios;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GUI.Controllers
{
    public class HomeController : Controller
    {

        articulosN artuculosCTX = new articulosN();
        public ActionResult Index()
        {
            
            var model= artuculosCTX.GetArticulos();
            return View(model);
        }

        [HttpGet]
        public ActionResult Crear_articulo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Crear_articulo(articulos art)
        {
            artuculosCTX.setarticulo(art);
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}