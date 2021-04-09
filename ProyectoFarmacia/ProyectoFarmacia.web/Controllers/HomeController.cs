using ProyectoFarmacia.BL;
using System.Configuration;
using System.Web.Mvc;

namespace ProyectoFarmacia.web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
			var productosBl = new ProductosBL();
			var listadeProductos = productosBl.ObtenerProductosActivos();

			ViewBag.adminWebSiteURL = ConfigurationManager.AppSettings["adminWebSiteURL"];
			return View(listadeProductos);
		}
    }
}