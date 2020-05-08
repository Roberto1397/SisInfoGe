using System;
using System.Threading;

namespace _30.Threads4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hilo principal iniciado");;
            //Crear Threads con nombre
            Thread t1 = new Thread(Metodo1) {Name = "Cliente1"};
            Thread t2 = new Thread(Metodo2) {Name = "Cliente2"};
            Thread t3 = new Thread(Metodo3) {Name = "Cliente3"};

            //Ejecutando Metodos
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Thread principal Terminado");
        }

        static void Metodo1()
        {
            Console.WriteLine("Metodo1 iniciado usando "+ Thread.CurrentThread.Name);
            for(int i=1; i<=5; i++)
                Console.WriteLine("Metodo1 :" + i);
            Console.WriteLine("Metodo Terminado usando " + Thread.CurrentThread.Name);
        }

        static void Metodo2()
        {
            Console.WriteLine("Metodo2 iniciado usando "+ Thread.CurrentThread.Name);
            for(int i=1; i<=5; i++){
                Console.WriteLine("Metodo2 :" + i);
                if(i==3)
                {
                    Console.WriteLine("Iniciando Operacion sobre la Base de Datos");
                    Thread.Sleep(10000);
                    Console.WriteLine("Operacion sobre la Base de Datos Terminada");
                }
            }
            Console.WriteLine("Metodo Terminado usando " + Thread.CurrentThread.Name);
        }

        static void Metodo3()
        {
            Console.WriteLine("Metodo3 iniciado usando "+ Thread.CurrentThread.Name);
            for(int i=1; i<=5; i++)
                Console.WriteLine("Metodo3 :" + i);
            Console.WriteLine("Metodo3 Terminado usando " + Thread.CurrentThread.Name);
        }
    }
}
