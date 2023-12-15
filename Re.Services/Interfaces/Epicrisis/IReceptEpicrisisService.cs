using Re.Core.Models;

namespace Re.Services.Interfaces.Epicrisis
{
    public interface IReceptEpicrisisService
    {
        Task<ReceptionEpicrisis> SaveReceptEpicrisisAsync(ReceptionEpicrisis epicrisis);
        Task<List<List<string>>> GetAllAsync();
        IEnumerable<string> GetPropertyNames();
        string FormatValue(object value);
    }
}
