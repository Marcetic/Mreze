using Microsoft.EntityFrameworkCore;
using ProjekatBanka.Models;
using System.Collections.Generic;

namespace ProjekatBanka.Data
{
    public class BankaDbContext : DbContext

    {
        public BankaDbContext()
        {
        }

        public BankaDbContext(DbContextOptions<BankaDbContext> options) : base(options)
        {
        }

        public DbSet<Filijala> Filijalas { get; set; }

        public DbSet<Usluga> Uslugas { get; set; }

        public DbSet<Korisnik> Korisniks { get; set; }


    }

}