using LogRecovery.Application.Interfaces;
using LogRecovery.Domain.Entities;
using System.Collections.Generic;

namespace LogRecovery.Application.Services
{
    public class LogService : ILogService
    {
        public IEnumerable<Log> Get()
        {
            throw new System.NotImplementedException();
        }

        public bool Post(Log log)
        {
            throw new System.NotImplementedException();
        }
    }
}
