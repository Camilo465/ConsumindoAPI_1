using ConsumindoAPI.Integracao.Response;
using Refit;

namespace ConsumindoAPI.Integracao.Interfaces
{
    public interface IViaCepIntegracao
    {
        [Get("/ws/{cep}/json")]
        Task<ViaCepResponse> ObterDadosViaCep(string cep);
    }
}
