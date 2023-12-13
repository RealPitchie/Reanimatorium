using Microsoft.EntityFrameworkCore;
using Re.Core.Models.Epicrisis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re.Data.Repo.Epicrisis
{
    public class AbdominalRepo : IRepo<AbdominalCavityRoentgen>
    {
        DataContext _context;
        public AbdominalRepo(DataContext context)
        {
            _context = context;
        }
        public async Task<AbdominalCavityRoentgen> SaveAsync(AbdominalCavityRoentgen abdominal)
        {
            await _context.AbdominalRoentgens.AddAsync(abdominal);
            await _context.SaveChangesAsync();
            return abdominal;
        }
    }
}
