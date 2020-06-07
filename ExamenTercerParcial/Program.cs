using System;
using System.ComponentModel;

namespace ExamenTercerParcial
{
    public struct Empleado{ 
        public string Ubicacion { get; } 
        public string Area { get; } 
        public int Edad { get; } 
        public double Salario { get; } 

        public readonly string Rfc { get; } 
        public readonly string Nombre { get; } 

        public Empleado( string rfc,string nombre, int edad, double salario, string area,string ubicacion) 
        { 
  
            this.Nombre = nombre; 
            this.Area = area;
            this.Rfc = rfc; 
            this.Edad = edad; 
            this.Ubicacion = ubicacion;
            this.Salario = salario;
        }
        
    } 

    public class EmpleadoPosicion 
    {
        public string Ubicacion { get; } 
        public string Area { get; } 
        public int Edad { get; } 
        public double Salario { get; } 
        public string Rfc { get; } 
        public string Nombre { get; } 

        public EmpleadoPosicion(string rfc, string nombre, int edad, double salario,string area,string ubicacion) 
        => (Rfc, Nombre,Edad,Salario,Area,Ubicacion) = (rfc, nombre,edad,salario,area,ubicacion);

        public void Deconstruct(out string rfc,out string nombre,out int edad,out double salario,out string area,out string ubicacion)  =>
        (rfc, nombre,edad,salario,area,ubicacion) = (Rfc, Nombre,Edad,Salario,Area,Ubicacion);

        public void Dispose() { Console.WriteLine("Releasing resources"); }
    }
    
    class Program 
    {
        static void Main(string[] args)
        {
            //Procesamos los argumentos pasados al programa
            if(args.Length < 1) Menu();
            else{
                //Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                switch(int.Parse(args[0])){
                    case 1: MiembroLectura(); break;
                    case 2: ExpresioneSwitch(); break;
                    case 3: PatronesPropie(); break;
                    case 4: PatronesPTupla(); break;
                    case 5: PatronesPosicion(); break;
                    case 6: DeclaracionesUsing(); break;
                    case 7: FuncionesLocEta(); break;
                    case 8: InidcesRang(); break;
                    default: Console.WriteLine("Opcion invalida ..."); break;
                }
            }  Console.ForegroundColor =ConsoleColor.White;
        }
        static void Menu(){
            //Menu de opciones
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Características nuevas en C#8 ...... ");
            Console.WriteLine("[ 1 ] Miembros de solo lectura .....");
            Console.WriteLine("[ 2 ] Expresiones switch............");
            Console.WriteLine("[ 3 ] Patrones de propiedades ......");
            Console.WriteLine("[ 4 ] Patrones de tupla ............");
            Console.WriteLine("[ 5 ] Patrones posicionales ........");
            Console.WriteLine("[ 6 ] Declaraciones Using ..........");
            Console.WriteLine("[ 7 ] Funciones locales estáticas ..");
            Console.WriteLine("[ 8 ] Inidces y rangos .............");
            Console.ForegroundColor = ConsoleColor.Black;
        }
        static void MiembroLectura(){
            Empleado empleado = new Empleado("A1","Josue Roberto Marquez Valdez",23,1500,"Administracion","Zacatecas");
            Console.WriteLine($"Nombre: {empleado.Rfc}");
            Console.WriteLine($"Nombre: {empleado.Nombre}");
            Console.WriteLine($"Edad: {empleado.Edad}");     
            Console.WriteLine($"Salario: {empleado.Salario}");
            Console.WriteLine($"Area: {empleado.Area}");
            Console.WriteLine($"Ubicacion: {empleado.Ubicacion}");
               
        }

        static void ExpresioneSwitch(){
            Console.WriteLine("\tExpresiones switch");   
            Empleado empleado = new Empleado("A2","Humberto Esparza Lopez",23,2800,"Recurso Humanos","Loreto");   
            switch (empleado.Ubicacion)
            {
                case "Zacatecas":
                    Console.WriteLine($"Nombre: {empleado.Rfc}");
                    Console.WriteLine($"Nombre: {empleado.Nombre}");
                    Console.WriteLine($"Edad: {empleado.Edad}");     
                    Console.WriteLine($"Salario: {empleado.Salario}");
                    Console.WriteLine($"Area: {empleado.Area}");
                    Console.WriteLine($"Ubicacion: {empleado.Ubicacion}");
                break;
                case "Loreto":
                    Console.WriteLine($"Nombre: {empleado.Rfc}");
                    Console.WriteLine($"Nombre: {empleado.Nombre}");
                    Console.WriteLine($"Edad: {empleado.Edad}");     
                    Console.WriteLine($"Salario: {empleado.Salario}");
                    Console.WriteLine($"Area: {empleado.Area}");
                    Console.WriteLine($"Ubicacion: {empleado.Ubicacion}");
                break;
                case "Fresnillo":
                    Console.WriteLine($"Nombre: {empleado.Rfc}");
                    Console.WriteLine($"Nombre: {empleado.Nombre}");
                    Console.WriteLine($"Edad: {empleado.Edad}");     
                    Console.WriteLine($"Salario: {empleado.Salario}");
                    Console.WriteLine($"Area: {empleado.Area}");
                    Console.WriteLine($"Ubicacion: {empleado.Ubicacion}"); 
                break;
                default:   Console.WriteLine("Empleado desconocido ..."); break;
            }
        }

