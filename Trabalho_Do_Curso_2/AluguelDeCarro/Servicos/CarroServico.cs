using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_Do_Curso_2.AluguelDeCarro.Entidade;
using Trabalho_Do_Curso_2.AluguelDeCarro.Repositorio;

namespace Trabalho_Do_Curso_2.AluguelDeCarro.Servicos
{
    internal class CarroServico
    {
        public CarroRepositorio _carroRepositorio = new CarroRepositorio();

        public List<Carros> BuscarAlugados()
        {
            return _carroRepositorio.BuscarAlugados();
        }

        //public Guid Registrar(Carros carros)
        //{
        //    carros.DataHoraOcupacao = DateTime.Now;
        //    carros.Ativo = true;
        //    return _carroRepositorio.Registrar(Carros carros);
        //}

        public Carros BuscarPelaPlaca(string placa)
        {
            Carros carros = _carroRepositorio.BuscarPelaPlaca(placa);

            if (carros is not null)
                return carros;

            throw new Exception("Carro não encontrado");
        }

        public Carros Buscar(Predicate<Carros> query)
        {
            return _carroRepositorio.Buscar(query);
        }

        public Carros BuscarPeloId(Guid id)
        {
            Carros carros = _carroRepositorio.BuscarPeloId(id);

            if (carros is not null)
                return carros;

            throw new Exception("Carro não encontrado");
        }

        public void RegistrarDesocupacao(string placa)
        {
            Carros carros = _carroRepositorio.BuscarPelaPlaca(placa);
            carros.DataHoraDesocupacao = DateTime.Now;
            carros.Ativo = false;
        }

        public void RegistrarDesocupacao(Guid id)
        {
            Carros carros = _carroRepositorio.BuscarPeloId(id);
            carros.DataHoraDesocupacao = DateTime.Now;
            carros.Ativo = false;
        }

        public List<Carros> BuscarTodos()
        {
            return _carroRepositorio.BuscarTodos();
        }
    }

}
