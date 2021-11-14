using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class ClasseCBancaria {

            public Cliente titular;
            public int Agencia { get; set; }
            public int NumeroC { get; set; }
            public double saldo;


       public bool Sacar(double saldo) { 
        
            if (this.saldo < 0) {

                return false;

            }
            this.saldo -= saldo;
            return true;
        
        }

       public void Depositar(double saldo) { 
        
            this.saldo += saldo;
            
        
        }  

        public bool Trasferir(double valor, ClasseCBancaria contaDestino) { 
        
        
            if (this.saldo < valor)
                return false;

            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

            
        
        }


    }
}
