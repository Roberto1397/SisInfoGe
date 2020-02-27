using System;

namespace _14.CuentaBancaria
{
    class CuentaDeAhorro : CuentaBancaria
    {
        private double tasaInteres;

        public CuentaDeAhorro(double saldo, double tasaInteres)
            :base(saldo) // llamada explicita al constructor clase base
        {
            this.tasaInteres=tasaInteres;
        }

        public void CalcularInteres(){
            saldo+=(saldo*tasaInteres);
        }
    }
}