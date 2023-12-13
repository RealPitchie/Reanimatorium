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
    }
}
