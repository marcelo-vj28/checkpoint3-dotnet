using CP3.MVC.Domain.Entities;
using CP3.MVC.Domain.Interfaces;
using CP3.MVC.Infrastructure.Data.AppData;
using System.Collections.Generic;
using System.Linq;

namespace CP3.MVC.Infrastructure.Repositories
{
    public class BarcoRepository : IBarcoRepository
    {
        private readonly List<BarcoEntity> _barcos = new List<BarcoEntity>();

        public void Adicionar(BarcoEntity barco)
        {
            barco.Id = _barcos.Count > 0 ? _barcos.Max(b => b.Id) + 1 : 1;
            _barcos.Add(barco);
        }

        public void Atualizar(BarcoEntity barco)
        {
            var barcoExistente = _barcos.FirstOrDefault(b => b.Id == barco.Id);
            if (barcoExistente != null)
            {
                _barcos.Remove(barcoExistente);
                _barcos.Add(barco);
            }
        }

        public void Remover(int id)
        {
            var barco = _barcos.FirstOrDefault(b => b.Id == id);
            if (barco != null)
            {
                _barcos.Remove(barco);
            }
        }

        public BarcoEntity ObterPorId(int id)
        {
            return _barcos.FirstOrDefault(b => b.Id == id);
        }

        public IEnumerable<BarcoEntity> ObterTodos()
        {
            return _barcos;
        }
    }
}
