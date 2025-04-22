using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_Do_Curso_2.AluguelDeCarro.Entidade;

namespace Trabalho_Do_Curso_2.AluguelDeCarro.Repositorio
{
    internal class CarroRepositorio
    {
        List<Carros> _carros = [];

        public Guid Registrar(Carros carros)
        {
            carros.Id = Guid.NewGuid();

            _carros.Add(carros);

            return carros.Id;
        }

        public Carros BuscarPelaPlaca(string placa)
        {
            Carros carros = _carros.Find(carros => carros.Placa == placa);

            return carros;
        }

        public Carros BuscarPeloId(Guid id)
        {
            Carros carros = _carros.Find(carros => carros.Id == id);

            return carros;
        }

        public Carros BuscarPelomodelo(string modelo) 
        {
            Carros carros = _carros.Find(carros => carros.Modelo == modelo);

            return carros;
        }

        public List<Carros> BuscarAlugados()
        {
            List<Carros> carrosAlugados = [];

            foreach (Carros carros in _carros)
            {
                if (carros.Ativo)
                    carrosAlugados.Add(carros);
            }

            return carrosAlugados;
        }

        public List<Carros> BuscarTodos()
        {
            return _carros;
        }
    }
}
