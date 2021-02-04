using LogRecovery.Application.Interfaces;
using LogRecovery.Application.ViewModels;
using LogRecovery.Domain.Entities;
using LogRecovery.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace LogRecovery.Application.Services
{
    public class LogService : ILogService
    {
        private readonly ILogRepository _logRepository;

        public LogService(ILogRepository logRepository)
        {
            _logRepository = logRepository;
        }
        public bool Post(LogVM model)
        {
            Log log = new Log
            {
                Ip = model.Ip,
                RecordedTime = model.RecordedTime,
                UserAgent = model.UserAgent
            };

            _logRepository.Create(log);
            return true;
        }

        public List<LogVM> Get()
        {
            List<LogVM> logsVM = new List<LogVM>();
            IEnumerable<Log> logs = _logRepository.GetAll();

            foreach (var log in logs)
            {
                logsVM.Add(new LogVM { Id = log.Id, Ip = log.Ip, RecordedTime = log.RecordedTime, UserAgent = log.UserAgent });
            }
            return logsVM;
        }
    }
}
