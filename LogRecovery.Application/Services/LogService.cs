using AutoMapper;
using LogRecovery.Application.Interfaces;
using LogRecovery.Application.ViewModels;
using LogRecovery.Domain.Entities;
using LogRecovery.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

namespace LogRecovery.Application.Services
{
    public class LogService : ILogService
    {
        private readonly ILogRepository _logRepository;
        private readonly IMapper _mapper;

        public LogService(ILogRepository logRepository, IMapper mapper)
        {
            _logRepository = logRepository;
            _mapper = mapper;
        }
        
        public List<LogVM> Get()
        {
            IEnumerable<Log> logs = _logRepository.GetAll();
            return _mapper.Map<List<LogVM>>(logs);
        }

        public LogVM GetById(int id)
        {
            if (id == 0)
                throw new Exception("LogId is invalid.");

            Log log = _logRepository.Find(x => x.Id == id && !x.Deleted);
            if (log == null)
                throw new Exception("Log is not found");

            return _mapper.Map<LogVM>(log);
        }

        public bool Post(LogVM model)
        {
            if (model.Id != 0)
                throw new Exception("LogId must be 0.");

            Validator.ValidateObject(model, new ValidationContext(model), true);

            Log log = _mapper.Map<Log>(model);

            _logRepository.Create(log);
            return true;
        }

        public bool PostList(IEnumerable<LogVM> logVMs)
        {
            if (!logVMs.Any())
                throw new Exception("The list of logs is empty.");

            IEnumerable<Log> logs = _mapper.Map<IEnumerable<Log>>(logVMs);
            _logRepository.Create(logs);

            return true;
        }

        public bool Put(LogVM model)
        {
            if (model.Id == 0)
                throw new Exception("LogId is invalid.");

            Log log = _logRepository.Find(x => x.Id == model.Id && !x.Deleted);
            if (log == null)
                throw new Exception("Log is not found");

            log = _mapper.Map<Log>(model);
            _logRepository.Update(log);

            return true;
        }

        public bool Delete(int id)
        {
            if (id == 0)
                throw new Exception("LogId is invalid.");

            Log log = _logRepository.Find(x => x.Id == id && !x.Deleted);
            if (log == null)
                throw new Exception("Log is not found");

            return _logRepository.Delete(log);
        }
    }
}
