using System;

namespace _24.ImportarCSVv2
{
    public class Foo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Salario {get; set;}
        public string Fecha {get; set;}
        public override string ToString() => $"{Id} {Nombre} {Salario} {Fecha}";
    }
}