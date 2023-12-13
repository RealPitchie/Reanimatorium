using Re.Core.Models.Hemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re.Services.Interfaces.Hemo
{
    public interface IErythrocyte
    {
        Task<ErythrocyteProtocol> SaveErythrocyteProtocolAsync(ErythrocyteProtocol er);
    }
}
