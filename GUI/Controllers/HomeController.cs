using capa_entidad;
using capa_negocios;
using System.Web.Mvc;

namespace GUI.Controllers
{
    public class HomeController : Controller
    {

        private readonly ArticulosN artuculosCTX = new ArticulosN();
        public ActionResult Index()
        {

            
            return View();
        }


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