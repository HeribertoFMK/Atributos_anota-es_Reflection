using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _03_ValidacaoCustomizada
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Jose", Email = "jose", Senha = "123" };
            ValidationContext contexto = new ValidationContext(usuario);
            List<ValidationResult> resultados = new List<ValidationResult>();

            if (Validator.TryValidateObject(usuario, contexto, resultados) == false)
            {
                foreach (var erro in resultados)
                {
                    Console.WriteLine(erro.ErrorMessage);
                }

            }
            Console.ReadKey();
        }
    }
}
