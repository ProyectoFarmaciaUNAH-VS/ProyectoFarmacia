using ProyectoFarmacia.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFarmacia.WebAdmin.Controllers
{
    public class OrdenesController : Controller
    {
        OrdenesBL _ordenesBL;


        public OrdenesController()
        {
            _ordenesBL = new OrdenesBL();

        }

        // GET: Ordenes
        public ActionResult Index()
        {
            var listadeOrdenes = _ordenesBL.ObtenerOrdenes();

            return View(listadeOrdenes);
        }
    }
}