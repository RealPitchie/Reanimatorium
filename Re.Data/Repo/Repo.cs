using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Re.Core.Models;

namespace Re.Data.Repo
{
    public class Repo : IRepo<StandardProtocol>
    {
        DataContext _context;
        public Repo(DataContext context)
        {
            _context = context;
        }
        public async Task<StandardProtocol> SaveAsync(StandardProtocol protocol)
        {
            await _context.Protocols.AddAsync(protocol);
            await _context.SaveChangesAsync();

            return protocol;
        }
    }
}