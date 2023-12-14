using Re.Core.Models.Hemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re.Data.Repo.Hemo
{
    public class ThrombocyteRepo:IRepo<ThrombocyteProtocol>
    {
        DataContext _context;
        public ThrombocyteRepo(DataContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<ThrombocyteProtocol>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ThrombocyteProtocol> SaveAsync(ThrombocyteProtocol thr)
        {
            await _context.ThrombocyteProtocols.AddAsync(thr);
            await _context.SaveChangesAsync();
            return thr;
        }
    }
}
