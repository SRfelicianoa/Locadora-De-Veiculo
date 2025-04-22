using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_Do_Curso_2.AluguelDeCarro.Entidade;
using Trabalho_Do_Curso_2.AluguelDeCarro.Repositorio;

namespace Trabalho_Do_Curso_2.AluguelDeCarro.Servicos
{
    internal class ClienteServico
    {
        public ClienteRepositorio _clienteRepositorio = new ClienteRepositorio();
        public Cliente BuscarPeloCPF(string cpf)
        {
            Cliente cliente = _clienteRepositorio.BuscarPeloCPF(cpf);

            if (cliente is not null)
                return cliente;

            throw new Exception("Cliente não encontrado");
        }

        public Cliente BuscarPeloTelefone(string telefone)
        {
            Cliente cliente = _clienteRepositorio.BuscarPeloTelefone(telefone);

            if (cliente is not null)
                return cliente;

            throw new Exception("Cliente não encontrado");
        }

        public Cliente BuscarPeloSobrenome(string sobrenome)
        {
            Cliente cliente = _clienteRepositorio.BuscarPeloSobrenome(sobrenome);

            if (cliente is not null)
                return cliente;

            throw new Exception("Cliente não encontrado");
        }

        public List<Cliente> BuscarTodos() 
        {
            return _clienteRepositorio.BuscarTodos();
        }
    }
}
