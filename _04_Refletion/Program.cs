using _04_Reflection;
using _04_Reflection.Modelo;
using System;

namespace _04_Refletion
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario()
            {
                Nome = "Jose",
                Email = "hfmk@gmail.com",
                Senha = "12345"

            };
            Log.Gravar(usuario.Clone());


            usuario.Nome = "Jose carlos";
            Log.Gravar(usuario.Clone());

            Carro carro = new Carro() {Marca = "Toyota",Modelo="VEllFire" };
            Log.Gravar(carro);

            Log.ApresentarLog();

            Console.WriteLine("Log gravado");
            Console.ReadKey();

        }
    }
}
