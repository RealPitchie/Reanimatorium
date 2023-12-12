using Re.Core.Models.Epicrisis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re.Data.Repo.Epicrisis
{
    public class ChestCavityRepo : IRepo<СhestСavityRoentgen>
    {
        DataContext _context;
        public ChestCavityRepo(DataContext context)
        {
            _context = context;
        }
        public async Task<СhestСavityRoentgen> SaveAsync(СhestСavityRoentgen сhestСavity)
        {
            await _context.ChestСavityRoentgens.AddAsync(сhestСavity);
            await _context.SaveChangesAsync();

            return сhestСavity;
        }
    }
}
