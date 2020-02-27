using System;
using System.Collections.Generic;
namespace Examen
{
    class Nodo
    {
        private string ip;
        private string tipo;
        private int puertos;
        private int saltos;
        private string so;
        private List<Vulnerabilidades> vulnera;

        public Nodo(string ip,string tipo,int puertos,int saltos,string so)
        {
            this.ip=ip;
            this.tipo=tipo;
            this.puertos=puertos;
            this.saltos=saltos;
            this.so=so;
            vulnera=new List<Vulnerabilidades>();
        }

        public string Ip{
            get{return ip;}
            set { ip = value;}
        }
        public string Tipo{
            get{return tipo;}
            set { tipo = value;}
        }
        public int Puertos{
            get{return puertos;}
            set { puertos = value;}
        }
        public int Saltos{
            get{return saltos;}
            set { saltos = value;}
        }
        public string So{
            get{return so;}
            set { so = value;}
        }
        public List<Vulnerabilidades> Vulnera{
            get{return vulnera;}

        }
        public void AgregarVulne(Vulnerabilidades vul)
        {
            vulnera.Add(vul);
        }
    }
}
