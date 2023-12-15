using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var tabledata = await _context.Set<T>().Include("Doctor").ToListAsync();
            return tabledata;
        }

        public async Task<T> SaveAsync(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> GetAsync()
        {
            return await _context.Set<T>().IncludeAll().ToListAsync();
        }  
    }
}