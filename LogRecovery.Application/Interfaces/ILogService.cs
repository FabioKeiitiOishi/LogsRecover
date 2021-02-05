using LogRecovery.Application.ViewModels;
using System.Collections.Generic;

namespace LogRecovery.Application.Interfaces
{
    public interface ILogService
    {
        List<LogVM> Get();
        LogVM GetById(int id);
        bool Post(LogVM model);
        bool PostList(IEnumerable<LogVM> logVMs);
        bool Put(LogVM model);
        bool Delete(int id);
    }
}
