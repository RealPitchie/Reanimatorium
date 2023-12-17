using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Re.Core.Models;

namespace Re.Data.Repo
{
    public interface IRepo<T> where T : class
    {
        Task<T> SaveAsync(T entity);
        Task<List<T>> GetAsync();
        //Task<List<T>> GetByDate(DateTime date);
        Task<List<T>> GetByDoctorName(string name);
        Task<List<T>> GetByType(Type type);
    }
}