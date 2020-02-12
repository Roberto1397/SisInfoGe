using System;

namespace _08.vectoraleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX=15;

            int[] A = new int[MAX];
            int[] B = new int[MAX];
            int[] C = new int[MAX];

            Random aleatorio = new Random();

            //Generar numeros aleatorios 
            for(int i=0; i<MAX; i++){
                A[i] = aleatorio.Next(1,100);
                B[i] = aleatorio.Next(1,100);
                C[i] = A[i] + B[i];
             }

             imprime(A);
             imprime(B);
             imprime(C);

            Console.WriteLine("Suma de 2 vectores aleatorios con 15 elementos ");
        }

        static void imprime(int[] v){
            for(int i=0; i<v.Length; i++){
                Console.Write($"{v[i]} ");
                Console.WriteLine();
            }
        }
    }
}
