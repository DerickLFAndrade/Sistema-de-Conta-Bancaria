using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program {
        static void Main() {
            M2();
            Console.ReadLine();
        }
        public static void M2() {
            try {
                Dividir();
            } catch (DivideByZeroException) {
                Console.WriteLine("exceção tratada");
            }
        }

       public static int Dividir(int n1 = 10, int n2 = 0) { 
            return n1 / n2; 
        }
    }
}
