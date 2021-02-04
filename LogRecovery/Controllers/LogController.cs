using LogRecovery.Application.Interfaces;
using LogRecovery.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult Get()
        {
            return Ok(_logService.Get());
        }

        [HttpPost]
        public ActionResult Post(LogVM model)
        {
            return Ok(_logService.Post(model));
        }
    }
}
