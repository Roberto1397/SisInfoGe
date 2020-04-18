using System;
using System.IO; // Libreria para StreamREader y StreamWriter
using CsvHelper; // Libreria para trabajar con archivos cvs
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SegundoParcial
{
class Program
{
static void Main(String[] args)
        {
            // Importar archivo cvs en un la clase Empleados
            List<Empleado> registros = new List<Empleado>();
            registros=Leer("datos.csv");
            // Agregar registros adicionales
            registros.Add(new Empleado {Rfc="CARC771123",Nombre="CARLOS CASTANEDA RODRIGUEZ",Area="JUBILADOS",Salario=5456.66});
            registros.Add(new Empleado {Rfc="SOBR711202",Nombre="ROCIO SOTO BOTELLO",Area="JUBILADOS",Salario=6423.66});
            registros.Add(new Empleado {Rfc="SUGA791124",Nombre="ARACELI SUSTAITA GOMEZ",Area="PROMOCION",Salario=2380});
            registros.Add(new Empleado {Rfc="DEAM690813",Nombre="MARGARITA DELGADILLO ARCE",Area="PROMOCION",Salario=1858});
            registros.Add(new Empleado {Rfc="PETT670521",Nombre="PEREZ TORRES MARIA TRINIDAD",Area="PROMOCION",Salario=1851});
            registros.Add(new Empleado {Rfc="ROLE771004",Nombre="ERIKA FRANCISCA ROBLES LOPEZ",Area="JUBILADOS",Salario=4691.44});
            registros.Add(new Empleado {Rfc="LERK911214",Nombre="KARELY GUADALUPE LEAL RAMOS",Area="DEPORTE",Salario=1223.66});
            registros.Add(new Empleado {Rfc="BEAY911116",Nombre="YESICA BERUMEN ACOSTA",Area="CULTURA",Salario=6423.66});

            // Grabar todos los registros en un nuevo archivo
            Grabar(registros,"nomina.csv");
            Console.WriteLine("Listado de nomina orden original......... [1]");
            Console.WriteLine("Listado de nomina ordenado por nombre ... [2]");
            Console.WriteLine("Listado de nomina ordenado por salario .. [3]");
            Console.WriteLine("Listado de nomina con salario > 3500 .... [4]");
            Console.WriteLine("Listado de nomina con 77 en el Rfc....... [5]");
            Console.WriteLine("Listado de nomina con los JUBILADOS...... [6]");
            Console.WriteLine("Listado de nomina agrupado por area...... [7]\n\n");
            if(args[0] == "1"){
            Console.WriteLine("Listado de nomina orden original:");
            List<Empleado> registros2 = new List<Empleado>();
            registros2=Leer("nomina.csv");
            registros2.ForEach(r=>Console.WriteLine(r.ToString()));
            Console.WriteLine($"Total: {registros2.Count}");}
            else if(args[0] == "2"){
            Console.WriteLine("Listado de nómina ordenado por nombre:\n");
            List<Empleado> registros3 = new List<Empleado>();
            registros3=Leer("nomina.csv");
            registros3.Sort((p, q) => string.Compare(p.Nombre, q.Nombre));
            registros3.ForEach(r=>Console.WriteLine(r.ToString()));
            Console.WriteLine($"Total: {registros3.Count}");}
            else if(args[0] == "3"){
            Console.WriteLine("Listado de nomina ordenado por salario:\n");
            List<Empleado> registros4 = new List<Empleado>();
            registros4=Leer("nomina.csv");
            var q1 = (from emp in registros4 orderby emp.Salario select emp).ToList();  
            q1.Reverse();
            q1.ForEach(r=>Console.WriteLine(r.ToString()));
            Console.WriteLine($"Total: {registros4.Count}");}
            else if(args[0] == "4"){
            Console.WriteLine("Listado de nomina con salario > 3500:\n");
            List<Empleado> registros5 = new List<Empleado>();
            registros5=Leer("nomina.csv");
            var q1 = (from emp in registros5 where emp.Salario > 3500 select emp).ToList();  
            q1.ForEach(r=>Console.WriteLine(r.ToString()));
            Console.WriteLine($"Total: {q1.Count}");}
            else if(args[0] == "5"){
            Console.WriteLine("Listado de nomina con 77 en el Rfc:\n");
            List<Empleado> registros6 = new List<Empleado>();
            registros6=Leer("nomina.csv");
            var q1 = (from emp in registros6 where emp.Rfc.Contains("77") select emp).ToList();  
            q1.ForEach(r=>Console.WriteLine(r.ToString()));
            Console.WriteLine($"Total: {q1.Count}");}
            else if(args[0] == "6"){
            Console.WriteLine("Listado de nomina con los JUBILADOS:\n");
            List<Empleado> registros7 = new List<Empleado>();
            registros7=Leer("nomina.csv");
            var q1 = (from emp in registros7 where emp.Area.Contains("JUBILADOS") select emp).ToList();  
            q1.ForEach(r=>Console.WriteLine(r.ToString()));
            Console.WriteLine($"Total: {q1.Count}");}
            else if(args[0] == "7"){
            Console.WriteLine("Listado de nomina agrupado por area:\n");
            List<Empleado> registros8 = new List<Empleado>();
            registros8=Leer("nomina.csv");
            Console.WriteLine("AGROPECUARIO:");
            var q1 = (from emp in registros8 where emp.Area.Contains("AGROPECUARIO") select emp).ToList();  
            q1.ForEach(r=>Console.WriteLine(r.ToString()));
            Console.WriteLine($"Total: {q1.Count} - {q1.Sum(item => item.Salario)}\n");

            Console.WriteLine("DEPORTE:");
            var q2 = (from emp in registros8 where emp.Area.Contains("DEPORTE") select emp).ToList();  
            q2.ForEach(r=>Console.WriteLine(r.ToString()));
            Console.WriteLine($"Total: {q2.Count} - {q2.Sum(item => item.Salario)}\n");
            
            Console.WriteLine("PROMOCION:");
            var q3 = (from emp in registros8 where emp.Area.Contains("PROMOCION") select emp).ToList();  
            q3.ForEach(r=>Console.WriteLine(r.ToString()));
            Console.WriteLine($"Total: {q3.Count} - {q3.Sum(item => item.Salario)}\n");

            Console.WriteLine("JUBILADOS:");
            var q4 = (from emp in registros8 where emp.Area.Contains("JUBILADOS") select emp).ToList();  
            q4.ForEach(r=>Console.WriteLine(r.ToString()));
            Console.WriteLine($"Total: {q4.Count} - {q4.Sum(item => item.Salario)}\n");

            Console.WriteLine("CULTURA:");
            var q5 = (from emp in registros8 where emp.Area.Contains("CULTURA") select emp).ToList();  
            q5.ForEach(r=>Console.WriteLine(r.ToString()));
            Console.WriteLine($"Total: {q5.Count} - {q5.Sum(item => item.Salario)}\n");

            Console.WriteLine($"Total Areas: 5- {registros8.Sum(item => item.Salario)}\n");

            }
                

        }
// Recibe un nombre de archivo y regresa una lista de registros de la clase Foo
        public static List<Empleado> Leer(string file) {
            using (var  reader = new StreamReader(file))
            using (var cvs = new CsvReader(reader,CultureInfo.InvariantCulture))
            {
                cvs.Configuration.HasHeaderRecord=false;
                cvs.Read();
                var records=cvs.GetRecords<Empleado>().ToList();
                return records;
            }
        }

    
        // Recibe una lista de registros de la clase Foo, y un nombre de archivo en el cual graba los datos
        public static void Grabar(List<Empleado> records, string file) {
             using (var writer = new StreamWriter(file))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }           
        }
    }
}