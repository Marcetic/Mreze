using Microsoft.AspNetCore.Mvc;

namespace ProjekatBanka.Controllers
{
    public class BankaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
