using Microsoft.AspNetCore.Mvc;

namespace login_and_register.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("/Identity/Account/Login");
        }
    }
}
