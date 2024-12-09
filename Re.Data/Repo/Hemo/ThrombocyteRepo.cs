using Re.Core.Models.Hemo;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Re.Core.Extensions;

namespace Re.Data.Repo.Hemo
{
    public class ThrombocyteRepo:IRepo<ThrombocyteProtocol>
    {
        DataContext _context;
        public ThrombocyteRepo(DataContext context)
        {
            _context = context;
        }

        public async Task<ThrombocyteProtocol> SaveAsync(ThrombocyteProtocol thr)
        {
            await _context.ThrombocyteProtocols.AddAsync(thr);
            await _context.SaveChangesAsync();
            return thr;
        }

        public async Task<List<ThrombocyteProtocol>> GetAsync()
        {
            return await _context.Set<ThrombocyteProtocol>().IncludeAll().ToListAsync();

        }
        public async Task<List<ThrombocyteProtocol>> GetAsync(Type type)
        {
            return await _context.Set<ThrombocyteProtocol>().IncludeAll().ToListAsync();

        }

        public Task<ThrombocyteProtocol> GetAsync(String guid)
        {
            throw new NotImplementedException();
        }

    }
}
