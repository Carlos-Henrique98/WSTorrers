using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WSTorrer.Interface;
using WSTorrer.Repositories;

namespace WSTorrer.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class JogadorController : ControllerBase
    {
        private IJogadorRepository _jogadorRepository;

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_jogadorRepository.Listar());
        }
    }
}
