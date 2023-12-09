using Microsoft.EntityFrameworkCore;
using Re.Core.Models.Epicrisis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re.Data.Repo
{
    public class TransferableRepo : IRepo<Transferable>
    {
        DataContext _context;
        public TransferableRepo(DataContext context)
        {
            _context = context;
        }
        public async Task<Transferable> SaveAsync(Transferable trEpicrisis)
        {
            await _context.TransferableEpicrisis.AddAsync(trEpicrisis);
            await _context.SaveChangesAsync();

            return trEpicrisis;
        }
    }
}
