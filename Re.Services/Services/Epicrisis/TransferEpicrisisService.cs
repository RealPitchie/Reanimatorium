using Re.Core.Models;
using Re.Core.Models.Epicrisis;
using Re.Data.Repo;
using Re.Services.Interfaces.Epicrisis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re.Services.Services.Epicrisis
{
    public class TransferEpicrisisService : ITransferable
    {
        private readonly IRepo<Transferable> _repo;
        public TransferEpicrisisService(IRepo<Transferable> repo)
        {
            _repo = repo;
        }
        public async Task<Transferable> SaveTransferableAsync(Transferable epicrisis)
        {
            if (epicrisis.Id == null)
            {
                epicrisis.Id = Guid.NewGuid().ToString();
            }
            return await _repo.SaveAsync(epicrisis);
        }
    }
}
