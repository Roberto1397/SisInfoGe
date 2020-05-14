using System;

namespace _35.Delegados5
{
    public delegate void MiDelegado(string msj);
    
    class Program
    {
        static void Main(string[] args)
        {
            MiDelegado del;// Se invoca al delegado

            Console.Clear();

            del = ClaseA.MetodoA;
            Invocadelegado(del);//Se invoca al delegado

            del = ClaseB.MetodoB;
            Invocadelegado(del);//Se invoca el delegado

            del = (string msj) => Console.WriteLine($"Llamado expresion Lambada {msj}");
            Invocadelegado(del); //Se invoca al delegado

            Console.WriteLine();
        }
        //Este metodo recibe como parametro un delegado
        static void Invocadelegado(MiDelegado del){
            del("Hola Mundo");//Se invoca al delegado
        }
    }

    class ClaseA{
        public static void MetodoA(string msj){
            Console.WriteLine($"Llamando MetodoA de ClaseA : {msj}");
        }
    }
    class ClaseB{
        public static void MetodoB(string msj){
            Console.WriteLine($"Llamando MetodoB de ClaseB : {msj} ");
        }
    }
}
