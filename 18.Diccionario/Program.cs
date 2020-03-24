using System;
using System.Collections.Generic;

namespace _18.Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definimos el diccionario y reservamos espacio en memoria para el
            //Dictionary<string,string> midic = new Dictionary<string,string>();
            SortedDictionary<string,string> midic = new SortedDictionary<string,string>();
            //Agregar entradas al diccionario
            midic.Add("txt","Archivo de texto");
            midic.Add("jpg","Archivo de imagen");
            midic.Add("mp3","Archivo de sonido");
            midic.Add("htm","Archivo HTML");
            midic.Add("exe","Archivo ejecutable de windows");
            midic.Add("lll","Archivo de tipo desconocido");
            //Acceder a un elemento en base a la llave
            Console.WriteLine(midic["htm"]);
            //verificar si una llave existe, si no agregarla
            if(midic.ContainsKey("elf"))
                Console.WriteLine("La llave ya existe");
            else
                midic.Add("elf","Archivo ejecutable de linux");
            //Borrar una entrada si la llave existe
            if(midic.ContainsKey("lll"))
                midic.Remove("lll");
            //modificar un valor del diccionario en base a la llave
            midic["htm"]="Archivo de texto HTML";
            //recorrer el diccionario e imprimir la llave y su valor
            foreach(KeyValuePair<string,string> val in midic)
                Console.WriteLine($"{val.Key} - {val.Value}");
           //imprimir solo las llaves del diccionario
           foreach(string llave in midic.Keys)
                Console.WriteLine(llave);
            //imprimir solo los valores de diccionario
            foreach(string valor in midic.Values)
                Console.WriteLine(valor);
            //Borrar todas las entradas del diccionario
            midic.Clear();
        }
    }
}
