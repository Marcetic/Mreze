using Microsoft.EntityFrameworkCore.Storage;
using ProjekatBanka.Data;
using ProjekatBanka.IRepositories;
using ProjekatBanka.Models;

namespace ProjekatBanka.Repositories
{
    public class KorisnikRepository: Repository<Korisnik>, IKorisnikRepository
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
