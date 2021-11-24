// using _05_ByteBank;

using System;

namespace ByteBank {
    public class ContaCorrente {
        public static double TaxaOperacao { get; set; }
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; set; }

        public int ContadorDeSaquesNaoPermitidos { get; private set; }
        public int ContadorDeTransferenciasNaoPermitidos { get; private set; }


        public int Agencia { get; }
        public int Numero { get; }

        private double _saldo = 100;

        public double Saldo {
            get {
                return _saldo;
            }
            set {
                if (value < 0) {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero) {
            if (agencia <= 0) {
                ArgumentException excecao = new ArgumentException("A agencia tem que ser maior 0!", nameof(agencia)); //nameof transforma a palavra da variável em string
                throw excecao;
            }
            if (numero <= 0) {
                ArgumentException excecao = new ArgumentException("O número tem que ser maior que 0!", nameof(numero));
                throw excecao;
            }
            Agencia = agencia;
            Numero = numero;


            
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }


        public bool Sacar(double valor) {
            if(valor < 0) {
                throw new ArgumentException("Valor inválido para saque", nameof(valor));
            }
            if (_saldo < valor) {
                ContadorDeSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor) {
            _saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino) {
            if (valor < 0) {
                throw new ArgumentException("Valor invalido para a transferência", nameof(valor));
            }
           
            try {
                Sacar(valor);
            } catch (SaldoInsuficienteException) {
                ContadorDeTransferenciasNaoPermitidos++;
                throw;
            }
            
            contaDestino.Depositar(valor);
            
        }
    }
}
