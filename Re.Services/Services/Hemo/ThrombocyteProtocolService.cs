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
    public class ThrombocyteProtocolService:IThrombocyte
    {
        private readonly IRepo<ThrombocyteProtocol> _repo;

        public ThrombocyteProtocolService(IRepo<ThrombocyteProtocol> repo)
        {
            _repo = repo;
        }
        public async Task<ThrombocyteProtocol> SaveThrombocyteProtocolAsync(ThrombocyteProtocol thr)
        {
            if (thr.Id == null)
            {
                thr.Id = Guid.NewGuid().ToString();
            }
            return await _repo.SaveAsync(thr);
        }
    }
}
