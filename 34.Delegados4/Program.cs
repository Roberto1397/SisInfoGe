using System;

namespace _34.Delegados4
{
    public delegate T Suma<T>(T param1, T param2); //Declara delegado generico
    
    class Program
    {
        static void Main(string[] args)
        {
            Suma<int> d1 = Sumar;//Delegado a metodo Sumar de tipo int con parametros int,int
            Console.WriteLine(d1(10,20));

            Suma<string> d2 = Concatenar; //Delegado a metodo Concatenar de tipo stringcon parametros strng,string
            Console.WriteLine(d2("Mi mama me","mima mi mama"));

            Console.WriteLine();
        }
        public static int Sumar(int a,int b)
        {
            return a + b;
        }
        public static string Concatenar(string a, string b)
        {
            return a + b;
        }
    }
}
