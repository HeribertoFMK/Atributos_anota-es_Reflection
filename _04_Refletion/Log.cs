using System.Collections.Generic;
using System.Reflection;
using _04_Reflection.Modelo;

namespace _04_Reflection
{
    class Log
    {
        public static List<object> Objetos = new List<object>();

        public static void Gravar(object obj)
        {
            Objetos.Add(obj);
        }
        public static void ApresentarLog()
        {
            foreach(object obj in Objetos)
            {
                System.Console.WriteLine("------------Nome Classe: {0}--------", obj.GetType().Name);
                foreach(var prop in obj.GetType().GetProperties())
                {
                    System.Console.WriteLine(prop.Name +" : " + prop.GetValue(obj));
                }
            }
        }
        /*public static List<Usuario> Usuarios = new List<Usuario>();
        public static void GravarUsuario(Usuario usuario)
        {
            Usuarios.Add((Usuario)usuario.Clone());
        }
        public static List<Carro> Carros = new List<Carro>();
        public static void GravarUsuario(Carro carro)
        {
            Carros.Add(carro);
        }
        public static void ApresentarLog()
        {
            foreach(Usuario usuario in Usuarios)
            {
                System.Console.WriteLine("Nome: {0}, Email: {1},Senha:{2}", usuario.Nome, usuario.Email, usuario.Senha);
            }
            foreach (Carro carro in Carros)
            {
                System.Console.WriteLine("Marca: {0}, Modelo: {1}", carro.Marca,carro.Modelo);
            }
        }*/
    }
}
