using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Do_Curso_2.AluguelDeCarro.Entidade
{
    internal class Reserva
    {
        public Guid IdCarro { get; set; }
        public Guid IdCliente { get; set; }
        public DateTime DataOcupacao { get; set; }
        public DateTime DataDesocupacao { get; set; }
        public double ValorLocacao { get; set; }

    }
}
