using Banka.Models;

namespace Banka.Interface
{
    public interface IFilijalaRepository
    {
        Task<IEnumerable<Filijala>> GetAll();

        Task<Filijala> GetByIdAsync(int id);

        bool Add(Filijala filijala);

        bool Update(Filijala filijala);

        bool Delete(Filijala filijala);

        bool Save();
    }
}
