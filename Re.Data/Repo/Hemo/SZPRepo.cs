using Microsoft.EntityFrameworkCore;
using Re.Core.Extensions;
using Re.Core.Models.Hemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re.Data.Repo.Hemo
{
    public class SZPRepo:IRepo<SZPProtocol>
    {
        DataContext _context;
        public SZPRepo(DataContext context)
        {
            _context = context;
        }

        public async Task<SZPProtocol> SaveAsync(SZPProtocol szp)
        {
            await _context.SZPProtocols.AddAsync(szp);
            await _context.SaveChangesAsync();
            return szp;
        }

        public async Task<List<SZPProtocol>> GetAsync()
        {
            return await _context.Set<SZPProtocol>().IncludeAll().ToListAsync();
        }
        public async Task<List<SZPProtocol>> GetAsync(Type type)
        {
            return await _context.Set<SZPProtocol>().IncludeAll().ToListAsync();
        }

        public Task<SZPProtocol> GetAsync(String guid)
        {
            throw new NotImplementedException();
        }
    }
}
