using System.ComponentModel.DataAnnotations;

namespace CP3.MVC.Application.Dtos
{
    public class BarcoDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do barco é obrigatório")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O nome deve ter entre 2 e 100 caracteres")]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "O modelo do barco é obrigatório")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O modelo deve ter entre 2 e 100 caracteres")]
        public required string Modelo { get; set; }

        [Range(1900, int.MaxValue, ErrorMessage = "O ano deve ser maior que 1900")]
        public int Ano { get; set; }

        [Range(0.1, double.MaxValue, ErrorMessage = "O tamanho deve ser maior que zero")]
        public double Tamanho { get; set; }
    }
}
