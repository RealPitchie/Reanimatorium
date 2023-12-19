using Re.Core.Models;
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
    public class HemoEpicrisisService:IHemoEpicrisis
    {
        private readonly IRepo<HemoEpicrisis> _repo;
        public HemoEpicrisisService(IRepo<HemoEpicrisis> repo)
        {
            _repo = repo;
        }
        public async Task<List<HemoEpicrisis>> GetAllAsync()
        {
            return await _repo.GetAsync();
        }
        public async Task<HemoEpicrisis> SaveHemoEpicrisisAsync(HemoEpicrisis ep)
        {
            if (ep.Id == null)
            {
                ep.Id = Guid.NewGuid().ToString();
            }
            return await _repo.SaveAsync(ep);
        }
    }
}
