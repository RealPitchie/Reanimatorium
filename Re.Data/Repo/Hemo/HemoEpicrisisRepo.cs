using Re.Core.Models;
using Re.Core.Models.Hemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Re.Core.Extensions;

namespace Re.Data.Repo.Hemo
{
    public class HemoEpicrisisRepo:IRepo<HemoEpicrisis>
    {
        DataContext _context;
        public HemoEpicrisisRepo(DataContext context)
        {
            _context = context;
        }

        public async Task<HemoEpicrisis> SaveAsync(HemoEpicrisis ep)
        {
            await _context.HemoEpicrises.AddAsync(ep);
            await _context.SaveChangesAsync();

            return ep;
        }

        public async Task<List<HemoEpicrisis>> GetAsync()
        {
            return await _context.Set<HemoEpicrisis>().IncludeAll().ToListAsync();
        }
        public async Task<List<HemoEpicrisis>> GetAsync(Type type)
        {
            return await _context.Set<HemoEpicrisis>().IncludeAll().ToListAsync();
        }

        public Task<HemoEpicrisis> GetAsync(String guid)
        {
            throw new NotImplementedException();
        }
    }
}
