using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Re.Core.Models;
using Re.Data.Repo;
using Re.Services.Interfaces;

namespace Re.Services.Services
{
    public class ProtocolService : IProtocols
    {
        private readonly IRepo<StandardProtocol> _repo;
        public ProtocolService(IRepo<StandardProtocol> repo)
        {
            _repo = repo;
        }
        public async Task<StandardProtocol> SaveProtocolAsync(StandardProtocol protocol)
        {
            return await _repo.SaveAsync(protocol);
        }
    }
}