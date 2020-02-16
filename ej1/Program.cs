using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            empleado empleado01 = new empleado();

            empleado empleado02;
            empleado02 = new empleado();
            empleado empleado03 = new empleado("Maria",30);

            empleado01.Nombre = "Juan Perez";
            empleado01.Edad = 25;
            Console.WriteLine($"Nombre{empleado01.Nombre} Edad: {empleado01.Edad}");
            Console.WriteLine(empleado01.ToString());
            Console.WriteLine($"Te vas de vacaciones: {DateTime.Now.ToString("dd/MM/yy")}");
            Console.WriteLine(empleado01.Vacaciones(DateTime.Now,30));

        }
    }
}
