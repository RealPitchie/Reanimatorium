using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Re.Core.Models;
using Re.Data.Repo;
using Re.Services.Interfaces.Diary;

namespace Re.Services.Services
{
    public class StandartDiaryService : IStandartDiary
    {
        private readonly IRepo<StandartDiary> _repo;
        public StandartDiaryService(IRepo<StandartDiary> repo)
        {
            _repo = repo;
        }

        public async Task<StandartDiary> SaveStandartDiaryAsync(StandartDiary standart)
        {
            if (standart.Id == null)
            {
                standart.Id = Guid.NewGuid().ToString();
            }
            standart.EsCCO.Id = Guid.NewGuid().ToString();
            standart.Picco.Id = Guid.NewGuid().ToString();
            standart.Picco2.Id = Guid.NewGuid().ToString();
            standart.FioTrac.Id = Guid.NewGuid().ToString();
            standart.VoLEF.Id = Guid.NewGuid().ToString();
            return await _repo.SaveAsync(standart);
        }
    }
}