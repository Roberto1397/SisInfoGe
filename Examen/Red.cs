using System;
using System.Collections.Generic;
namespace Examen
{
    class Red
    {
        private string  empresa;
        private string propietario;
        private string  domicilio;
        private List<Nodo> nodos;
        public Red(string empresa,string propietario,string  domicilio){
            this.empresa = empresa;
            this.propietario = propietario;
            this.domicilio = domicilio;
            nodos = new List<Nodo>();
        }

        public string Empresa{
            get{return empresa;}
            set{empresa = value;}
        }

        public string Propietario{
            get{return propietario;}
            set{propietario = value;}
        }

        public string Domicilio{
            get{return domicilio;}
            set{domicilio = value;}
        }

        public void AgregarNodo(Nodo nod){
            nodos.Add(nod);
        }

        public List<Nodo> Nodos{
            get {return nodos;}
        }
    }
}
