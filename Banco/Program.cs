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
            Console.WriteLine("Hello world!\r\n Esse é meu primeiro programa em C#");

            ClasseCBancaria novaConta = new ClasseCBancaria {

                Titular = "Derick",
                Agencia = 156,
                NumeroC = 13345,
                Saldo = 10000


            };

            Console.ReadKey();
        }
    }
}
