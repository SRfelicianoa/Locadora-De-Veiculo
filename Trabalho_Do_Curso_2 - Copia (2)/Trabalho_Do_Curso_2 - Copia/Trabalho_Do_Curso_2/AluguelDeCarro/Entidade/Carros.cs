using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Do_Curso_2.AluguelDeCarro.Entidade
{
    internal class Carros
    {
        public Guid Id { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataHoraOcupacao { get; set; }
        public DateTime DataHoraDesocupacao { get; set; }


    }
}
