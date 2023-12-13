using Re.Core.Models.Epicrisis;

namespace Re.Services.Interfaces.Epicrisis
{
    public interface IChestCavity
    {
        Task<СhestСavityRoentgen> SaveChestCavityAsync(СhestСavityRoentgen epicrisis);
    }
}
