using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Trabalho_Do_Curso_2.AluguelDeCarro.Entidade;
using Trabalho_Do_Curso_2.AluguelDeCarro.Servicos;

namespace Trabalho_Do_Curso_2.AluguelDeCarro.Repositorio
{
    public class CarroRepositorio
    {
        List<Carros> _carros = [];
        private readonly string _caminhoBanco;
        public CarroRepositorio()
        {
           _caminhoBanco = Banco.BuscarCaminhoBanco(nameof(Carros));
        }

        private void Salvar()
        {
            String dados = JsonConvert.SerializeObject(_carros);

            File.WriteAllText(_caminhoBanco, dados);
        }

        public void Adicionar(Carros carro)
        {
            _carros.Add(carro);
            Salvar();
        }

        public void Remover(Carros carro)
        {
            _carros.Remove(carro);
            Salvar();
        }

        public void Atualizar(Carros carro)
        {
            Carros carroRegistrado = BuscarPelaPlaca(carro.Placa);
            if (carroRegistrado is not null)
            {
                carroRegistrado.Placa = carro.Placa;
                carroRegistrado.Id = carro.Id;
                carroRegistrado.Cor = carro.Cor;
                carroRegistrado.Modelo = carro.Modelo;
                carroRegistrado.Marca = carro.Marca;
                carroRegistrado.Ativo = carro.Ativo;
                carroRegistrado.DataHoraOcupacao = carro.DataHoraOcupacao;
                carroRegistrado.DataHoraDesocupacao = carro.DataHoraDesocupacao;

                Salvar();

            }
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

        public Carros Buscar(Predicate<Carros> query)
        {
            return _carros.Find(query);
            //Carros carros = _carros.Find(carros => carros.Id == id);

            //return carros;
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
