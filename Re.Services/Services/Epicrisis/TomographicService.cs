using Re.Core.Models.Epicrisis;
using Re.Data.Repo;
using Re.Services.Interfaces.Epicrisis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re.Services.Services.Epicrisis
{
    public class TomographicService : ITomographic
    {
        private readonly IRepo<TomographicExploration> _repo;

        public TomographicService(IRepo<TomographicExploration> repo)
        {
            _repo = repo;
        }

        public async Task<TomographicExploration> SaveTomographicAsync(TomographicExploration tomographic)
        {
            if (tomographic.Id == null)
            {
                tomographic.Id = Guid.NewGuid().ToString();
            }
            return await _repo.SaveAsync(tomographic);
        }
    }
}
