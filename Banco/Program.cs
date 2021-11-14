using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!\r\nEsse é meu primeiro programa em C#");

            Cliente derick = new Cliente { 
            
              nome = "Derick",
              Cpf = "145.132.456.87",
              Proffisao = "Desenvolvedor Full Stack"
              
            
            };


            ClasseCBancaria novaConta = new ClasseCBancaria {

                titular = derick,
                Agencia = 156,
                NumeroC = 13345,
                saldo = 1000.10


            };

            novaConta.titular.nome = ("Derick Lucas");

           Console.WriteLine($"Saldo atual: R$ {novaConta.saldo}");

           novaConta.Sacar(100);
           Console.WriteLine($"Valor após o saque: R$ {novaConta.saldo}");

          // novaConta.Depositar(600);
           // Console.WriteLine($"Saldo após o depósito: R$ {novaConta.Depositar}")
            Console.WriteLine(novaConta.titular.nome);

            Console.ReadKey();
        }
    }
}
