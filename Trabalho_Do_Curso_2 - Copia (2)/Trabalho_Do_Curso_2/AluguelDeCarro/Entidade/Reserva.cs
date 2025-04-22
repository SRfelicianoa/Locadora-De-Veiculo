using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Do_Curso_2.AluguelDeCarro.Entidade
{
    internal class Reserva
    {
        public Carros Carro { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataOcupacao { get; set; }
        public DateTime DataDesocupacao { get; set; }
        public double ValorLocacao { get; set; } 

    }
}
