using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaAppVS.Models {
    public class CadastrarUsuario
    {

        [Key]
        public int Id {get;set;}

        [Required(ErrorMessage ="O campo Email é obrigatório.")]
        public string Email { get; set; }

       /* [StringLength(60, MinimumLength =3, ErrorMessage = "O campo Nome precisa ter no mínimo 3 caractéres.")]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; } */

        [Range (8,15, ErrorMessage ="A senha precisa ter de 8 á 15 dígitos.")]
        [Required(ErrorMessage ="O campo Senha é obrigatório.")]
        public string Senha { get; set; }

        [Range(8, 15, ErrorMessage = "A senha precisa ter de 8 á 15 dígitos.")]
        [Required(ErrorMessage = "O campo Repetir Senha é obrigatório.")]
        [Display(Name = "Repetir Senha")]
        public string RepetirSenha { get; set; }
    }
}
