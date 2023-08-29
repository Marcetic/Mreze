using Microsoft.AspNetCore.Mvc;
using ProjekatBanka.Data;
using ProjekatBanka.Models;
using ProjekatBanka.Models.ViewModels;

namespace ProjekatBanka.Controllers
{
    public class GradController : Controller
    {
        private readonly BankaDbContext bankaDbContext;
        public GradController(BankaDbContext bankaDbContext)
        {
               this.bankaDbContext = bankaDbContext;
        }
        [HttpGet]
        public IActionResult Add(AddFilijalaRequest addFilijalaRequest)
        {
        
            return View();
        }
        [HttpPost]
        [ActionName("Add")]
        public IActionResult SubmitTag(AddFilijalaRequest addFilijala)
        {
            var filijala = new Filijala()
            {
                BankaId=addFilijala.BankaId,
                Adresa = addFilijala.Adresa,
                BrojPultova = addFilijala.BrojPultova,
            };
            bankaDbContext.Filijalas.Add(filijala);
            bankaDbContext.SaveChanges();
            return View("Add");
        }


    }
}
