using Re.Core.Models;

namespace Re.Data.Repo.Epicrisis
{
    public class ReceptEpicrisisRepo : IRepo<ReceptionEpicrisis>
    {
        DataContext _context;
        public ReceptEpicrisisRepo(DataContext context)
        {
            _context = context;
        }
        public async Task<ReceptionEpicrisis> SaveAsync(ReceptionEpicrisis reception)
        {
            await _context.ReceptionEpicrises.AddAsync(reception);
            await _context.SaveChangesAsync();

            return reception;
        }
    }
}
