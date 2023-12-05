using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Re.Core.Models;

namespace Re.Data.Repo
{
    public class Repo : IRepo
    {
        DataContext _context;
        public Repo(DataContext context)
        {
            _context = context;
        }
        public async Task<StandardProtocol> SaveProtocolAsync(StandardProtocol protocol)
        {
            await _context.Protocols.AddAsync(protocol);
            await _context.SaveChangesAsync();

            return protocol;
        }
    }
}