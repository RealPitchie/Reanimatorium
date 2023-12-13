using Re.Core.Models;
using Re.Data.Repo;
using Re.Services.Interfaces.Epicrisis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re.Services.Services.Epicrisis
{
    public class ReceptEpicrisisService : IReceptEpicrisisService
    {
        private readonly IRepo<ReceptionEpicrisis> _repo;
        public ReceptEpicrisisService(IRepo<ReceptionEpicrisis> repo)
        {
            _repo = repo;
        }
        public async Task<ReceptionEpicrisis> SaveReceptEpicrisisAsync(ReceptionEpicrisis epicrisis)
        {
            if (epicrisis.Id == null)
            {
                epicrisis.Id = Guid.NewGuid().ToString();
            }
            return await _repo.SaveAsync(epicrisis);
        }
    }
}
