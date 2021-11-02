using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
{

}

namespace _02_Validacao
{
    class Usuario
    {
        
        [Required(ErrorMessage ="O campo é de Preenchimento Obrigatório!")]
        public string Nome { get; set; }
        [Required(ErrorMessageResourceType =typeof(Idioma.Linguagem),ErrorMessageResourceName = "MSG_OBRIGATORIO")]
        [EmailAddress]
        public string Email { get; set; }
        [Required, StringLength(10,MinimumLength = 6)]
        public string Senha { get; set; }
    }
}
