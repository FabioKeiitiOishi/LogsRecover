using AutoMapper;
using LogRecovery.Application.ViewModels;
using LogRecovery.Domain.Entities;

namespace LogRecovery.Application.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            #region ViewModelToDomain
            CreateMap<LogVM, Log>();
            #endregion
            #region DomainToViewModel
            CreateMap<Log, LogVM>();
            #endregion
        }
    }
}
