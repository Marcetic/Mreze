using Banka.Data;
using Banka.Interface;
using Banka.Models;

namespace Banka.Repository
{
    public class BankaRepository : IBankaRepository
    {
        private readonly BankaDbContext _context;

        public BankaRepository(BankaDbContext context)
        {
            _context = context;
        }

        public bool Add(Banka banka)
        {
            _context.Add(banka);
            return Save();
        }

        public bool Delete(Club club)
        {
            _context.Remove(banka);
            return Save();
        }

        public async Task<IEnumerable<Banka>> GetAll()
        {
            return await _context.Banks.ToListAsync();
        }

        public Task<Banka> GetByIdAsync(int id)
        {
            return await _context.Banks.FirstOrDefaultAsync(i=> i.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0? true: false;
        }

        public bool Update(Banka banka)
        {
            _context.Update(banka);
            return Save();
        }
    }
}
