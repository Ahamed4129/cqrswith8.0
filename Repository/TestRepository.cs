using cqrswith8._0.Context;
using cqrswith8._0.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cqrswith8._0.Repository
{
    public class TestRepository : ITestRepositoryace
    {
        private readonly ApplicationDbContext _context;

        public TestRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> CountAsync()
        {
            return await _context.Tests.CountAsync();
        }

        public async Task<Test> CreateAsync(Test entity)
        {
            _context.Tests.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _context.Tests.FindAsync(id);
            if (entity == null)
                return false;

            _context.Tests.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Test>> GetAllAsync(int pageNumber, int pageSize, string nameFilter = null)
        {
            var query = _context.Tests.AsQueryable();

            if (!string.IsNullOrEmpty(nameFilter))
            {
                query = query.Where(t => t.Name.Contains(nameFilter));
            }

            return await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<Test> GetByIdAsync(int id)
        {
            return await _context.Tests.FindAsync(id);
        }

        public async Task<Test> UpdateAsync(Test entity)
        {
            _context.Tests.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
