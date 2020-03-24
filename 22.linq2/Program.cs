using System;
using System.Linq;

namespace _22.linq2
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] frutas = new string[] {
               "pera","melon", "sandia","papaya","durazno","platano",
               "manzana","kiwi","pitayas","mango","cereza"
           };

           var qry1 = 
            from f in frutas
            where f.StartsWith("m")
            select f;

            foreach(string f in qry1) 
                Console.WriteLine(f);
            Console.WriteLine($"Total: {qry1.Count()}");

            var qry2 = (from fruta in frutas where fruta.Contains("an") select fruta).ToList();
            
            qry2.ForEach(f=>Console.WriteLine(f));

            Console.WriteLine($"Total: {qry2.Count()}");
        }
    }
}
