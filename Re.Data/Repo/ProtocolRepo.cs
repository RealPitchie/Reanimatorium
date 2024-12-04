using Microsoft.EntityFrameworkCore;
using Re.Core.Extensions;
using Re.Core.Models;

namespace Re.Data.Repo
{
    public class ProtocolRepo<T> : IRepo<T> where T : class 
    {
        private readonly DataContext _context;

        public ProtocolRepo(DataContext context)
        {
            _context = context;
        }

        public async Task<T> SaveAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> GetAsync()
        {
            return await _context.Set<T>().IncludeAll().ToListAsync();
        }

        public async Task<List<T>> GetAsync(Type protocolType)
        {
            var allProtocols = await _context.Set<T>().IncludeAll().ToListAsync();
            return allProtocols.Where(p => p.GetType() == protocolType).ToList();
        }

    }
}
