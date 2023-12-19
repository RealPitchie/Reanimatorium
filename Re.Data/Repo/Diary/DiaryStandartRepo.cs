using Microsoft.EntityFrameworkCore;
using Re.Core.Extensions;
using Re.Core.Models;

namespace Re.Data.Repo.Diary
{
    public class DiaryStandartRepo : IRepo<StandartDiary>
    {
        DataContext _context;
        public DiaryStandartRepo(DataContext context)
        {
            _context = context;
        }


        public async Task<StandartDiary> SaveAsync(StandartDiary standart)
        {
            await _context.StandartDiaries.AddAsync(standart);
            await _context.SaveChangesAsync();

            return standart;
        }

        public async Task<List<StandartDiary>> GetAsync()
        {
            return await _context.Set<StandartDiary>().IncludeAll().ToListAsync();
        }
    }

}
