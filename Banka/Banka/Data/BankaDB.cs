using Banka.Models;
using Microsoft.EntityFrameworkCore;

namespace Banka.Data
{
    public class BankaDbContext : DbContext
  
    {
        public BankaDbContext(DbContextOptions<BankaDbContext> options) : base(options)
        {

        }

        public DbSet<Filijala> Filijalas { get; set; }

        public DbSet<Usluga>Uslugas { get; set; }

        public DbSet<Korisnik> Korisniks { get; set; }

        



    }




    }

