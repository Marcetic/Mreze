using Microsoft.AspNetCore.Mvc;

namespace BankaProjekat.Controllers
{
    public class BankaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
