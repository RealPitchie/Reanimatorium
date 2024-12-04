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
    public class ErythrocyteRepo:IRepo<ErythrocyteProtocol>
    {
        DataContext _context;
        public ErythrocyteRepo(DataContext context)
        {
            _context = context;
        }

        public async Task<ErythrocyteProtocol> SaveAsync(ErythrocyteProtocol er)
        {
            await _context.ErythrocyteProtocols.AddAsync(er);
            await _context.SaveChangesAsync();
            return er;
        }

        public async Task<List<ErythrocyteProtocol>> GetAsync()
        {
            return await _context.Set<ErythrocyteProtocol>().IncludeAll().ToListAsync();

        }
        public async Task<List<ErythrocyteProtocol>> GetAsync(Type type)
        {
            return await _context.Set<ErythrocyteProtocol>().IncludeAll().ToListAsync();

        }

        public Task<ErythrocyteProtocol> GetAsync(String guid)
        {
            throw new NotImplementedException();
        }
    }
}
