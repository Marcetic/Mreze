using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjekatBanka.Data;
using ProjekatBanka.Models;

namespace ProjekatBanka.Controllers
{
    public class KorisnikController : Controller
    {
        private readonly BankaDbContext dbContext;
        public KorisnikController(BankaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        

        
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var korisnici = await dbContext.Korisniks.ToListAsync();
            return View(korisnici);
        }
    }


}
