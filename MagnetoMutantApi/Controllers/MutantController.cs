using Microsoft.AspNetCore.Mvc;
using Servicies.Interfaces;
using System.Net;
using System.Net.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MagnetoMutantApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MutantController : ControllerBase
    {
        private IMutantService _mutantService;

        public MutantController(IMutantService mutantService)
        {
            _mutantService = mutantService;
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody] string[] value)
        {
            var result = _mutantService.IsMutant(value);
            return result ? new HttpResponseMessage(HttpStatusCode.OK) : new HttpResponseMessage(HttpStatusCode.Forbidden);
        }
    }
}
