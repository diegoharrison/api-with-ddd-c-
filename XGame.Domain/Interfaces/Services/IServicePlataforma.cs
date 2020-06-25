using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Arguments.Plataforma;

namespace XGame.Domain.Interface.Services
{
    public interface IServicePlataforma
    {
        AutenticarPlataformaResponse AutenticarPlataforma(AutenticarPlataformaRequest request);

        AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request);
    }
}
