using Banco.Funci;
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
            
              Nome = "Derick",
              Cpf = "145.132.456.87",
              Proffisao = "Desenvolvedor Full Stack"
              
            
            };


            ClasseCBancaria conta_1 = new ClasseCBancaria {

                titular = derick,
                Agencia = 156,
                NumeroC = 13345,
                saldo = 1000.10


            };



                    Cliente lucas = new Cliente { 
            
              Nome = "Lucas",
              Cpf = "145.132.456.22",
              Proffisao = "Desenvolvedor Full Stack"
              
            
            };


            ClasseCBancaria conta_2 = new ClasseCBancaria {

                titular = lucas,
                Agencia = 156,
                NumeroC = 13345,
                saldo = 2000


            };



        
             Console.WriteLine($"Titular da conta 1: {conta_1.titular.Nome}");
            Console.WriteLine($"Saldo atual (conta 1): R$ {conta_1.saldo}");

             conta_1.Sacar(100);
            Console.WriteLine($"Valor após o saque (conta 1): R$ {conta_1.saldo}");

            conta_1.Depositar(600);
             Console.WriteLine($"Saldo após o depósito (conta 1): R$ {conta_1.saldo} \r\n");
           

            Console.WriteLine($"Titular da conta 2: {conta_2.titular.Nome}");
            Console.WriteLine($"Saldo antes da transferência (conta 2): R$ {conta_2.saldo}");
            conta_1.Trasferir(200, conta_2);
            Console.WriteLine($"Saldo após a transferência (conta 1): R$ {conta_1.saldo}");
            Console.WriteLine($"Saldo após a transferência (conta 2): R$ {conta_2.saldo}");

             Cliente fontes = new Cliente { 
            
              Nome = "Fontes",
              Cpf = "123.112.556.22",
              Proffisao = "Desenvolvedor C#"
              
            
            };

           ClasseCBancaria conta_3 = new ClasseCBancaria
           {
               titular = fontes,
                Agencia = 156,
                NumeroC = 13345,
                saldo = 6317
           };


            Funcionarios funcionario_1 = new Funcionarios("Derick", "111.111.111-11"); 

            

           Console.WriteLine(conta_1.titular);
            Console.WriteLine(Funcionarios.TotalDeFuncionarios);
            Console.ReadKey();
        }
    }
}
