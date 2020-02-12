using System;

namespace _03.areatriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double bass,altura,area;

            Console.WriteLine("Programa para calcular el area de un triangulo");

            Console.WriteLine("Dame la base : ");
            bass=double.Parse(Console.ReadLine());
            Console.WriteLine("Dame la altura : ");
            altura=double.Parse(Console.ReadLine());

            area = (bass*altura) / 2;

            Console.WriteLine($"El area es {area}");
            Console.ReadLine();


        }
    }
}
