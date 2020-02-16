using System;

namespace _12.VectoresMultiplica
{
     class Program
    {
        static void Main(string[] args)
        {
            const int MAX=10;
            int aux=MAX-1;
            double[] A = new double[MAX];
            double[] B = new double[MAX];
            double[] C = new double[MAX];

            //Pide los datos
            for(int i=0; i<MAX; i++){
                Console.WriteLine($"Valor del {i} elemento de A ");
                A[i] = double.Parse(Console.ReadLine());
                Console.WriteLine($"Valor del {i} elemento de B ");
                B[i] = double.Parse(Console.ReadLine());
             }


             Console.WriteLine("Datos de A ");
             imprime(A);
             Console.WriteLine("Datos de B ");
             imprime(B);
             for(int i=0; i<MAX; i++){
                C[i]=A[i] * B[aux];
                aux--;
             }
             Console.WriteLine("Multiplicacion de A*B ");
             imprime(C);
           
        }

        static void imprime(double [] v){
            for(int i=0; i<v.Length; i++){
                Console.Write($"{v[i]} ");
                
            }Console.WriteLine();
        }
    }
}