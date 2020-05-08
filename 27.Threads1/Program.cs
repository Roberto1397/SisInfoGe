using System;
using System.Threading;

namespace _27.Threads1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nombramos al Thread principal
            Thread.CurrentThread.Name="Principal";

            //Creamos 2 threads
            Thread t1 = new Thread(Imprime);
            Thread t2 = new Thread(Imprime);

            //Damos nombre a los threads que creamos
            t1.Name="Thread1";
            t2.Name="Thread2";

            //Invocamos los threads
            t1.Start();
            t2.Start();

            //Invocamos Imprime desde Thread prncipal
            Imprime();

            Console.WriteLine("Saludos desde Main, se ha terminado todo");
        }

        static void Imprime(){
            for(int i=0; i<10; i++){
                Console.WriteLine($"Imprime . {i} desde {Thread.CurrentThread.Name}");
                Thread.Sleep(100);
            }
        }
    }
}
