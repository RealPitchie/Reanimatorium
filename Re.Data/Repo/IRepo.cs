using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Re.Core.Models;

namespace Re.Data.Repo
{
    public interface IRepo
    {
        Task<StandardProtocol> SaveProtocolAsync(StandardProtocol protocol);
    }
}