using BankaProjekat.Data;
using BankaProjekat.IRepositories;
using BankaProjekat.Repositories;

namespace BankaProjekat.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IBankaRepository bankaRepository { get; }
        public IFilijalaRepository filijalaRepository { get; }
        public IKorisnikRepository korisnikRepository { get; }
        public IUslugaRepository uslugaRepository { get; }

        private BankaDbContext db;

        public UnitOfWork(BankaDbContext bankaDbContext)
        {
            db = bankaDbContext;

            bankaRepository = new BankaRepository(db);
            filijalaRepository = new FilijalaRepository(db);
            korisnikRepository = new KorisnikRepository(db);
            uslugaRepository = new UslugaRepository(db);
        }

        public void save()
        {
            db.SaveChanges();
        }
    }
}
