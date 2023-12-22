using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Re.Core.Models.Hemo;
using Re.Data.Repo;
using Re.Services.Interfaces.Hemo;

namespace Re.Services.Services.Hemo
{
    public class SZPProtocolService:ISZP
    {
        private readonly IRepo<SZPProtocol> _repo;

        public SZPProtocolService(IRepo<SZPProtocol> repo)
        {
            _repo = repo;
        }
        public async Task<List<SZPProtocol>> GetAllAsync()
        {
            return await _repo.GetAsync();
        }
        public async Task<SZPProtocol> SaveSZPProtocolAsync(SZPProtocol szp)
        {
            if (szp.Id == null)
            {
                szp.Id = Guid.NewGuid().ToString();
            }
            return await _repo.SaveAsync(szp);
        }
    }
}
