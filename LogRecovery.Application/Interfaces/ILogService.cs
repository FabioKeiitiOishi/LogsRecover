using LogRecovery.Domain.Entities;
using System.Collections.Generic;

namespace LogRecovery.Application.Interfaces
{
    public interface ILogService
    {
        IEnumerable<Log> Get();
        bool Post(Log log);
    }
}
