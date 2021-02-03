using LogRecovery.Application.Interfaces;
using LogRecovery.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace LogRecovery.Infrastruture.Ioc
{
    public static class NativeInjector
    {
        public static void RegisterSevices(IServiceCollection services)
        {
            services.AddScoped<ILogService, LogService>();
        }
    }
}
