﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Do_Curso_2.AluguelDeCarro.Entidade
{
    public class Cliente : EntidadeBase
    {

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Idade { get; set;}
        public string Cpf { get; set; }
        public string Telefone { get; set; }


    }
}
