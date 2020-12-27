using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaAppVS.Models
{
    public class Filme
    {

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo Título é obrigatório.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O título precisa ter no mínimo 3 caracteres.")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Formato inválido")]
        [Display(Name = "Data de Lançamento")]
        [Required(ErrorMessage = "O campo Data de lançamento é obrigatório")]
        public DateTime DataLancamento { get; set; }

        // [RegularExpression(@"^[A-Z]+[a-zA-Z]$")]
        [Required(ErrorMessage = "O campo Gênero é obrigatório.")]
        [Display(Name = "Gênero")]
        public string Genero { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior que zero")]
        [Required(ErrorMessage = "O campo Valor é obrigatório")]
        public decimal Valor { get; set; }

        [Display(Name = "Avaliação")]
        [RegularExpression(@"[1-5]$")]
        [Required(ErrorMessage = "O valor informado no campo Avaliação deve ser entre 1-5")]
        public int Avaliacao { get; set; }

    }
}
