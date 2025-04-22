using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_Do_Curso_2.AluguelDeCarro.Entidade;
using Trabalho_Do_Curso_2.AluguelDeCarro.Servicos;

namespace Trabalho_Do_Curso_2.AluguelDeCarro.Front
{
    public static class CarroFront

    {

        static CarroServico _carroServico;
        public static void MenuCarro()
        {
            Console.WriteLine("Você gostaria de executar qual opção?");
            Console.WriteLine("Escreva o número de acordo com a opção");
            Console.WriteLine(" ");
            Console.WriteLine("1 - Registrar um carro");
            Console.WriteLine("2 - Buscar carro");
            Console.WriteLine(" ");
            int resposta = Convert.ToInt32(Console.ReadLine());

            switch (resposta) 
            {
                case 1: 
                    {
                        MenuRegistrarCarro();
                        break;
                    }
                case 2: 
                    {
                        Console.WriteLine("Qual a forma de busca ao carro?");
                        Console.WriteLine("Escreva o número de acordo com a opção");
                        Console.WriteLine(" ");
                        Console.WriteLine("1 - Buscar pela placa");
                        Console.WriteLine("2 - Buscar pelo id");
                        Console.WriteLine(" ");
                        int respostaDeBusca = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");

                        switch (respostaDeBusca) 
                        {
                            case 1: 
                                {
                                    Console.WriteLine("Escreva a respectiva placa");
                                    Console.WriteLine(" ");
                                    string placa = Console.ReadLine();
                                    Console.WriteLine(" ");
                                    BuscarPelaPlaca(placa);
                                    break;
                                }
                            case 2: 
                                {
                                    Console.WriteLine("Escreva o respectivo id");
                                    Console.WriteLine(" ");
                                    Guid id = Guid.Parse(Console.ReadLine());
                                    Console.WriteLine(" ");
                                    BuscarPeloId(id);
                                    break;
                                }
                            default:
                                break;
                        }
                    break;

                    }
            }
        }






        public static void MenuRegistrarCarro()
        {
            Carros carros = new Carros();

            Console.WriteLine("Informe a Cor");
            carros.Cor = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Informe sua Placa");
            carros.Placa = Console.ReadLine();

            Console.WriteLine(" ");
            Console.WriteLine("Informe o Modelo");
            carros.Modelo = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Informe a Marca");
            carros.Marca = Console.ReadLine();
            Console.WriteLine(" ");
        }

        public static void BuscarPelaPlaca(string placa)
        {
            _carroServico = new CarroServico();

            Carros carros = _carroServico.BuscarPelaPlaca(placa);
            Console.WriteLine(carros.Placa);

        }
        public static void BuscarPeloId(Guid id)
        {
            _carroServico = new CarroServico();

            Carros carros = _carroServico.BuscarPeloId(id);
            Console.WriteLine(carros.Id);

        }

    }
}
