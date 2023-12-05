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
        Repo _repo;
        public ProtocolService(Repo repo)
        {
            _repo = repo;
        }
        public async Task<StandardProtocol> SaveProtocolAsync(StandardProtocol protocol)
        {
            return await _repo.SaveProtocolAsync(protocol);
        }
    }
}