using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_Do_Curso_2.AluguelDeCarro.Entidade;

namespace Trabalho_Do_Curso_2.AluguelDeCarro.Repositorio
{
    internal class ClienteRepositorio
    {
        List<Cliente> _cliente = [];

        public Cliente BuscarPeloCPF(string cpf) 
        {
            Cliente cliente = _cliente.Find(cliente => cliente.cpf == cpf);

            return cliente;
        }

        public Cliente BuscarPeloSobrenome(string sobrenome)
        {
            Cliente cliente = _cliente.Find(cliente => cliente.sobrenome == sobrenome);

            return cliente;
        }

        public Cliente BuscarPeloTelefone(string telefone)
        {
            Cliente cliente = _cliente.Find(cliente => cliente.telefone == telefone);

            return cliente;
        }

        public List<Cliente> BuscarTodos()
        {
            return _cliente;
        }
    }
}
