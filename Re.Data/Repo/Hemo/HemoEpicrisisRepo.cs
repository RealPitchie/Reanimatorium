using Re.Core.Models;
using Re.Core.Models.Hemo;
using Microsoft.EntityFrameworkCore;

namespace Re.Data.Repo.Hemo
{
    public class HemoEpicrisisRepo:IRepo<HemoEpicrisis>
    {
        DataContext _context;
        public HemoEpicrisisRepo(DataContext context)
        {
            _context = context;
        }
        public async Task<HemoEpicrisis> SaveAsync(HemoEpicrisis ep)
        {
            await _context.HemoEpicrises.AddAsync(ep);
            await _context.SaveChangesAsync();

            return ep;
        }
    }
}
