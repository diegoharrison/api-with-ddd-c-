using System;
using System.Linq;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Services;

namespace XGame.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inciando...");

            var service = new ServiceJogador();
            Console.WriteLine("Criei instancia do servico");

            AutenticarJogadorRequest request = new AutenticarJogadorRequest();
            Console.WriteLine("Criei instancia do meu objeto request");
            request.Email = "diego@gmail.com";
            request.Senha = "1231212312";

            var response = service.AutenticarJogador(request);

            Console.WriteLine("Serviço é válido => " + service.IsValid());

            service.Notifications.ToList().ForEach(x => {
                Console.WriteLine(x.Message);
            });

            Console.ReadKey();
        }
    }
}
