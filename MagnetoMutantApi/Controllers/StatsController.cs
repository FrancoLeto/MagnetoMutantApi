using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Servicies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MagnetoMutantApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StatsController : ControllerBase
    {
        private IStatsService _statsService;
        public StatsController(IStatsService statsService)
        {
            _statsService = statsService;
        }

        // GET: api/<StatsController>
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(_statsService.GetStats());
        }

    }
}