        static void PatronesPropie(){
            Console.WriteLine("[ 3 ] Patrones de propiedades ......");
            Empleado empleado = new Empleado("A2","Humberto Esparza Lopez",23,2800,"Recursos Humanos","Loreto"); 
            switch (empleado.Ubicacion)
            {
                case "Zacatecas":
                    Console.WriteLine($"Nombre: {empleado.Nombre}");
                    Console.WriteLine($"Bono: {empleado.Salario*0.5}");               
                break;
                case "Loreto":
                    Console.WriteLine($"Nombre: {empleado.Nombre}");
                    Console.WriteLine($"Bono: {empleado.Salario*1.5}"); 
                break;
                case "Fresnillo":
                    Console.WriteLine($"Nombre: {empleado.Nombre}");
                    Console.WriteLine($"Bono: {empleado.Salario*1}"); 
                break;
                default:   Console.WriteLine($"Nombre: {empleado.Nombre}");
                Console.WriteLine($"Bono: {empleado.Salario*0.7}"); break;
            }
        }
        static string Tupla(string Ubicacion, string Area)
        => (Ubicacion, Area) switch
        {
            ("Zacatecas", "Administracion") => "Aumento de sueldo",
            ("Loreto", "Recursos Humanos") => "Una semana mas de vaciones",
            ("Fresnillo", "Administracion") => "Obtienen un bono",
            (_, _) => "Sin beneficios"
        };
        static string PatronesPosicion(string Ubicacion, string Area)
        => (Ubicacion, Area) switch
        {
            ("Zacatecas", "Administracion") => "Aumento de sueldo",
            ("Loreto", "Recursos Humanos") => "Una semana mas de vaciones",
            ("Fresnillo", "Administracion") => "Obtienen un bono",
            (_, _) => "Sin beneficios"
        };
        static void PatronesPTupla(){
            Console.WriteLine("[ 4 ] Patrones de tupla ............");        
            Empleado empleado = new Empleado("A2","Humberto Esparza Lopez",23,2800,"Recursos Humanos","Loreto"); 
            Console.WriteLine($"Nombre: {empleado.Nombre}");
            Console.WriteLine(Tupla(empleado.Ubicacion,empleado.Area));  
        }

        static void PatronesPosicion(){
            Console.WriteLine("[ 5 ] Patrones posicionales ........");
            EmpleadoPosicion empleado = new EmpleadoPosicion("A2","Humberto Esparza Lopez",23,2800,"Recursos Humanos","Loreto");
            Console.WriteLine($"Nombre: {empleado.Nombre}");
            Console.WriteLine(PatronesPosicion(empleado.Ubicacion,empleado.Area));  
        }
        public class MyDisposable : IDisposable
        {
            public void Dispose(){}
        }
        static void DeclaracionesUsing(){
            Console.WriteLine("[ 6 ] Declaraciones Using .........."); 
            using (var myDisposable = new MyDisposable())
            {
                EmpleadoPosicion empleado = new EmpleadoPosicion("A2","Humberto Esparza Lopez",23,2800,
                "Recursos Humanos","Loreto");
                Console.WriteLine($"Rfc: {empleado.Rfc} Nombre: {empleado.Nombre} Edad: {empleado.Edad}");
            }
            

        }
        static double M(double x,double y)
        {
            return Add(x, y);

            static double Add(double sueldo, double bono) => sueldo + bono;
        }
        static void FuncionesLocEta(){
            Console.WriteLine("[ 7 ] Funciones locales estáticas ..");  
            EmpleadoPosicion empleado = new EmpleadoPosicion("A2","Humberto Esparza Lopez",23,2800,
                "Recursos Humanos","Loreto");
            
            Console.WriteLine($"El sueldo total de {empleado.Nombre} = {M(empleado.Salario,3000)}");          
        }

        static void InidcesRang(){
            Console.WriteLine("[ 8 ] Inidces y rangos .............");
            EmpleadoPosicion empleado = new EmpleadoPosicion("A2","Humberto Esparza Lopez",23,2800,
                "Recursos Humanos","Loreto");
            var vacaciones = new string[]
            {
                "Enero",     
                "Febrero", 
                "Marzo",    
                "Abril",   
                "Mayo",  
                "Junio",    
                "Julio",     
                "Agosto",     
                "Septiembre",
                "Octubre",
                "Noviembre",
                "Diciembre"
            };
            Console.WriteLine($"Las vacaciones de {empleado.Nombre} son en {vacaciones[^7]}");
        }
    }
}
