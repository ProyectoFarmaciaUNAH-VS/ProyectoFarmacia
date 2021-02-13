using ProyectoFarmacia.BL;
using System.Web.Mvc;

namespace ProyectoFarmacia.Controllers
{
    public class ProductoController : Controller
    {


        // GET: Producto
        public ActionResult Index()
        {

            var productosBl = new ProductosBL();
            var listadeProductos = productosBl.ObtenerProductos();


            return View(listadeProductos);
        }
    }
}