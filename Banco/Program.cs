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
                Saldo = 10000


            };

            novaConta.titular.nome = "Derick Lucas";


            novaConta.Sacar(100);
            Console.WriteLine(novaConta.Saldo);
            Console.WriteLine(novaConta.titular.nome);

            Console.ReadKey();
        }
    }
}
