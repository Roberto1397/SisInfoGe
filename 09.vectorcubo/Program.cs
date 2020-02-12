using System;

namespace _09.vectorcubo
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX=30;

            double[] A = new double[MAX];
            double[] B = new double[MAX];

            Random aleatorio = new Random();

            //Generar numeros aleatorios 
            for(int i=0; i<MAX; i++){
                A[i] = aleatorio.Next(1,100);
                B[i] = Math.Pow(A[i],3);
             }


             Console.WriteLine("Eleva al cubo 30 elementos en un vector\n ");


             imprime(A);
             imprime(B);

           
        }

        static void imprime(double [] v){
            for(int i=0; i<v.Length; i++){
                Console.Write($"{v[i]} ");
                
            }Console.WriteLine();
        }
    }
}
