using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Re.Core.Models;

namespace Re.Services.Interfaces
{
    public interface IProtocols
    {
        Task<StandardProtocol> SaveProtocolAsync(StandardProtocol protocol);
    }
}