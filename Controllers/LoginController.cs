using Microsoft.AspNetCore.Mvc;
using GarasiMobil.Services;

namespace GarasiMobil.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoginService _loginService;

        public LoginController(LoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            var user = _loginService.ValidateLogin(username, password);
            if (user != null)
            {
                HttpContext.Session.SetString("User", user.Username);
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Username atau Password salah!";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
