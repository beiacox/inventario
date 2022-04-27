using capa_entidad;
using capa_negocios;
using System.Web.Mvc;

namespace GUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ArticulosN artuculosCTX = new ArticulosN();
        private readonly TransaccionesN transCTX = new TransaccionesN();


        public ActionResult Index()
        {


            return View();
        }
        public ActionResult About()
        {
           

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        //articulos
        public ActionResult Ver_Articulos()
        {
            var model = artuculosCTX.GetArticulos();
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
            artuculosCTX.SetArticulo(art);
            return RedirectToAction("Ver_Articulos");
        }
        [HttpGet]
        public ActionResult Eliminar_articulo()
        {
            
            
            //var model = artuculosCTX.SearchArticulo(a);
            return View();
        }
        public ActionResult Eliminar_articulo(articulos art)
        {
            
           artuculosCTX.DeleteArticulo(art);
            return RedirectToAction("Ver_Articulos");
        }       


        //reporte
        public ActionResult Reports()
        {
            var model = transCTX.GetTransacciones();
            

            return View(model);
        }
    }
}