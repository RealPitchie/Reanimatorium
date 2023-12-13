using Re.Core.Models.Epicrisis;
using Re.Data.Repo;
using Re.Services.Interfaces.Epicrisis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Re.Services.Services.Epicrisis
{
    public class AbdominalCavityService : IAbdominal
    {
        private readonly IRepo<AbdominalCavityRoentgen> _repo;

        public AbdominalCavityService(IRepo<AbdominalCavityRoentgen> repo)
        {
            _repo = repo;
        }
        public async Task<AbdominalCavityRoentgen> SaveAbdominalCavityAsync(AbdominalCavityRoentgen roentgen)
        {
            if(roentgen.Id == null)
            {
                roentgen.Id = Guid.NewGuid().ToString();
            }
            return await _repo.SaveAsync(roentgen);
        }
    }
}
