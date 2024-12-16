using ConsumindoAPI.Integracao;
using ConsumindoAPI.Integracao.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsumindoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CepController : ControllerBase
    {
        private readonly IViaCepIntegracao _viaCepIntegracao;

        public CepController(IViaCepIntegracao viaCepIntegracao)
        {
            _viaCepIntegracao = viaCepIntegracao;
        }
        [HttpGet("{cep}")]
        public async Task<ActionResult<ViaCepIntegracao>> ListarDadosEndereco(string cep)
        {
            var responseData = await _viaCepIntegracao.ObterDadosViaCep(cep);
            if (responseData == null)
                return BadRequest();

            return Ok(responseData);
        }
    }
}
