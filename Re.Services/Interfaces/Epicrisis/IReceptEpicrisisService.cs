using Re.Core.Models;

namespace Re.Services.Interfaces.Epicrisis
{
    public interface IReceptEpicrisisService
    {
        Task<ReceptionEpicrisis> SaveReceptEpicrisisAsync(ReceptionEpicrisis epicrisis);
        Task<IEnumerable<ReceptionEpicrisis>> GetAllAsync();
        IEnumerable<string> GetPropertyNames();
    }
}
