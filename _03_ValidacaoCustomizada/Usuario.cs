using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _03_ValidacaoCustomizada
{
    class Usuario
    {
        [Required(ErrorMessage = "O campo é de Preenchimento Obrigatório!")]
        public string Nome { get; set; }
        
        [EmailAddress(ErrorMessage ="errrado")]
        public string Email { get; set; }
        [Required, StringLength(10, MinimumLength = 6)]
        [MinhaValidacao(ErrorMessage ="Errouuuuu")]
        public string Senha { get; set; }
    }
}
