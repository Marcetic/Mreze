using Banka.Models;
using Microsoft.AspNetCore.Identity;
using System.Diagnostics;
using System.Net;

namespace Banka.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<BankaDbContext>();

                context.Database.EnsureCreated();

                if (!context.Filijalas.Any())
                {
                    context.Filijalas.AddRange(new List<Filijala>()
                    {
                        new Filijala()
                        {
                            Adresa = "Rumska 15, Ruma",                       
                            BrojPultova = 2,
                            Banka = new Models.Banka()
                            {
                                Naziv = "OTP Banka",
                                Kontakt = "+381 11 3143 171",
                                Pib = 43412
                            }
                         },
                       new Filijala()
                        {
                            Adresa = "Bulevar Oslobodjenja 120, Novi Sad",
                            BrojPultova = 4,
                            Banka = new Models.Banka()
                            {
                                Naziv = "Raiffeissen Banka",
                                Kontakt = "+381 11 3773 600",
                                Pib = 335145
                            }
                         },
                        new Filijala()
                        {
                            Adresa = "Stevana Sindjelica 18, Vrsac",
                            BrojPultova = 2,
                            Banka = new Models.Banka()
                            {
                                Naziv = "Komercijalna Banka",
                                Kontakt = "+381 11 20 72 200",
                                Pib = 43412
                            }
                         },
                       new Filijala()
                        {
                            Adresa = "Bulevar Mihajla Pupina 41, Nis",
                            BrojPultova = 5,
                            Banka = new Models.Banka()
                            {
                                Naziv = "OTP Banka",
                                Kontakt = "+381 64 3143 520",
                                Pib = 43412
                            }
                         }
                    });
                    context.SaveChanges();
                }
               
                if (!context.Uslugas.Any())
                {
                    context.Uslugas.AddRange(new List<Usluga>()
                    {
                        new Usluga()
                        {
                            Naziv = "Platni racun",
                            OpisUsluge = "Gasenje platnog racuna",
                            Provizija = "500",
                            Korisnik = new Korisnik()
                            {
                                Ime = "Mirko",
                                Prezime = "Antic",
                                MaticniBroj = "2015479054872"
                            }
                        },
                        new Usluga()
                        {
                            Naziv = "Platni racun",
                            OpisUsluge = "Otvaranje platnog racuna",
                            Provizija = "600",
                            Korisnik = new Korisnik()
                            {
                                Ime = "Milan",
                                Prezime = "Belic",
                                MaticniBroj = "1025305048952"
                            }
                        },
                        new Usluga()
                        {
                            Naziv = "Placanje na rate",
                            OpisUsluge = "Izmirenje obaveza prema prodavcu",
                            Provizija = "250",
                            Korisnik = new Korisnik()
                            {
                                Ime = "Ana",
                                Prezime = "Ilic",
                                MaticniBroj = "1254789785463"
                            }
                        },
                        new Usluga()
                        {
                            Naziv = "Izdavanje cekova",
                            OpisUsluge = "Izdavanje dinarskih cekova u vrednosti od 20000",
                            Provizija = "300",
                            Korisnik = new Korisnik()
                            {
                                Ime = "Aleksa",
                                Prezime = "Orlovic",
                                MaticniBroj = "15498563254788"
                            }
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
        /*
        
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
                string adminUserEmail = "teddysmithdeveloper@gmail.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new AppUser()
                    {
                        UserName = "teddysmithdev",
                        Email = adminUserEmail,
                        EmailConfirmed = true,
                        Address = new Address()
                        {
                            Street = "123 Main St",
                            City = "Charlotte",
                            State = "NC"
                        }
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

                string appUserEmail = "user@etickets.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new AppUser()
                    {
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true,
                        Address = new Address()
                        {
                            Street = "123 Main St",
                            City = "Charlotte",
                            State = "NC"
                        }
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
        */
    }
}
