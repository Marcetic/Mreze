using ProjekatBanka.Data;
using ProjekatBanka.IRepositories;
using ProjekatBanka.Models;

namespace ProjekatBanka.Repositories
{
    public class UslugaRepository: Repository<Usluga>, IUslugaRepository
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
