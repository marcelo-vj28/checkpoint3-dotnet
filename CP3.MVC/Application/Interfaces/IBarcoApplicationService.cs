using CP3.MVC.Application.Dtos;
using CP3.MVC.Domain.Entities;
using System.Collections.Generic;

namespace CP3.MVC.MVC.Application.Interfaces
{
    public interface IBarcoApplicationService
    {
        void Adicionar(BarcoDto barcoDto);
        void Atualizar(BarcoDto barcoDto);
        void Remover(int id);
        BarcoDto ObterPorId(int id);
        IEnumerable<BarcoDto> ObterTodos();
    }
}