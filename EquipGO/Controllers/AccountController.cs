using Microsoft.AspNetCore.Mvc;

namespace EquipGO.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult recuperarContraseña()
        {
            return View();
        }

        public ActionResult envioCorreo()
        {
            return View();
        }
    }
}
