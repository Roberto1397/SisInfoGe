using System;

namespace _25.Interfaces1
{
    class Program
    {
        public interface IAnimal{
            string Nombre {get; set;}
            void Llorar();
        }

        class Perro :IAnimal {
            public Perro(string nombre) => Nombre =nombre;
            public string Nombre {get; set;}
            public void Llorar() => Console.WriteLine("Woff Woff!");
        }

        class Gato : IAnimal{
            public Gato(string nombre) => Nombre = nombre;
            public string Nombre {get; set;}
            public void Llorar() => Console.WriteLine("Meow Meow!");
        }

        static void Main(string[] args)
        {
            Perro perro =new Perro("Satueso");
            Console.WriteLine($"El perro {perro.Nombre}");
            perro.Llorar();

            Gato gato =new Gato("Misifuos");
            Console.WriteLine($"El gato {gato.Nombre}");
            gato.Llorar();
        }
    }
}
