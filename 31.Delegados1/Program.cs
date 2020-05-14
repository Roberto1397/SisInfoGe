using System;

namespace _31.Delegados1
{
    //Declarando un delegado 
    public delegate void MiDelegado(string msj);
    
    class Program
    {
        static void Main(string[] args)
        {
            MiDelegado d;//se instancia delegado

            Console.Clear();

            //Delegado invoca el metodo Mensaje1 de la clase Mensajes
            d = Mensajes.Mensaje1;
            d("Juan");

            //Delegado invoca al metodo Mensajes2 de la clase Mensajes
            d = Mensajes.Mensaje2;
            d("Jose");

            //Delegado invoca a una expresion lambada
            d = (string msj) => Console.WriteLine($"{msj} - paga todo que no pare la fiesta");
            d("Carlos");

            Console.WriteLine();
        }
    }

    public class Mensajes{
        public static void Mensaje1(string msj){
            Console.WriteLine($"{msj} - lleva el pastel");
        }
        public static void Mensaje2(string msj){
            Console.WriteLine($"{msj} - fue el culpable se cancela la fiesta");
        }
    }
}
