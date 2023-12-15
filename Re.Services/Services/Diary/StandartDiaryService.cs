using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Re.Core.Models;
using Re.Data.Repo;
using Re.Services.Interfaces.Diary;

namespace Re.Services.Services.Diary
{
    public class StandartDiaryService : IStandartDiary
    {
        private readonly IRepo<StandartDiary> _repo;
        public StandartDiaryService(IRepo<StandartDiary> repo)
        {
            _repo = repo;
        }

        public string FormatValue(object value)
        {
            string result = "";
            if (value is string[])
            {
                var array = value as Array;
                foreach (var arr in array)
                {
                    result += $"{arr} ";
                }
                return result;
            }
            else if (value is int[])
            {
                var array = value as Array;
                foreach (var arr in array)
                {
                    result += $"{arr} ";
                }
                return result;
            }
            else if (value is Doctor)
            {
                var doctor = value as Doctor;
                return doctor.Name;
            }
            else
            {
                return value?.ToString() ?? string.Empty;
            }
        }

        public async Task<List<List<string>>> GetAllAsync()
        {
            var response = new List<List<string>>();
            var data = await _repo.GetAsync();
            foreach (var item in data)
            {
                var formatedData = new List<string>();
                foreach (var name in GetPropertyNames())
                {
                    var value = item.GetType().GetProperty(name).GetValue(item);
                    var formatValue = FormatValue(value);
                    formatedData.Add(formatValue);
                }
                response.Add(formatedData);
            }
            return response;
        }

        public IEnumerable<string> GetPropertyNames()
        {
            var bruh1 = typeof(StandartDiary).GetProperties();
            var bruh = bruh1.Select(prop => prop.Name).ToList();
            return bruh;
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