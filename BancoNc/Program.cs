using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoNc {
    internal class Program {

        public static void Deposito(ContaCorrente conta_1, ContaCorrente conta_2) {

            Console.WriteLine($@"Selecione a conta que deseja realizar essa operação:
1 - {conta_1.titular.Nome}
2 - {conta_2.titular.Nome}");
            string opDep = Console.ReadLine();
            int reOpDep = int.Parse(opDep);
            switch (reOpDep) {
                case 1:

                    Console.Write("Digite o valor para depósito: R$ ");
                    string strDep1 = Console.ReadLine();
                    double valorDep1 = double.Parse(strDep1);
                    conta_1.Depositar(valorDep1);
                    Console.WriteLine($"Saldo atualizado: R$ {conta_1.Saldo}"); break;

                case 2:
                    Console.Write("Digite o valor para depósito: R$ ");
                    string strDep2 = Console.ReadLine();
                    double valorDep2 = double.Parse(strDep2);
                    conta_2.Depositar(valorDep2);
                    Console.WriteLine($"Saldo atualizado: R$ {conta_2.Saldo}"); break;
            }
        }
        public static void Saque(ContaCorrente conta_1, ContaCorrente conta_2) {


            Console.WriteLine($@"Selecione a conta que deseja realizar essa operação:
1 - {conta_1.titular.Nome}
2 - {conta_2.titular.Nome}");
            string opSaque = Console.ReadLine();
            int reOpSaque = int.Parse(opSaque);
            switch (reOpSaque) {

                case 1:
                    //FUNÇÃO PARA SAQUE
                    Console.Write("\r\nDigite o valor para saque: R$ ");
                    string valorSaque = Console.ReadLine();
                    double valor = double.Parse(valorSaque);
                    bool resultado = conta_1.Sacar(valor);

                    while (resultado == false) {
                        Console.Write("\r\nDigite o valor para saque: R$ ");
                        valorSaque = Console.ReadLine();
                        valor = double.Parse(valorSaque);
                        resultado = conta_1.Sacar(valor);
                    }
                    if (resultado == true) {
                        Console.WriteLine($@"Confirme os dados antes de prosseguir:
Nome do titular da conta: {conta_1.titular.Nome}
Cpf do titular: {conta_1.titular.Cpf}

Valor solicitado para saque: R$ {valor}");
                        Console.Write($@"

Digite 1 para confirmar
Digite 2 para cancelar a operação
");

                        string opções = Console.ReadLine();
                        switch (int.Parse(opções)) {

                            case 1: Console.WriteLine($@"Operação foi realizada com sucesso!
Seu saldo atualizado é: R$ {conta_1.Saldo}"); break;

                            case 2:
                                Console.WriteLine($"Esta operação foi cancelada!");
                                conta_1.Depositar(valor); break;

                        }

                    }


                    break;
                case 2:

                    //FUNÇÃO PARA SAQUE
                    Console.Write("\r\nDigite o valor para saque: R$ ");
                    valorSaque = Console.ReadLine();
                    valor = double.Parse(valorSaque);
                    resultado = conta_2.Sacar(valor);

                    //Retorna para as opções enquanto as condições para efetuar saques não forem satisfeitas
                    while (resultado == false) {
                        Console.Write("\r\nDigite o valor para saque: R$ ");
                        valorSaque = Console.ReadLine();
                        valor = double.Parse(valorSaque);
                        resultado = conta_2.Sacar(valor);
                    }
                    if (resultado == true) {
                        Console.WriteLine($@"Confirme os dados antes de prosseguir:
Nome do titular da conta: {conta_2.titular.Nome}
Cpf do titular: {conta_2.titular.Cpf}

Valor solicitado para saque: R$ {valor}");
                        Console.Write($@"

Digite 1 para confirmar
Digite 2 para cancelar a operação
");

                        string opções = Console.ReadLine();
                        switch (int.Parse(opções)) {

                            case 1: Console.WriteLine($@"Operação foi realizada com sucesso!
Seu saldo atualizado é: R$ {conta_2.Saldo}"); break;

                            case 2:
                                Console.WriteLine($"Esta operação foi cancelada!");
                                conta_2.Depositar(valor); break;

                        }

                    }


                    break;
            }
        }
        public static void Transferencia(ContaCorrente conta_1, ContaCorrente conta_2) {
            Console.WriteLine($@"Selecione a conta que deseja realizar essa operação:
1 - {conta_1.titular.Nome}
2 - {conta_2.titular.Nome}");
            string opTransf = Console.ReadLine();
            int reOpTransf = int.Parse(opTransf);
            switch (reOpTransf) {
                case 1:
                    //FUNÇÃO PARA TRANSFERÊNCIA
                    Console.Write("\r\nDigite o valor para transferência: R$ ");
                    string strTransf = Console.ReadLine();
                    double valorTransf = double.Parse(strTransf);
                    bool resTransf = conta_1.Transferir(valorTransf, conta_2);

                    //Retorna para as opções enquanto as condições para efetuar tranferências não forem satisfeitas
                    while (resTransf == false) {
                        Console.Write("\r\nDigite o valor para transferência: R$ ");
                        strTransf = Console.ReadLine();
                        valorTransf = double.Parse(strTransf);
                        resTransf = conta_1.Transferir(valorTransf, conta_2);
                    }
                    if (resTransf == true) {

                        Console.Write($@"Confira os dados da conta de destino:
Titular - {conta_2.titular.Nome}
Cpf - {conta_2.titular.Cpf}
Valor solicitado para transferência: R$ {valorTransf}");

                        Console.Write($@"

Digite 1 para confirmar
Digite 2 para cancelar a operação
");

                        string opções = Console.ReadLine();
                        switch (int.Parse(opções)) {

                            case 1: Console.WriteLine($@"Operação foi realizada com sucesso!"); break;

                            case 2:
                                Console.Write($"Esta operação foi cancelada!");
                                conta_2.Depositar(valorTransf); break;

                        }

                    }




                    Console.WriteLine($@"Saldo atualizado conta 1: R$ {conta_1.Saldo}
Saldo atualizado conta 2: R$ {conta_2.Saldo}"); break;

                case 2:

                    Console.Write("\r\nDigite o valor para transferência: R$ ");
                    strTransf = Console.ReadLine();
                    valorTransf = double.Parse(strTransf);


                    //FUNÇÃO PARA TRANSFERÊNCIA
                    resTransf = conta_2.Transferir(valorTransf, conta_1);

                    //Retorna para as opções enquanto as condições para tranferências não forem satisfeitas
                    while (resTransf == false) {

                        Console.Write("\r\nDigite o valor para transferência: R$ ");
                        strTransf = Console.ReadLine();
                        valorTransf = double.Parse(strTransf);
                        resTransf = conta_1.Transferir(valorTransf, conta_2);
                    }
                    if (resTransf == true) {

                        Console.Write($@"Confira os dados da conta de destino:
Titular - {conta_1.titular.Nome}
Cpf - {conta_1.titular.Cpf}
Valor solicitado para transferência: R$ {valorTransf}");

                        Console.Write($@"

Digite 1 para confirmar
Digite 2 para cancelar a operação
");

                        string opções = Console.ReadLine();
                        switch (int.Parse(opções)) {

                            case 1: Console.WriteLine($@"Operação foi realizada com sucesso!"); break;

                            case 2:
                                Console.Write($"Esta operação foi cancelada!");
                                conta_2.Depositar(valorTransf); break;

                        }

                    }



                    Console.WriteLine($@"Saldo atualizado conta 2: R$ {conta_2.Saldo}
Saldo atualizado conta 1: R$ {conta_1.Saldo}"); break;

            }
        }

        public static void MensagemInicial() {
            Console.WriteLine($@"Bem vindo ao Banco NC
Selecione a opção desejada:
Opção 1 - Entrar no sistema;
Opção 2 - Sair.
");
        }
        public static void Login() {
            Console.WriteLine($@"Você está logado no sistema!

Clientes disponíveis:
");
        }
        public static void Clientes(ContaCorrente conta_1, ContaCorrente conta_2) {
            Console.WriteLine($@"Conta 1 {conta_1}

Conta 2 {conta_2}

");
        }
        public static int Operacao() {
            Console.WriteLine($@"Selecione a operação desejada:
1 - Depósitos
2 - Saques
3 - Transferências");
        string operacao = Console.ReadLine();
            int escOp;
            if (int.TryParse(operacao, out escOp))
                return escOp;
            else
                return 0;
    }
        public static void Operacoes(int escOp, ContaCorrente conta_1, ContaCorrente conta_2) {

            switch (escOp) {

                //DEPÓSITO
                case 1:
                    Deposito(conta_1, conta_2);
                    break;

                //SAQUE
                case 2:
                    Saque(conta_1, conta_2);
                    break;

                //TRANSFERÊNCIA
                case 3:
                    Transferencia(conta_1, conta_2); 
                    break;

            }
        }
        static void Main() {
            string escolha;
            int op;
            int operacao = 0;

            MensagemInicial();
            escolha = Console.ReadLine();

            if (int.TryParse(escolha, out op)) {
                if (op == 1) {
                    //cliente 1
                    Cliente derick = new Cliente {

                        Nome = "Derick",
                        Cpf = "111.111.111-11",
                        Profissao = "Desenvolvedor C#"

                    };
                    ContaCorrente conta_1 = new ContaCorrente {

                        titular = derick,
                        Agencia = 1000,
                        Numero = 1000,
                        Saldo = 1000.5
                    };

                    //cliente 2
                    Cliente lucas = new Cliente {

                        Nome = "Lucas",
                        Cpf = "222.222.222-22",
                        Profissao = "Desenvolvedor JavaScript"

                    };
                    ContaCorrente conta_2 = new ContaCorrente {
                        titular = lucas,
                        Agencia = 2000,
                        Numero = 2000,
                        Saldo = 2000.5
                    };
                    Login();
                    Clientes(conta_1, conta_2);
                    operacao = Operacao();
                    if (operacao == 1 || operacao == 2 || operacao == 3) {
                        Operacoes(operacao, conta_1, conta_2);
                    } 
                    else {
                        Console.WriteLine("Operação inválida!");
                    }

                } 
                else
                    Console.WriteLine("Saiu!");

            }
            else
                Console.WriteLine("Opção inválida!");

        }

    }
}
