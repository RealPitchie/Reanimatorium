using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Re.Core.Extensions;
using Re.Core.Models;

namespace Re.Data.Repo
{
    public class Repo<T> : IRepo<T> where T : class
    {
        DataContext _context;
        public Repo(DataContext context)
        {
            _context = context;
        }

        public async Task<T> SaveAsync(T entity)
        {
            var entityType = entity.GetType();

            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task<List<T>> GetAsync()
        {

            return await _context.Set<T>().IncludeAll().ToListAsync();
        }
        public async Task<List<T>> GetAsync(Type protocolType = null)
        {

            var allProtocols = await _context.Set<T>().IncludeAll().ToListAsync();
            if (protocolType == null)
            {
                return allProtocols;
            }
            return allProtocols.Where(p => p.GetType() == protocolType).ToList();
        }
        public async Task<T> GetAsync(String id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

    }
}