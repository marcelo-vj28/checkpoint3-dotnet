using CP3.MVC.Domain.Entities;
using System.Collections.Generic;

namespace CP3.MVC.Domain.Interfaces
{
    public interface IBarcoRepository
    {
        void Adicionar(BarcoEntity barco);
        void Atualizar(BarcoEntity barco);
        void Remover(int id);
        BarcoEntity ObterPorId(int id);
        IEnumerable<BarcoEntity> ObterTodos();
    }
}
