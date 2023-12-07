using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Re.Core.Models;
using Re.Data.Repo;
using Re.Services.Interfaces.Diary;

namespace Re.Services.Services
{
    public class WeekendDiaryService : IWeekendDiary
    {
        private readonly IRepo<WeekendDiary> _repo;
        public WeekendDiaryService(IRepo<WeekendDiary> repo)
        {
            _repo = repo;
        }
        public async Task<WeekendDiary> SaveWeekendDiaryAsync(WeekendDiary weekend)
        {
            return await _repo.SaveAsync(weekend);
        }
    }
}