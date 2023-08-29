using BankaProjekat.Data;
using BankaProjekat.IRepositories;
using BankaProjekat.Models;

namespace BankaProjekat.Repositories
{
    public class UslugaRepository : Repository<Usluga>, IUslugaRepository
    {
        private BankaDbContext db;
        public UslugaRepository(BankaDbContext bankaDbContext) : base(bankaDbContext)
        {
            db = bankaDbContext;
        }

        public void Update(Usluga usluga)
        {
            db.Update(usluga);
        }
    }
}
