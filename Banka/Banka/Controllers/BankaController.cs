using Banka.Data;
using Microsoft.AspNetCore.Mvc;

namespace Banka.Controllers
{
    public class BankaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}


