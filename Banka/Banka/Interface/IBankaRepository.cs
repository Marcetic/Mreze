namespace Banka.Interface
{
    public interface IBankaRepository
    {
        Task<IEnumerable<Banka>> GetAll();

        Task <Banka> GetByIdAsync(int id);

        bool Add(Banka banka);

        bool Update(Banka banka);

        bool Delete(Club club);

        bool Save();
        
    }
}
