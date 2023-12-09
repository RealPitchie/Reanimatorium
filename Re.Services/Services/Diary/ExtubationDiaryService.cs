using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Re.Core.Models;
using Re.Data.Repo;
using Re.Services.Interfaces.Diary;

namespace Re.Services.Services
{
    public class ExtubationDiaryService : IExtubationDiary
    {
        private readonly IRepo<Extubation> _repo;
        public ExtubationDiaryService(IRepo<Extubation> repo)
        {
            _repo = repo;
        }
        public async Task<Extubation> SaveExtubationDiaryAsync(Extubation extubation)
        {
            if (extubation.Id == null)
            {
                extubation.Id = Guid.NewGuid().ToString();
            }
            return await _repo.SaveAsync(extubation);
        }
    }
}