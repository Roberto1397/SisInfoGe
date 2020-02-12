using System;

namespace _06.tablas
{
    class Program
    {
         static int Main(string[] args)
        {
            int op, r=0, num1=0, num2;
            if(args.Length==0) Menu();

            op= int.Parse(args[0]);

            Console.Clear();
            switch (op)
            {
                case 1: {
                    num1=5; num2=0; r=0;
                   // while(num2<=10) {
                        
                        for(num2=1; num2<=10; num2++)
                        {
                            r = num1 * num2;

                            Console.WriteLine($"{r} ");
                        }
                        Console.ReadLine();
                   // }
               // Console.WriteLine($"\n\nLa suma es {suma} \n");
            }break;

            default: Console.WriteLine("Opcion invalida"); break;
        }
        return 0;
    }
    
    static void Menu() {
        Console.Clear();
        Console.WriteLine("Programa de tablas de multiplicar");
        Console.WriteLine("[1] tabla de multiplicar específica hasta cierto número");
        Console.WriteLine("[2] tablas deseadas hasta el número deseado");
    }
  }
}
