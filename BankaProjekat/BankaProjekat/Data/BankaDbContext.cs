using BankaProjekat.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace BankaProjekat.Data
{
    public class BankaDbContext: DbContext
    {
        public BankaDbContext()
        {
        }

        public BankaDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Filijala> Filijalas { get; set; }

        public DbSet<Usluga> Uslugas { get; set; }

        public DbSet<Korisnik> Korisniks { get; set; }

    }
}
