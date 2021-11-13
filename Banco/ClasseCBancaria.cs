using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ClasseCBancaria {

            public Cliente titular;
            public int Agencia { get; set; }
            public int NumeroC { get; set; }
            public double Saldo { get; set; }


        public bool Sacar(double Saldo) { 
        
            if (this.Saldo < 0) {

                return false;

            }
            this.Saldo -= Saldo;
            return true;
        
        }


    }
}
