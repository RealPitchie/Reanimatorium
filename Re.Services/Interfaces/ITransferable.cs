using Re.Core.Models;
using Re.Core.Models.Epicrisis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re.Services.Interfaces
{
    public interface ITransferable
    {
        Task<Transferable> SaveTransferableAsync(Transferable epicrisis);
    }
}
