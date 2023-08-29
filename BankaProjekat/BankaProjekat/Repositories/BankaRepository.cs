using BankaProjekat.Data;
using BankaProjekat.IRepositories;
using BankaProjekat.Models;

namespace BankaProjekat.Repositories
{
    public class BankaRepository : Repository<Banka>, IBankaRepository
    {
        private BankaDbContext db;
        public BankaRepository(BankaDbContext bankaDbContext) : base(bankaDbContext)
        {
            db = bankaDbContext;
        }

        public void Update(Banka banka)
        {
            db.Update(banka);
        }
    }
}
