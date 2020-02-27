using System;

namespace Examen
{
    class Program
    {
       
        static void Inicializa(Red red){
                red.AgregarNodo(new Nodo("192.168.0.10","servidor",5,10,"linux"));
                red.AgregarNodo(new Nodo("192.168.0.12","equipoactivo",2,12,"ios"));
                red.AgregarNodo(new Nodo("192.168.0.20","computadora",8,5,"windows"));
                red.AgregarNodo(new Nodo("192.168.0.15","servidor",10,22,"linux")); 

                red.Nodos[0].AgregarVulne(new Vulnerabilidades("CVE-2015-1635","microsoft"," HTTP.sys permite a atacantes remotos ejecutar código arbitrario","remota","04/14/2015",3));
                red.Nodos[0].AgregarVulne(new Vulnerabilidades("CVE-2017-0004","microsoft","El servicio LSASS permite causar una denegación de servicio","local"," 01/10/2001",1));   
                red.Nodos[1].AgregarVulne(new Vulnerabilidades("CVE-2017-3847","cisco","Cisco Firepower Management Center XSS","remote","02/21/2017",1));
                red.Nodos[2].AgregarVulne(new Vulnerabilidades("CVE-2009-2504","microsoft","Múltiples desbordamientos de enteros en APIs Microsoft .NET 1.1","local","11/13/2009",9));
                red.Nodos[2].AgregarVulne(new Vulnerabilidades("CVE-2016-7271","microsoft","Elevación de privilegios Kernel Segura en Windows 10 Gold","local","12/20/2016",2));
                red.Nodos[2].AgregarVulne(new Vulnerabilidades("CVE-2017-2996,","adobe","Adobe Flash Player 24.0.0.194 corrupción de memoria explotable","remota","15/02/2017",1));
               



        }
        static void Reporte(Red red)
        {
                Console.Clear();
                int n=0,mayor=0,menor=0;
                Console.WriteLine(">> Datos generales de la red: \n");
                Console.WriteLine($"Empresa: {red.Empresa}\nPropietario: {red.Propietario}\nDomicilio: {red.Domicilio}");
                Console.WriteLine($"Total de Nodos de red:{red.Nodos.Count}");
                foreach(Nodo nd in red.Nodos)
                    n+=nd.Vulnera.Count;
                Console.WriteLine($"Total vulnerabilidades:{n}\n");
                 Console.WriteLine(">> Datos generales de los nodos:\n");
                foreach(Nodo nod in red.Nodos)
                     Console.WriteLine($"Ip: {nod.Ip}, Tipo: {nod.Tipo}, Puertos: {nod.Puertos}, Saltos: {nod.Saltos}, So: {nod.So}, TotVul: {nod.Vulnera.Count}");
                foreach(Nodo no in red.Nodos)
                    if (no.Saltos>mayor)
                    {
                        mayor=no.Saltos;
                    }
                menor=mayor;
                 foreach(Nodo no in red.Nodos)
                    if (menor>no.Saltos)
                    {
                        menor=no.Saltos;
                    }
                    
                Console.WriteLine($"\nMayor numero de saltos:{mayor}");    
                Console.WriteLine($"Menor numero de saltos:{menor}\n");     
                Console.WriteLine(">> Vulnerabilidades por nodo:");
                foreach(Nodo nd in red.Nodos){
                     Console.WriteLine($"\nIp: {nd.Ip}    Tipo: {nd.Tipo}\n\nVulenravilidades:\n");
                     foreach(Vulnerabilidades vul in nd.Vulnera){
                         Console.WriteLine($"Clave: {vul.Clave}, Vendedor: {vul.Vendedor}, Descripción: {vul.Descripcion}, Tipo: {vul.Tipo}, Fecha: {vul.Fecha}, Antigüedad: {vul.Antiguedad}\n");
                     }
                     
                }           
                               
        }
        static void Main()
        {
            Red miRed =new Red("Red Patito, S.A. de C.V.","Mr Pato Macdonald","Av. Princeton 123, Orlando Florida");
            Inicializa(miRed);
            Reporte(miRed);
        }
    }
}
