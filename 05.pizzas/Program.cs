using System;

namespace _05.pizzas
{
    class Program
    {
        static int Main(string[] args)
        {
            if(args.Length==0) {
                Menu();
                return 1;
            }
            
            char tam=char.Parse(args[0]);

            string[] ings = args[1].Split("+");
            char cub = char.Parse(args[2]);
            char don = char.Parse(args[3]);

            string tamano="", ingredientes="", cubierta="", donde="";

            if(tam=='P') tamano="Pequeña" ;
            else if(tam== 'M') tamano="Mediana";
            else tamano="Grande";


            foreach (string i in ings){
                switch(char.Parse(i))
                {
                    case 'E': ingredientes+="Extra Queso, "; break;
                    case 'C': ingredientes+="Champinones, "; break;
                    case 'T': ingredientes+="Tomates, "; break;
                    case 'P': ingredientes+="Pina, "; break;
                }

            } 

            if(cub=='D') cubierta="Delgada"; else cubierta="Gruesa";

            if(don=='C') donde="Comer aqui"; else donde="Para llevar";

            Console.Clear();
            Console.WriteLine($"Tamaño:   {tamano}");
            Console.WriteLine($"Ingredientes: {ingredientes}");
            Console.WriteLine($"Cubierta:     {cubierta}");
            Console.WriteLine($"Comer donde:  {donde}.\n\n");
        

            return 0;
        }

        static void Menu() {
            Console.WriteLine("Procesando Pizzas \n");
            Console.WriteLine("Tamaño:       (P)equeña,    (M)ediana o    (G)rande");
            Console.WriteLine("Ingredientes: (E)xtra Queso, (C)hampiñones, (T)omates  (P)ina");
            Console.WriteLine("Cubierta:     (D)elgada O (G)ruesa");
            Console.WriteLine("Comer donde:  (C)omer aqui o (P)ara llevar.\n\n");
            Console.WriteLine("<Tamano> <ing1+ing2...> <cubierta> <Donde>");
        }
    }
}
