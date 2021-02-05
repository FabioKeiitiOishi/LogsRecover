using LogRecovery.Application.Interfaces;
using LogRecovery.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LogRecovery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private readonly ILogService _logService;

        public LogController(ILogService logService)
        {
            _logService = logService;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_logService.Get());
        
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id) => Ok(_logService.GetById(id));

        [HttpPost]
        public IActionResult Post(LogVM model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(_logService.Post(model));
        }
        [HttpPost("list")]
        public IActionResult Post(List<LogVM> listModel) => Ok(_logService.PostList(listModel));
        
        [HttpPut]
        public IActionResult Put(LogVM model) => Ok(_logService.Put(model));

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id) => Ok(_logService.Delete(id));
    }
}
