using Re.Core.Models;

namespace Re.Data.Repo.Diary
{
    public class DiaryExtubationRepo : IRepo<Extubation>
    {
        DataContext _context;
        public DiaryExtubationRepo(DataContext context)
        {
            _context = context;
        }
        public async Task<Extubation> SaveAsync(Extubation extubation)
        {
            await _context.ExtubationDiaries.AddAsync(extubation);
            await _context.SaveChangesAsync();

            return extubation;
        }
    }

}
