using System;

namespace _14.CuentaBancaria
{
    class CuentaBancaria{
    private double saldo;
    public CuentaBancaria(double saldo){
        this.saldo=saldo;
    }
    public double Saldo{
        get{return saldo;}
        set{saldo+=value;}
    }
    public bool Retira(double cant){
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
