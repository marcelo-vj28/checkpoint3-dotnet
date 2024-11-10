using CP3.MVC.Application.Dtos;
using CP3.MVC.Domain.Entities;
using CP3.MVC.Domain.Interfaces;
using CP3.MVC.MVC.Application.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CP3.MVC.Application.Services
{
    public class BarcoApplicationService : IBarcoApplicationService
    {
        private readonly IBarcoRepository _barcoRepository;

        public BarcoApplicationService(IBarcoRepository barcoRepository)
        {
            _barcoRepository = barcoRepository;
        }

        public void Adicionar(BarcoDto barcoDto)
        {
            var barco = new BarcoEntity
            {
                Nome = barcoDto.Nome,
                Modelo = barcoDto.Modelo,
                Ano = barcoDto.Ano,
                Tamanho = barcoDto.Tamanho
            };
            _barcoRepository.Adicionar(barco);
        }

        public void Atualizar(BarcoDto barcoDto)
        {
            var barco = new BarcoEntity
            {
                Id = barcoDto.Id,
                Nome = barcoDto.Nome,
                Modelo = barcoDto.Modelo,
                Ano = barcoDto.Ano,
                Tamanho = barcoDto.Tamanho
            };
            _barcoRepository.Atualizar(barco);
        }

        public void Remover(int id)
        {
            _barcoRepository.Remover(id);
        }

        public BarcoDto ObterPorId(int id)
        {
            var barco = _barcoRepository.ObterPorId(id);
            return barco == null ? null : new BarcoDto
            {
                Id = barco.Id,
                Nome = barco.Nome,
                Modelo = barco.Modelo,
                Ano = barco.Ano,
                Tamanho = barco.Tamanho
            };
        }

        public IEnumerable<BarcoDto> ObterTodos()
        {
            var barcos = _barcoRepository.ObterTodos();
            return barcos.Select(barco => new BarcoDto
            {
                Id = barco.Id,
                Nome = barco.Nome,
                Modelo = barco.Modelo,
                Ano = barco.Ano,
                Tamanho = barco.Tamanho
            });
        }
    }
}