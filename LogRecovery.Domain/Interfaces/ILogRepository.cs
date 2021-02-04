using LogRecovery.Domain.Entities;
using System.Collections.Generic;

namespace LogRecovery.Domain.Interfaces
{
    public interface ILogRepository
    {
        IEnumerable<Log> GetAll();
    }
}
