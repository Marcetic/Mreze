using ProjekatBanka.Data;
using ProjekatBanka.IRepositories;
using ProjekatBanka.Models;

namespace ProjekatBanka.Repositories
{
    public class FilijalaRepository: Repository<Filijala>, IFilijalaRepository
    {
        private BankaDbContext db;
        public FilijalaRepository(BankaDbContext bankaDbContext) : base(bankaDbContext)
        {
            db = bankaDbContext;
        }

        public void Update(Filijala filijala )
        {
            db.Update(filijala);
        }
    }
}
