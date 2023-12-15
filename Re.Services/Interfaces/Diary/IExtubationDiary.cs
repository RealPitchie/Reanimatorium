using Re.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re.Services.Interfaces.Diary
{
    public interface IExtubationDiary
    {
        Task<Extubation> SaveExtubationDiaryAsync(Extubation extubation);
        Task<List<List<string>>> GetAllAsync();
        IEnumerable<string> GetPropertyNames();
        string FormatValue(object value);
    }
}
