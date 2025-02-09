using Microsoft.EntityFrameworkCore;
using TaktikumTest.Data;
using TaktikumTest.Data.Interfaces;
using TaktikumTest.Models;

namespace TaktikumTest.Repository.Implementation
{
    public class ElementsRepository : IElementsRepository
    {
        private readonly AppDbContext _context;

        public ElementsRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public async Task ClearTable()
        {
            _context.Elements.RemoveRange(_context.Elements);
            await _context.SaveChangesAsync();
        }

        public async Task SaveElementsAsync(List<Element> elements)
        {
            await _context.Elements.AddRangeAsync(elements);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Element>> GetElementsAsync(int? code, string? value)
        {
            var query = _context.Elements.AsQueryable();

            if (code.HasValue)
            {
                query = query.Where(e => e.Code == code.Value);
            }
            if (!string.IsNullOrEmpty(value))
            {
                query = query.Where(e => e.Value.Contains(value));
            }

            return await query.ToListAsync();
        }
    }
}
