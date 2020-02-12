using System;

namespace _04.ciclos
{
    class Program
    {
        static int Main(string[] args)
        {
            int op, c=0, suma=0;
            if(args.Length==0) Menu();

            op= int.Parse(args[0]);

            Console.Clear();
            switch (op)
            {
                case 1: {
                    c=1;
                    suma=0;
                    while(c<=100) {
                        Console.WriteLine($"{c} ");
                        suma+=c;
                        c++;
                    }
                Console.WriteLine($"\n\nLa suma es {suma} \n");
            }break;

                    case 2: {
                        c=100;
                        suma=0;
                        while(c>=1) {
                            Console.WriteLine($"{c} ");
                            suma+=c;
                            c--;
                        }
                        Console.WriteLine($"\n\nLa suma es {suma} \n");
                    }break;
                    
                    case 3: {
                        suma=0;
                        for(c=50; c<=200; c++) {
                            Console.WriteLine($"{c} ");
                            suma+=c;
                        }
                        Console.WriteLine($"\n\nLa suma es {suma} \n");
                    }break;

                    case 4: {
                        suma=0;
                        for(c=2; c<=100; c+=2) {
                            Console.WriteLine($"{c} ");
                            suma+=c;
                        }
                        Console.WriteLine($"\n\nLa suma es {suma} \n");
                    }break;

                    case 5: {
                        suma=0;
                        for(c=99; c>=1; c-=2) {
                            Console.WriteLine($"{c} ");
                            suma+=c;
                        }
                        Console.WriteLine($"\n\nLa suma es {suma} \n");
                    }break;

                    case 6: {
                        c=272;
                        suma=0;
                        while(c>=40) {
                            Console.WriteLine($"{c} ");
                            c=4;
                        }
                        Console.WriteLine($"\n\nLa suma es {suma} \n");
                    }break;

            default: Console.WriteLine("Opcion invalida"); break;
        }
        return 0;
    }
    
    static void Menu() {
        Console.Clear();
        Console.WriteLine("Programa sobre el uso de estructuras de control");
        Console.WriteLine("[1] Numeros del 1 al 100 con ciclo while");
        Console.WriteLine("[2] Numeros del 100 al 1 con ciclo do..while");
        Console.WriteLine("[3] Numeros del 50 al 200 con ciclo for");
        Console.WriteLine("[4] Numeros del 2 al 100 solo los pares con ciclo for");
        Console.WriteLine("[5] Numeros del 99 al 1 solo los impares con cilo for");
        Console.WriteLine("[6] Numeros del 272 al 40 en decrementos de 4 con ciclo while");
    }
  }
}





