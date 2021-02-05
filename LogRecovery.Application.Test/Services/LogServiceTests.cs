using AutoMapper;
using LogRecovery.Application.AutoMapper;
using LogRecovery.Application.Services;
using LogRecovery.Application.ViewModels;
using LogRecovery.Domain.Entities;
using LogRecovery.Domain.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace LogRecovery.Application.Test.Services
{
    public class LogServiceTests
    {
        private LogService _logService;
        public LogServiceTests()
        {
            _logService = new LogService(new Mock<ILogRepository>().Object, new Mock<IMapper>().Object);
        }

        #region Validating SendindId

        [Fact]
        public void Post_SendingId()
        {
            var exception = Assert.Throws<Exception>(() => _logService.Post(new LogVM { Id = 7 }));
            Assert.Equal("LogId must be 0.", exception.Message);
        }

        [Fact]
        public void PostList_SendingEmptyList()
        {
            var exception = Assert.Throws<Exception>(() => _logService.PostList(new List<LogVM>()));
            Assert.Equal("The list of logs is empty.", exception.Message);
        }

        [Fact]
        public void GetById_SendingIdZero()
        {
            var exception = Assert.Throws<Exception>(() => _logService.GetById(0));
            Assert.Equal("LogId is invalid.", exception.Message);
        }

        [Fact]
        public void Put_SendingIdZero()
        {
            var exception = Assert.Throws<Exception>(() => _logService.Put(new LogVM()));
            Assert.Equal("LogId is invalid.", exception.Message);
        }

        [Fact]
        public void Delete_SendingIdZero()
        {
            var exception = Assert.Throws<Exception>(() => _logService.Delete(0));
            Assert.Equal("LogId is invalid.", exception.Message);
        }

        #endregion

        #region Validating Correct Objects

        [Fact]
        public void Post_SendingValidObject()
        {
            var result = _logService.Post(
                new LogVM { 
                    Ip = "10.10.255.9", 
                    RecordedTime = DateTime.Now, 
                    UserAgent = "GET HTTP 1.0 novo documento" 
                });

            Assert.True(result);
        }

        [Fact]
        public void GetAll_ValidatingObject()
        {
            List<Log> logs = new List<Log>();
            logs.Add(new Log { 
                Id = 2, 
                Ip = "50.42.35.10", 
                RecordedTime = DateTime.Now.AddDays(-1), 
                UserAgent = "bla bla bla", 
                DateCreated = DateTime.Now 
            });

            var logRepository = new Mock<ILogRepository>();
            logRepository.Setup(x => x.GetAll()).Returns(logs);

            var autoMapperProfile = new AutoMapperSetup();
            var mapperConfiguration = new MapperConfiguration(x => x.AddProfile(autoMapperProfile));
            IMapper mapper = new Mapper(mapperConfiguration);

            _logService = new LogService(logRepository.Object, mapper);

            var result = _logService.Get();
            Assert.True(result.Count > 0);
        }

        #endregion

        #region Validating Required Objects

        [Fact]
        public void Post_SendingInvalidObject()
        {
            var exception = Assert.Throws<ValidationException>(() => _logService.Post(new LogVM { Ip = "192.168.0.55" }));
            Assert.Equal("The UserAgent field is required.", exception.Message);
        }

        #endregion
    }
}
