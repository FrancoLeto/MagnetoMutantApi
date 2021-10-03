using Microsoft.AspNetCore.Mvc;
using Servicies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MagnetoMutantApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MutantController : ControllerBase
    {
        private MutantService _mutantService = new MutantService();

        [HttpPost]
        public HttpResponseMessage Post([FromBody] string[] value)
        {
            var result = _mutantService.IsMutant(value);
            return result ? new HttpResponseMessage(HttpStatusCode.OK) : new HttpResponseMessage(HttpStatusCode.Forbidden);
        }
    }
}
