using System;

namespace Examen
{
    class Vulnerabilidades
    {
        private string clave;
        private string vendedor;
        private string descripcion;
        private string tipo;
        private string fecha;
        private int antiguedad;

        public Vulnerabilidades(string clave,string vendedor,string descripcion,string tipo,string fecha,int antiguedad)
        {
            this.clave=clave;
            this.vendedor=vendedor;
            this.descripcion=descripcion;
            this.tipo=tipo;
            this.fecha=fecha;
            this.antiguedad=antiguedad;

        }

        public string Clave{
            get{return clave;}
            set { clave = value;}
        }
        public string Vendedor{
            get{return vendedor;}
            set { vendedor = value;}
        }
        public string Descripcion{
            get{return descripcion;}
            set { descripcion = value;}
        }
        public string Tipo{
            get{return tipo;}
            set { tipo = value;}
        }
        public string Fecha{
            get{return fecha;}
            set { fecha = value;}
        }
        public int Antiguedad{
            get{return antiguedad;}
            set { antiguedad = value;}
        }
    }
}
