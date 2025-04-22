using System.Data;
using System.Text;
using System.Text.Json.Serialization;
using Trabalho_Do_Curso_2.AluguelDeCarro;
using Trabalho_Do_Curso_2.AluguelDeCarro.Entidade;
using Trabalho_Do_Curso_2.AluguelDeCarro.Servicos;
using Trabalho_Do_Curso_2.AluguelDeCarro.Repositorio;
using Trabalho_Do_Curso_2.AluguelDeCarro.Front;
using System.Globalization;
using Trabalho_Do_Curso_2.AluguelDeCarro.Front;



namespace Trabalho_Do_Curso_2 
{
    internal class program 
    {
        static ClienteServico _clienteServico;
        static void Main(string[] args) 
        {
            _clienteServico = new ClienteServico();
            bool executar = true;

            do
            {
                int respostaMenu;

                Console.WriteLine("Olá, somos da Roda Livre");
                Console.WriteLine(" ");
                Console.WriteLine("A ação que o(a) senhor(a) gostaria de executar está relacionada com");
                Console.WriteLine("1 - Carro");
                Console.WriteLine("2 - Cliente");
                Console.WriteLine("3 - Reserva");
                Console.WriteLine(" ");
                Console.WriteLine("Digite a opção respectiva abaixo");
                Console.WriteLine(" ");
                respostaMenu = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                switch(respostaMenu)
                {
                    case 1:
                        {
                            CarroFront.MenuCarro();
                            break;
                        }
                    case 2: 
                        {
                            ClienteFront.MenuCliente();
                            break;
                        }
                    case 3: 
                        {
                            ReservaFront.MenuReserva();
                            break;
                        }
                    default:
                        break;
                }
                Console.WriteLine("Gostaria de executar mais alguma coisa?");
                Console.WriteLine("Se sim escreva 'sim' se não escreva 'não'");
                Console.WriteLine(" ");
                executar = Console.ReadLine().ToLower() == "sim" ? true : false;

                Console.Clear();
            }
            while (executar);
        
        }

    }










}