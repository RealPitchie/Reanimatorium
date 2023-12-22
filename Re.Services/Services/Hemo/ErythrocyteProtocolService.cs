using Re.Core.Models.Hemo;
using Re.Data.Repo;
using Re.Services.Interfaces.Hemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re.Services.Services.Hemo
{
    public class ErythrocyteProtocolService:IErythrocyte
    {
        private readonly IRepo<ErythrocyteProtocol> _repo;

        public ErythrocyteProtocolService(IRepo<ErythrocyteProtocol> repo)
        {
            _repo = repo;
        }
        public async Task<List<ErythrocyteProtocol>> GetAllAsync()
        {
            return await _repo.GetAsync();
        }
        public async Task<ErythrocyteProtocol> SaveErythrocyteProtocolAsync(ErythrocyteProtocol er)
        {
            if (er.Id == null)
            {
                er.Id = Guid.NewGuid().ToString();
            }
            return await _repo.SaveAsync(er);
        }
    }
}
