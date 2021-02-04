using LogRecovery.Application.ViewModels;
using System.Collections.Generic;

namespace LogRecovery.Application.Interfaces
{
    public interface ILogService
    {
        List<LogVM> Get();
        bool Post(LogVM model);
    }
}
