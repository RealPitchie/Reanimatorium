using Microsoft.EntityFrameworkCore;
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
        public Task<IEnumerable<StandartDiary>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
        public async Task<StandartDiary> SaveAsync(StandartDiary standart)
        {
            await _context.StandartDiaries.AddAsync(standart);
            await _context.SaveChangesAsync();

            return standart;
        }
    }

}
