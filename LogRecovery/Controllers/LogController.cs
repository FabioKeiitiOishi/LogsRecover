using LogRecovery.Application.Interfaces;
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
    }
}
