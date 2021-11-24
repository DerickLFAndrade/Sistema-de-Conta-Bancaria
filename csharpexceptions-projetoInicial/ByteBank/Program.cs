using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program {
        static void Main() {
            try {
                
                ContaCorrente conta = new ContaCorrente(1, 1);
                conta.Sacar(50);

                ContaCorrente conta2 = new ContaCorrente(2, 2);
                conta2.Transferir(50000, conta);

                Console.WriteLine(conta.Saldo);

            } catch (SaldoInsuficienteException ex) {
                Console.WriteLine(ex.Message);
               
            }
            catch (ArgumentException ex) {
                Console.WriteLine(ex.Message);
             
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }
        
            
    }

 }

