using System;
using System.Collections.Generic;
using System.Linq;

namespace _23.linq3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> grupo = new List<Estudiante>();

            grupo.Add(new Estudiante {Id=1234,Nombre="Jose",
            Ciudad="Zacatecas",Calle="1a de Mayo",Cals=new List<int>{90,80,70,60}});

            grupo.Add(new Estudiante {Id=4567,Nombre="Maria",
            Ciudad="Fresnillo",Calle="Benito Juarez",Cals=new List<int>{90,50,60,60}});

            grupo.Add(new Estudiante {Id=8910,Nombre="Miguel",
            Ciudad="Jerez",Calle="Garcia Salinas",Cals=new List<int>{50,50,50,40}});

            grupo.Add(new Estudiante {Id=5353,Nombre="Lourdes",
            Ciudad="Zacatecas",Calle="El Vergel",Cals=new List<int>{100,100,100,90}});

            //Imprimir todos los datos
            Console.WriteLine("\nTodo de Todo:");
            grupo.ForEach(est=>Console.WriteLine(est.ToString()));

            //Todos pero ordenados por Nombre
            var q1 = (from est in grupo orderby est.Nombre select est).ToList();
            Console.WriteLine("\nTodo ordenado por nombre\n");
            q1.ForEach(est=>Console.WriteLine(est.ToString()));

            //Nada mas los de zacatecas
            var q2 = (from est in grupo where est.Ciudad == "Zacatecas" select est).ToList();
            Console.WriteLine("\nNada mas los de zacatecas\n");
            q2.ForEach(est=>Console.WriteLine(est.ToString()));

            //El nombre de los estudiantes con promedio arriba de 80
            var q3 =
                (from est in grupo
                where est.Cals.Average()>80
                select new {nombre = est.Ciudad, promedio=est.Cals.Average()}).ToList();
            Console.WriteLine("\nNombre y Promedio de los mayores a 70\n");
            q3.ForEach(est=>Console.WriteLine($"Nombre:{est.nombre},Promedio:{est.promedio}"));

            var q4 = from est in grupo group est by est.Ciudad;
            Console.WriteLine("\nEstudiantes agrupados por ciudad\n");
            foreach(var ciudad in q4){
                Console.WriteLine(ciudad.Key);
                foreach(var est in ciudad)
                    Console.WriteLine(est.ToString());}
        }
    }
}
