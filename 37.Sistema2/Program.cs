using System;
using System.Net;
using System.Net.NetworkInformation;

namespace _37.Sistema2
{
    //Ejemplo de iformacion de la redd

    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length < 1) Menu();
            else{
                Console.ForegroundColor = ConsoleColor.Red;
                switch(int.Parse(args[0])){
                    case 1: Ping("www.google.com"); break;
                    case 2: DnsAndIpLocal(); break;
                    case 3: InterfacesRed(); break;
                    default: Console.WriteLine("Opcion invalida ..."); break;

                }
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }

        static void Menu(){
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[-] Menu de opciones operaciones de red \n");
            Console.WriteLine("[-] Hacer ping a google.com ...........................[1]");
            Console.WriteLine("[-] Obtener nombre host e ip de mi maquina ............[2]");
            Console.WriteLine("[-] Obtener interfaces de red de la maquina ...........[3]");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        static void Ping(string ipaddr){
            Ping ping = new Ping();
            Console.WriteLine("Haciendo ping a google.com");
            PingReply reply = ping.Send(ipaddr,1000);
            Console.WriteLine($"Respuesta: {reply.Status.ToString()}");
        }

        static void DnsAndIpLocal(){
            string hostname = Dns.GetHostName();
            string ip = Dns.GetHostEntry(hostname).AddressList[0].ToString();
            Console.WriteLine($"Nombre del host : {hostname}");
            Console.WriteLine($"Ip del host     : {ip}");
        }

        static void InterfacesRed()
        {
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            Console.WriteLine($"Interfaces Wireless p Ethernet:");
            foreach(NetworkInterface interfaz in interfaces)
            {
                if(interfaz.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 ||
                interfaz.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    Console.Write($"{interfaz.Id.ToString(),-8}");
                    Console.Write($"{interfaz.NetworkInterfaceType.ToString(),-10}");
                    Console.Write($"{interfaz.GetPhysicalAddress().ToString(),-13}");
                    UnicastIPAddressInformationCollection uniIps = interfaz.GetIPProperties().UnicastAddresses;
                    foreach(UnicastIPAddressInformation ip in uniIps)
                        Console.Write($"{ip.Address.ToString(),-30}");
                    Console.WriteLine();
                }
            }
        }
    }
}
