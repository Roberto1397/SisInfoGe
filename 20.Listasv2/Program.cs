using System;
using System.Collections.Generic;

namespace _20.Listasv2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear una lista de tipo Pieza
            List<Pieza> mp = new List <Pieza>();
            //Agregar elementos a la lista
            mp.Add(new Pieza(1234,"tuerca de rosca interior"));
            mp.Add(new Pieza(5678,"tornillo cabeza grande"));
            mp.Add(new Pieza(9345,"bateria 12v"));
            //Agregar un rango de elementos
            var proveedor = new List<Pieza>(){
                new Pieza(8888,"tornillo de cabeza peueña"),
                new Pieza(9999,"cables para pasar corriente"),
                new Pieza(6666,"tridente del diablo")
            };

            mp.AddRange(proveedor);
            mp.ForEach(p=>Console.WriteLine(p.ToString()));

            //Eliminar el ultimo elemento de la lista
            mp.RemoveAt(mp.Count-1);

            //Insertat un elemento en la 2 posicion
            Console.WriteLine("Insertar un elemento en la 2 posicion");
            mp.Insert(1,new Pieza(2222,"caja de 8 velocidades"));
            mp.ForEach(p=>Console.WriteLine(p.ToString()));

            //Buscar todas las piezas que tengan 
            Console.WriteLine("Piezas que contienen tornillo");
            var t=mp.FindAll(x=>x.Nombre.Contains("tornillo"));
            t.ForEach(p=>Console.WriteLine(p.ToString()));

            Console.WriteLine("Piezas con id > 5000");
            var t1=mp.FindAll(x=>x.Id>5000);
            t1.ForEach(p=>Console.WriteLine(p.ToString()));
        }
    }
}
