using Re.Core.Models.Epicrisis;
using Re.Data.Repo;
using Re.Services.Interfaces.Epicrisis;

namespace Re.Services.Services.Epicrisis
{
    public class ChestCavityService : IChestCavity
    {
        private readonly IRepo<СhestСavityRoentgen> _repo;
        public ChestCavityService(IRepo<СhestСavityRoentgen> repo)
        {
            _repo = repo;
        }
        public async Task<СhestСavityRoentgen> SaveChestCavityAsync(СhestСavityRoentgen chestCavity)
        {
            if(chestCavity.Id == null)
            {
                chestCavity.Id = Guid.NewGuid().ToString();
            }
            return await _repo.SaveAsync(chestCavity);
        }
    }
}
