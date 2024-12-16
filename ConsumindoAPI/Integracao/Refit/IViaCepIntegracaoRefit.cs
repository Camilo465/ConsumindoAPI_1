﻿using ConsumindoAPI.Integracao.Response;
using Refit;

namespace ConsumindoAPI.Integracao.Refit
{
    public interface IViaCepIntegracaoRefit
    {
        [Get("/ws/{cep}/json")]
        Task<ApiResponse<ViaCepResponse>> ObterDadosViaCep(string cep);
    }
}