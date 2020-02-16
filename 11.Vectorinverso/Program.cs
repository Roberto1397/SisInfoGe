using System;

namespace _11.Vectorinverso
{
     class Program
    {
        static void Main(string[] args)
        {
            const int MAX=15;
            int aux = MAX-1;
            double[] A = new double[MAX];
            double[] B = new double[MAX];
            Random aleatorio = new Random();
            //Generar numeros aleatorios 
            for(int i=0; i<MAX; i++){
                A[i] = aleatorio.Next(1,50);
            }


             Console.WriteLine("\nLos 15 numeros aleatorios son:");
             imprime(A);
             for(int i=0; i<MAX; i++){
                B[aux] = A[i];
                aux--;
            }
            Console.WriteLine("\nLos 15 numeros aleatorios en inverso son:");
             imprime(B);
           
        }

        static void imprime(double [] v){
            for(int i=0; i<v.Length; i++){
                Console.Write($"{v[i]} ");
                
            }Console.WriteLine();
        }
    }
}