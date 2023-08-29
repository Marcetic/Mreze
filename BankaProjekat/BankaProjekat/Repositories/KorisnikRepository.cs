using BankaProjekat.Data;
using BankaProjekat.IRepositories;
using BankaProjekat.Models;

namespace BankaProjekat.Repositories
{
    public class KorisnikRepository : Repository<Korisnik>, IKorisnikRepository
    {
        private BankaDbContext db;
        public KorisnikRepository(BankaDbContext bankaDbContext) : base(bankaDbContext)
        {
            db = bankaDbContext;
        }

        public void Update(Korisnik korisnik)
        {
            db.Update(korisnik);
        }

    }
}
