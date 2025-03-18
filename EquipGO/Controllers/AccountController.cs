using Microsoft.AspNetCore.Mvc;

namespace EquipGO.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
    }
}
