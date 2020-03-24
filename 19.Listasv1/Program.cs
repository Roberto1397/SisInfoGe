using System;
using System.Collections.Generic;

namespace _19.Listasv1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mats =new List<string>(){
                "Calculo I",
                "Redaccion Avanzada",
                "Introduccion a la Ingenieria"
            };

            mats.Add("Matematicas Discretas");
            mats.Add("Compiladores e Interpretes");

            Imprime(mats);

            string[] mopt={
                "Sistemas de Info Geo(op)",
                "Seguridad en Redes (op)",
                "Topico Selectos de Redes (op9"
            };
            mats.AddRange(mopt);
            Imprime(mats);

            mats.Reverse();
            Imprime(mats);

            mats.Sort();
            Imprime(mats);

            Console.WriteLine("Buscar una materia que tenga la palabra Discretas");
            string mat =mats.Find(x=>x.Contains("Discretas"));
            Console.WriteLine(mat);

            //buscar todas las ocurrencias en la lista
            Console.WriteLine("Buscar todas las materias que contengan (op)");
            var ms =mats.FindAll(x=>x.Contains("(op)"));
            Imprime(ms);
        }

        static void Imprime(List<string> lista){
            Console.WriteLine("\n\n");
            foreach(string m in lista)
                Console.WriteLine(m);
            Console.WriteLine(lista.Count);

        }
    }
}
