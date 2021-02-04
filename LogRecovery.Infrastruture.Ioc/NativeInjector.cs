using LogRecovery.Application.Interfaces;
using LogRecovery.Application.Services;
using LogRecovery.Domain.Interfaces;
using LogRecovery.Infrastruture.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace LogRecovery.Infrastruture.Ioc
{
    public static class NativeInjector
    {
        public static void RegisterSevices(IServiceCollection services)
        {
            #region Services
            services.AddScoped<ILogService, LogService>();
            #endregion
            #region Repositories
            services.AddScoped<ILogRepository, LogRepository>();
            #endregion

        }
    }
}
