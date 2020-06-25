using System;
using XGame.Domain.Arguments.Jogador;

namespace XGame.Domain.Interface.Services
{
    public interface IServicePlataforma
    {
        AutenticarPlataformaResponse AutenticarPlataforma(AutenticarPlataformaRequest request);

        AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request);
    }
}
