using BankaProjekat.Data;
using BankaProjekat.Models.ViewModels;
using BankaProjekat.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace BankaProjekat.Controllers
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
                return RedirectToAction("LoginUser", "Register");


            }

        }

        [HttpGet]
        public IActionResult LoginUser()
        {
            return View();
        }

        [HttpPost]
        [ActionName("LoginUser")]
        public IActionResult Login(Login logovan)
        {
            if (ModelState.IsValid)
            {
                var user = bankaDbContext.Korisniks.FirstOrDefault(u => u.Username == logovan.Username);
                if (user != null && user.Password == logovan.Password)
                {
                    if (user.Username == "admin" && user.Password == logovan.Password)
                    {
                        HttpContext.Session.SetString("Role", "admin");

                    }

                    else
                    {
                        HttpContext.Session.SetString("Role", "user");

                    }

                }


            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Logout(bool logout)
        {
            if (logout)
            {
                HttpContext.Session.SetString("Role", "guest");
                HttpContext.Session.SetString("Username", "");
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Home");
        }

    }
}
