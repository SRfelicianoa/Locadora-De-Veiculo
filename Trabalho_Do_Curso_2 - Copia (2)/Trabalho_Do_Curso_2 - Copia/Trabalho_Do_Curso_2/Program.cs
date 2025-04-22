using System.Data;
using System.Text;
using System.Text.Json.Serialization;
using Trabalho_Do_Curso_2.AluguelDeCarro;
using Trabalho_Do_Curso_2.AluguelDeCarro.Entidade;
using Trabalho_Do_Curso_2.AluguelDeCarro.Servicos;

namespace Trabalho_Do_Curso_2 
{
    internal class program 
    {
        static void Main(string[] args) 
        {

            bool sim = true;

            do
            {
                int resposta;
                string rsposta;
                string respostaburra = "/2/2/3/1/4/3/2/3/4/2/7/5/6/" +
                    "7/6/7/7/5/6/2/7/3/4/3/6/5/6/7/6/5/4/2" +
                    "/7/4/6/5/6/2/3/7/4/6/3/5/6/9/2/8/3/7/" +
                    "5/6//45/9/3////87687///";

                Console.WriteLine("O que o senhor/senhora gostaria de fazer?");
                Console.WriteLine(" ");
                Console.WriteLine("1 Registrar-se como cliente");
                Console.WriteLine("2 Registrar um carro");
                Console.WriteLine(" ");

                resposta = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" ");



                
                if (resposta == 1)
                {
                     MenuRegistrarCliente();
                }
                else if (resposta == 2)
                {
                    MenuRegistrarCarro();
                }
                else
                {
                    Console.WriteLine("Sem resposta");
                    Console.WriteLine(" ");
                    Console.WriteLine("Escreva qualquer coisa para retornar");
                    rsposta = Console.ReadLine();

                    //if (rsposta != respostaburra) 
                    //{
                    //    Console.Clear();
                    //}
                    
                }

                Console.WriteLine(" ");
                Console.WriteLine("Gostaria de cadastrar mais alguma coisa?");
                Console.WriteLine("Se gostaria digite 'sim'");
                Console.WriteLine("Se não apenas pressione enter");

                sim = Console.ReadLine().ToLower() == "sim" ? true : false;
                Console.Clear();
            }
            while (sim);








        
        }

        static void MenuRegistrarCliente() 
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Informe seu Nome");
            cliente.nome = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Informe seu Sobrenome");
            cliente.sobrenome = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Informe sua Idade");
            cliente.idade = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Informe seu CPF");
            cliente.cpf = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Informe seu Telefone");
            cliente.telefone = Console.ReadLine();
            Console.WriteLine(" ");
        }

        static void MenuRegistrarCarro() 
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

        
    
    
    
    }










}