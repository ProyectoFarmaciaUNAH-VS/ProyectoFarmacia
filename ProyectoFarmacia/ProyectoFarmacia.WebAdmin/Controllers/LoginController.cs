using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
//using System.Web.Http;
using System.Web.Mvc;

namespace ProyectoFarmacia.WebAdmin.Controllers
{
    public class LoginController : Controller
    {
        //LOGIN
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection data)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
