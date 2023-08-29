using ProjekatBanka.IRepositories;

namespace ProjekatBanka.UnitOfWork
{
    public interface IUnitOfWork
    {
        IBankaRepository bankaRepository { get; }
        IFilijalaRepository filijalaRepository { get; }
        IKorisnikRepository korisnikRepository { get; }
        IUslugaRepository uslugaRepository { get; }
        void save();
    }
}
