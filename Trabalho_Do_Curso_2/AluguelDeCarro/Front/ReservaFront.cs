using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_Do_Curso_2.AluguelDeCarro.Entidade;
using Trabalho_Do_Curso_2.AluguelDeCarro.Servicos;

namespace Trabalho_Do_Curso_2.AluguelDeCarro.Front
{
    public static class ReservaFront
    {
        public static void MenuReserva()
        {
            CarroServico carroServico = new CarroServico();
            ClienteServico clienteServico = new ClienteServico();

            bool executar = true;
            do
            {
                Console.WriteLine("1 para registrar a reserva");
                Console.WriteLine("2 para sair");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            Console.WriteLine("Informe o ID do carro que deseja locar");
                            Guid idVeiculo = Guid.Parse(Console.ReadLine());
                            Console.WriteLine("Informe o ID do cliente");
                            Guid idPessoa = Guid.Parse(Console.ReadLine());

                            Carros carroLocalizado = carroServico.BuscarPeloId(idVeiculo);
                            Cliente clienteLocalizado = clienteServico.BuscarPeloId(idVeiculo);

                            Reserva reserva = new Reserva();
                            reserva.IdCarro = carroLocalizado.Id;
                            reserva.DataOcupacao = DateTime.Now;
                            reserva.IdCliente = clienteLocalizado.ID;

                            break;
                        }
                    case 2:
                        {
                            executar = false; break;
                        }
                    default:
                        break;
                }
            }   while (executar);
        }
    }
}
