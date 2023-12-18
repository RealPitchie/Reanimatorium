using Microsoft.EntityFrameworkCore;
using Re.Core.Extensions;
using Re.Core.Models;

namespace Re.Data.Repo.Diary
{
    public class DiaryWeekendRepo : IRepo<WeekendDiary>
    {
        DataContext _context;
        public DiaryWeekendRepo(DataContext context)
        {
            _context = context;
        }

        public async Task<WeekendDiary> SaveAsync(WeekendDiary weekend)
        {
            await _context.WeekendDiaries.AddAsync(weekend);
            await _context.SaveChangesAsync();

            return weekend;
        }
        public async Task<List<WeekendDiary>> GetAsync()
        {
            return await _context.Set<WeekendDiary>().IncludeAll().ToListAsync();
        }

    }

}
