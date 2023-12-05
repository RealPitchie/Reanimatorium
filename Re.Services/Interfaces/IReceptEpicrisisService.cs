using Re.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re.Services.Interfaces
{
    public interface IReceptEpicrisisService
    {
        Task<ReceptionEpicrisis> SaveReceptEpicrisisAsync(ReceptionEpicrisis epicrisis);
    }
}
