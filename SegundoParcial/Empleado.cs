using System;

namespace SegundoParcial
{
    public class Empleado
    {
        public string Rfc { get; set; }
        public string Nombre { get; set; }
        public string Area {get; set;}
        public double Salario {get; set;}
        public override string ToString() => $"{Rfc} {Nombre}\t {Area}\t {Salario}";
    }
}