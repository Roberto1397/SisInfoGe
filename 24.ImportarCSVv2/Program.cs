using System;
using System.IO; // Libreria para StreamREader y StreamWriter
using CsvHelper; // Libreria para trabajar con archivos cvs
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _24.ImportarCSVv2
{
class Program
{
static void Main(string[] args)
        {
            // Importar archivo cvs en un la clase Foo
            List<Foo> registros = new List<Foo>();
            registros=Leer("file.csv");
            Console.WriteLine("\nRegistros leidos del archivo file.csv\n");
            registros.ForEach(r=>Console.WriteLine(r.ToString()));

            // Agregar registros adicionales
            registros.Add(new Foo {Id=3, Nombre="Jose", Salario=1234.56, Fecha="1/1/2010"});
            registros.Add(new Foo {Id=4, Nombre="Lore", Salario=7745.56, Fecha="11/22/2019"});
            Console.WriteLine("\nRegistros despus de agregar datos adicionales\n");
            registros.ForEach(r=>Console.WriteLine(r.ToString()));

            // Grabar todos los registros en un nuevo archivo
            Grabar(registros,"file2.csv");

            // Leer nuevamente del archvo con todos los registros
            List<Foo> registros2 = new List<Foo>();
            registros2=Leer("file2.csv");
            Console.WriteLine("\nRegistros leidos del archivo file2.cvs\n");
            registros.ForEach(r=>Console.WriteLine(r.ToString()));

        }
// Recibe un nombre de archivo y regresa una lista de registros de la clase Foo
        public static List<Foo> Leer(string file) {
            using (var  reader = new StreamReader(file))
            using (var cvs = new CsvReader(reader,CultureInfo.InvariantCulture))
            {
                cvs.Configuration.HasHeaderRecord=false;
                cvs.Read();
                var records=cvs.GetRecords<Foo>().ToList();
                return records;
            }
        }


        // Recibe una lista de registros de la clase Foo, y un nombre de archivo en el cual graba los datos
        public static void Grabar(List<Foo> records, string file) {
             using (var writer = new StreamWriter(file))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }           
        }
    }
}