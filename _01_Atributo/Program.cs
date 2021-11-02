using System;

namespace _01_Atributo
{
    class Program
    { 
        [MeuAtributo("Classe",Descricao ="Descrição do Atributo")]
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
