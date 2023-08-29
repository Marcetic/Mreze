
using Microsoft.AspNetCore.Mvc;

namespace Banka.Controllers
{
    public class GradoviController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
