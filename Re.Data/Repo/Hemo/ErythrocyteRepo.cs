using Re.Core.Models.Hemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re.Data.Repo.Hemo
{
    public class ErythrocyteRepo:IRepo<ErythrocyteProtocol>
    {
        DataContext _context;
        public ErythrocyteRepo(DataContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<ErythrocyteProtocol>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ErythrocyteProtocol> SaveAsync(ErythrocyteProtocol er)
        {
            await _context.ErythrocyteProtocols.AddAsync(er);
            await _context.SaveChangesAsync();
            return er;
        }

        Task<List<ErythrocyteProtocol>> IRepo<ErythrocyteProtocol>.GetAsync()
        {
            throw new NotImplementedException();
        }
    }
}
