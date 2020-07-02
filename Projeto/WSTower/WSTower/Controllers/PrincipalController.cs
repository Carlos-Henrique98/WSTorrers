using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WSTower.Domains;
using WSTower.Repositories;
using WSTowers.Controllers;
using WSTowers.Repositories;

namespace WSTower.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class PrincipalController : ControllerBase
    {
        private PrincipalRepository _principalRepository;

        public PrincipalController()
        {
            _principalRepository = new PrincipalRepository();
        }

        [HttpGet("{estadio}")]
        public IActionResult GetByNome(string estadio)
        {
            try
            {
                Jogo jogosInfo = _principalRepository.buscarSelecao(estadio);

                if(jogosInfo != null)
                {
                    return Ok(jogosInfo);
                }
                return NotFound("Jogo não encontrado!");
            }
            catch(Exception error)
            {
                return BadRequest(error);
            }
        }
    }
}
