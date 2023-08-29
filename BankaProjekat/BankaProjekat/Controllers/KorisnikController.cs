using BankaProjekat.Data;
using BankaProjekat.Models;
using BankaProjekat.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace BankaProjekat.Controllers
{
    public class KorisnikController : Controller
    {
        private readonly BankaDbContext bankaDbContext;
        private int id;

        public KorisnikController(BankaDbContext bankaDbContext)
        {
            this.bankaDbContext = bankaDbContext;
        }



        [HttpGet]
        public async Task<IActionResult> Index()
        {

            var korisnici = await bankaDbContext.Korisniks.ToListAsync();
            return View(korisnici);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
            public async Task<IActionResult> Add(AddKorisnik newKorisnik) 
        {
            var employee = new Korisnik()
            {
                Ime = newKorisnik.Ime,
                Prezime = newKorisnik.Prezime,
                MaticniBroj = newKorisnik.MaticniBroj,
                Email = newKorisnik.Email,
                Username = newKorisnik.Username,
                Password = newKorisnik.Password
            };
            await bankaDbContext.Korisniks.AddAsync(employee);
            await bankaDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var korisnik = bankaDbContext.Korisniks.FirstOrDefault(x => x.Id == id);

            if (korisnik != null)
            {
                var viewModel = new UpdateKorisnik()
                {
                    Id = korisnik.Id,
                    Ime = korisnik.Ime,
                    Prezime = korisnik.Prezime,
                    MaticniBroj = korisnik.MaticniBroj,
                    Email = korisnik.Email,
                    Username = korisnik.Username,
                    Password = korisnik.Password
                };
                return View(viewModel);
            }
            
            return RedirectToAction("Index");  
        }

        [HttpPost]
        public async Task<IActionResult> Update (UpdateKorisnik model)
        {
            var korisnik = await bankaDbContext.Korisniks.FindAsync(model.Id);

            if (korisnik != null)

            {
                korisnik.Ime = model.Ime;
                korisnik.Prezime = model.Prezime;
                korisnik.MaticniBroj= model.MaticniBroj;
                korisnik.Email = model.Email;
                korisnik.Username = model.Username;
                korisnik.Password = model.Password;

                await bankaDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
            
        }

        [HttpPost]
        public async Task<IActionResult> Delete(UpdateKorisnik model)
        {
            var korisnik = await bankaDbContext.Korisniks.FindAsync(model.Id);
             if(korisnik != null)
            {
                bankaDbContext.Korisniks.Remove(korisnik);
                await bankaDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

    }
}
