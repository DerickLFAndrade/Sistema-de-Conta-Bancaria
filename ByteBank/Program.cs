using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank {
    internal class Program {
        static void Main() {

            GerenciadorBonificacao gerenciar = new GerenciadorBonificacao();

            Funcionario derick = new Funcionario ("111.111.111-11") {

                Nome = "Derick",
                Salario = 2000
            };
            gerenciar.Registrar(derick);

            Console.WriteLine($"Criando funcionário: {Funcionario.TotalDeFuncionarios}");
            Diretor lucas = new Diretor ("222.222.222-22") {

                Nome = "Lucas",
                Salario = 15000

            };
            Console.WriteLine(derick.CPF);

            Console.WriteLine(lucas.CPF);

            gerenciar.Registrar(lucas);

            Console.WriteLine(derick.Nome);
            Console.WriteLine("Bonificação: R$ " + derick.GetBonificacao() +"\r\n");

            Console.WriteLine(lucas.Nome);
            Console.WriteLine("Bonificação: R$ " + lucas.GetBonificacao() + "\r\n");


            Console.WriteLine("Total bonificações: R$ " + gerenciar.GetTotalBonificacao());
           
        }
    }
    
    }


