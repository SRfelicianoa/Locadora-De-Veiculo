using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_Do_Curso_2.AluguelDeCarro.Entidade;
using Trabalho_Do_Curso_2.AluguelDeCarro.Servicos;

namespace Trabalho_Do_Curso_2.AluguelDeCarro.Front
{
    internal class ClienteFront
    {
        static ClienteServico _clienteServico;

        public static void MenuCliente()
        {
            Console.WriteLine("Você gostaria de executar qual opção?");
            Console.WriteLine("Escreva o número de acordo com a opção");
            Console.WriteLine(" ");
            Console.WriteLine("1 - Registrar-se como cliente");
            Console.WriteLine("2 - Buscar cliente");
            Console.WriteLine(" ");
            int resposta = Convert.ToInt32(Console.ReadLine());

            switch (resposta)
            {
                case 1:
                    {
                        MenuRegistrarCliente();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Qual a forma de busca ao cliente?");
                        Console.WriteLine("Escreva o número de acordo com a opção");
                        Console.WriteLine(" ");
                        Console.WriteLine("1 - Buscar pelo cpf");
                        Console.WriteLine("2 - Buscar pelo telefone");
                        Console.WriteLine("3 - Buscar pelo sobrenome");
                        Console.WriteLine(" ");
                        int respostaDeBusca = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");


                        switch (respostaDeBusca)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Escreva o respectivo cpf");
                                    Console.WriteLine(" ");
                                    string cpf = Console.ReadLine();
                                    Console.WriteLine(" ");
                                    BuscarPeloCPF(cpf);
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("Escreva o respectivo telefone");
                                    Console.WriteLine(" ");
                                    string telefone = Console.ReadLine();
                                    Console.WriteLine(" ");
                                    BuscarPeloCPF(telefone);
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("Escreva o respectivo sobrenome");
                                    Console.WriteLine(" ");
                                    string sobrenome = Console.ReadLine();
                                    Console.WriteLine(" ");
                                    BuscarPeloCPF(sobrenome);
                                    break;
                                }
                            default:
                                break;

                        }
                        break;
                    }
            
        

            }
        }

        public static void MenuRegistrarCliente()
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Informe seu Nome");
            cliente.Nome = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Informe seu Sobrenome");
            cliente.Sobrenome = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Informe sua Idade");
            cliente.Idade = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Informe seu CPF");
            cliente.Cpf = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Informe seu Telefone");
            cliente.Telefone = Console.ReadLine();
            Console.WriteLine(" ");
        }


        public static void BuscarPeloCPF(string cpf)
        {
            _clienteServico = new ClienteServico();

            Cliente cliente = _clienteServico.BuscarPeloCPF(cpf);
            Console.WriteLine(cliente.Cpf);

        }

        public static void BuscarPeloSobrenome(string sobrenome)
        {
            _clienteServico = new ClienteServico();

            Cliente cliente = _clienteServico.BuscarPeloSobrenome(sobrenome);
            Console.WriteLine(cliente.Sobrenome);

        }

        public static void BuscarPeloTelefone(string telefone)
        {
            _clienteServico = new ClienteServico();

            Cliente cliente = _clienteServico.BuscarPeloTelefone(telefone);
            Console.WriteLine(cliente.Telefone);

        }
    }
}
