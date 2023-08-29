using BankaProjekat.Data;
using BankaProjekat.IRepositories;
using BankaProjekat.Models;

namespace BankaProjekat.Repositories
{
    public class FilijalaRepository : Repository<Filijala>, IFilijalaRepository
    {
        private BankaDbContext db;
        public FilijalaRepository(BankaDbContext bankaDbContext) : base(bankaDbContext)
        {
            db = bankaDbContext;
        }

        public void Update(Filijala filijala)
        {
            db.Update(filijala);
        }
    }
}
