using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoNc {
    internal class ContaCorrente {
        public Cliente titular;
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }


        public override string ToString() {
            return $@"
{titular}
Agencia: {Agencia}
Numero: {Numero}
Saldo: R$ {Saldo}";
        }

        public void Depositar(double valor) {

            Saldo += valor;

        }
        public bool Sacar(double valor) {
            if (valor > Saldo) {
                Console.WriteLine("O valor solicitado excede o valor em conta, por favor verifique os dados e tente novamente!");
                return false;
            } else if (valor == 0) {
                Console.WriteLine("É necessário informar um valor para o saque!");
                return false;
            }


            Saldo -= valor;
            return true;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino) {
            if (valor > Saldo) {
                Console.WriteLine("O valor solicitado excede o valor em conta, por favor verifique os dados e tente novamente!");
                return false;

            } else if (valor == 0) {
                Console.WriteLine("É necessário informar um valor para o saque!");
                return false;
            }
            contaDestino.Saldo += valor;
            Sacar(valor);
            return true;

        }
    }
}
