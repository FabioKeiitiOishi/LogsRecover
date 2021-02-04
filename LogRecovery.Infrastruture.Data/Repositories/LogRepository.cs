using LogRecovery.Domain.Entities;
using LogRecovery.Domain.Interfaces;
using LogRecovery.Infrastruture.Data.Contexts;
using System.Collections.Generic;

namespace LogRecovery.Infrastruture.Data.Repositories
{
    public class LogRepository : Repository<Log>, ILogRepository
    {
        public LogRepository(LogRecoveryContext context)
            : base(context)
        {
        }

        public IEnumerable<Log> GetAll()
        {
            return Query(x => !x.Deleted);
        }
    }
}
