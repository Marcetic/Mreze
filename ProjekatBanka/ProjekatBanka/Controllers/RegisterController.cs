using Microsoft.AspNetCore.Mvc;
using ProjekatBanka.Data;
using ProjekatBanka.Models.ViewModels;
using ProjekatBanka.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ProjekatBanka.Controllers
{
    public class RegisterController : Controller
    {
        private readonly BankaDbContext bankaDbContext;
        public RegisterController(BankaDbContext bankaDbContext)
        {
            this.bankaDbContext = bankaDbContext;
        }

        [HttpGet]
        public IActionResult RegisterUser(KorisnikRegister registerKor)
        {
            return View();
        }


        [HttpPost]
        [ActionName("RegisterUser")]
        public IActionResult Register(KorisnikRegister registerKor)
        {

            {
                var korisnik = new Korisnik
                {
                    Ime = registerKor.Ime,
                    Prezime = registerKor.Prezime,
                    MaticniBroj = registerKor.MaticniBroj,
                    Username = registerKor.Username,
                    Password = registerKor.Password,
                    Email = registerKor.Email,
                };

                bankaDbContext.Korisniks.Add(korisnik);
                bankaDbContext.SaveChanges();
                return RedirectToAction("Login");


            }

        }

        public IActionResult Login(Login logovan)
        {
            if(ModelState.IsValid)
            {
             var user = bankaDbContext.Korisniks.FirstOrDefault(u=> u.Username== logovan.Username);
                if(user!=null && user.Password==logovan.Password) 
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
    }
}
