using ProjekatBanka.Data;
using ProjekatBanka.IRepositories;
using Microsoft.EntityFrameworkCore;
using ProjekatBanka.Models;

namespace ProjekatBanka.Repositories
{
    public class BankaRepository: Repository<Banka>, IBankaRepository
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
