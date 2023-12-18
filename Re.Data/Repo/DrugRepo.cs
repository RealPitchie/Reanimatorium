using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Re.Core.Extensions;
using Re.Core.Models;

namespace Re.Data.Repo
{
    public class DrugRepo<T> : IRepo<T> where T : class
    {
        DataContext _context;
        public DrugRepo(DataContext context)
        {
            _context = context;
        }

        

        public async Task<T> SaveAsync(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }


         async Task<List<T>> IRepo<T>.GetAsync()
        {
            return await _context.Set<T>().IncludeAll().ToListAsync();
        }
    }
}
