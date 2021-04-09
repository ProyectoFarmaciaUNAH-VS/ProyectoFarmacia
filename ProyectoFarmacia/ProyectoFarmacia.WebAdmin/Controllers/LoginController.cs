using ProyectoFarmacia.BL;
using System.Web.Mvc;
using System.Web.Security;

namespace ProyectoFarmacia.WebAdmin.Controllers
{
    public class LoginController : Controller
    {

        SeguridadBL _seguridadBL;

        public LoginController()
        {
            _seguridadBL = new SeguridadBL();
        }


        //LOGIN
        public ActionResult Index()
        {
            FormsAuthentication.SignOut();
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection data)
        {
            //CAPTURA DATOS DE LOGIN DE USUARIO
            var nombreUsuario = data["username"];
            var contrasena = data["password"];

            var usuarioValido = _seguridadBL
                    .Autorizar(nombreUsuario, contrasena);

            if (usuarioValido)
            {
                FormsAuthentication.SetAuthCookie(nombreUsuario, true);
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Usuario o contraseña invalido");

            return View();
        }
    }
}
