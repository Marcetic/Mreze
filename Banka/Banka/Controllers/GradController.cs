using Banka.Data;
using Microsoft.AspNetCore.Mvc;

namespace Banka.Controllers
{
    public class GradController : Controller
    { 

        private readonly BankaDbContext _bankaDbContext;
        public GradController(BankaDbContext bankaDbContext)
        {
        this._bankaDbContext = bankaDbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Add")]
        public IActionResult SubmitTag(Models.ViewModels.AddFilijalaRequest addFilijalaRequest)
        {
            
            return View("Add");
        }
    }
}
