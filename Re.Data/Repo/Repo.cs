using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Re.Core.Models;

namespace Re.Data.Repo
{
    public class Repo<T> : IRepo<T> where T : class
    {
        DataContext _context;
        DbSet<T> _dbSet;
        public Repo(DataContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<T> SaveAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}