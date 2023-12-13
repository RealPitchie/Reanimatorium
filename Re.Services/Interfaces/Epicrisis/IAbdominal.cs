using Re.Core.Models.Epicrisis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re.Services.Interfaces.Epicrisis
{
    public interface IAbdominal
    {
        Task<AbdominalCavityRoentgen> SaveAbdominalCavityAsync(AbdominalCavityRoentgen roentgen);
    }
}
