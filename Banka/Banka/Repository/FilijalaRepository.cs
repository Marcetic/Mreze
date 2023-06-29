using Banka.Data;
using Banka.Interface;
using Banka.Models;
using Microsoft.EntityFrameworkCore;

namespace Banka.Repository
{
    public class FilijalaRepository : IFilijalaRepository
    {
        private readonly BankaDbContext _context;
        public bool Add(Filijala filijala)
        {
            _context.Add(filijala);
            return Save();
        }

        public bool Delete(Filijala filijala)
        {
            _context.Remove(filijala);
            return Save();
        }

        public Task<IEnumerable<Filijala>> GetAll()
        {
            return await _context.Filijale.ToListAsync();
        }

        public Task<Filijala> GetByIdAsync(int id)
        {
            return await _context.Filijale.FirstOrDefaultAsync(i => i.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Filijala filijala)
        {
            _context.Update(filijala);
            return Save();
        }
    }
}
