using System;

namespace _13.Vectorestadisticas
{
     class Program
    {
        static void Main(string[] args)
        {
            int n;
            double menor=0,mayor=0,suma=0,prom=0,varianza=0,sumav=0,desv=0;
            Console.WriteLine($"Dame el total de elementos");
            n = int.Parse(Console.ReadLine());
            double[] A = new double[n];
            //Pide los datos
            for(int i=0; i<n; i++){
                Console.WriteLine($"Valor del {i} elemento de A ");
                A[i] = double.Parse(Console.ReadLine());
                suma+=A[i];
             }
            //mayor
             for(int i=0; i<n; i++){
                if(mayor<A[i])
                    mayor=A[i];
             }
            //menor
            menor=A[0];
            for(int i=0; i<n; i++){
                if(menor>A[i])
                    menor=A[i];
             }
            //Promedio
            prom=suma/n;
            //Varianza
            for(int i=0; i<n; i++){
                //sumav=A[i]-prom;
                sumav+=Math.Pow(A[i]-prom,2);
             }
            varianza=sumav/(n-1);
            desv=Math.Sqrt(varianza);



             Console.WriteLine("Elemntos del arreglo\n ");
             imprime(A);
             Console.WriteLine($"El numero menor de todos los elementos es: {menor}");
             Console.WriteLine($"El numero mayor de todos los elementos es: {mayor}");
             Console.WriteLine($"El Promedio: {prom}");
             Console.WriteLine($"La Varianza: {varianza}");
             Console.WriteLine($"Desviacion Estandar {desv}\n");

        }

        static void imprime(double [] v){
            for(int i=0; i<v.Length; i++){
                Console.Write($"{v[i]} ");
                
            }Console.WriteLine();
        }
    }
}