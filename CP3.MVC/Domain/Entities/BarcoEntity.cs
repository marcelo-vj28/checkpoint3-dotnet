using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CP3.MVC.Domain.Entities
{
    public class BarcoEntity
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Modelo { get; set; }
        public int Ano { get; set; }
        public double Tamanho { get; set; }
    }
}
