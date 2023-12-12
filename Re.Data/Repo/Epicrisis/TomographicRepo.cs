using Re.Core.Models.Epicrisis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re.Data.Repo.Epicrisis
{
    public class TomographicRepo : IRepo<TomographicExploration>
    {
        DataContext _context;
        public TomographicRepo(DataContext context)
        {
            _context = context;
        }
        public async Task<TomographicExploration> SaveAsync(TomographicExploration tomographic)
        {
            await _context.TomographicExplorations.AddAsync(tomographic);
            await _context.SaveChangesAsync();
            return tomographic;
        }
    }
}
