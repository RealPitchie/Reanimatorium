using Re.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re.Services.Interfaces.Diary
{
    public interface IWeekendDiary
    {
        Task<WeekendDiary> SaveWeekendDiaryAsync(WeekendDiary weekend);
        Task<List<List<string>>> GetAllAsync();
        IEnumerable<string> GetPropertyNames();
        string FormatValue(object value);
    }
}
