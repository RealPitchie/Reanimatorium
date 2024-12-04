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

        public async Task<List<StandardProtocol>> GetProtocolsAsync(Type protocolType)
        {
            return await _repo.GetAsync(protocolType);
        }

        public async Task<List<StandardProtocol>> GetProtocolsAsync()
        {
            return await _repo.GetAsync();
        }
        public async Task<StandardProtocol> GetProtocolByIdAsync(string id)
        {
            return await _repo.GetAsync(id);
        }
    }

}