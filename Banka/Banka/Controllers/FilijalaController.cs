using Banka.Data;
using Banka.Models;
using Microsoft.AspNetCore.Mvc;

namespace Banka.Controllers
{
        public class FilijalaController : Controller
        {
            private readonly BankaDbContext _context;

            public FilijalaController(BankaDbContext context)
            {
                _context = context;
            }
            public IActionResult Index()
            {
                List<Filijala> filijale = _context.Filijalas.ToList();
                return View(filijale);
            }
        }
 }


