using System;

namespace _14.CuentaBancaria
{
    class CuentaBancaria{
    protected double saldo;//permite que sea accedido por las clases que heredan
    public CuentaBancaria(double saldo){
        this.saldo=saldo;
    }
    public double Saldo{
        get{return saldo;}
    }
    public void Deposita(double cantidad){
        saldo+=cantidad;

    }
    // metodo virtual que podra ser sobrecargado por la clase que lo hereden
    public virtual bool Retira(double cant){
        if(saldo>=cant){
            saldo -=cant;
            return true;
        }else
        {
             return false;
        }
    }
    }
}
