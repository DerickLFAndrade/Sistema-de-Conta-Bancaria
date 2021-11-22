using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão {
    internal class Funcionarios {
        private string cpf1;

        public static int TotalFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; protected //publico somente para classe e
                                               //filhos, mas fora dessas classes
                                               //age como privado.
                set; }
        public string Funcao { get; set; }
        public int Matricula { get; set; }
        public string Descricao { get; set; }


        /*PreencheNomeECpf*/
        public Funcionarios(string nome, string cpf, double salario) 
            /*Chama o construtor que preenche o cpf*/
            : this(cpf) {
            Nome = nome;
            Salario = salario;
            Console.WriteLine("Nome:" + nome);
            Console.WriteLine($"Número Matricula: {Matricula}\r\nFunção: {Funcao}\r\nSalário: {Salario}");
        }

        //PreencheCpf
        public Funcionarios(string cpf)
            /*Chama o contrutor que incrementa o total de funcionarios*/
            : this() {
                CPF = cpf;
                Console.WriteLine("CPF:" + cpf);
            
        }

        public Funcionarios() {

            Console.WriteLine("\r\n---------------------------\r\nFuncionario Criado");
            TotalFuncionarios++;
            Console.WriteLine($"Total {TotalFuncionarios}");

           
           
        }

        public Funcionarios(string cpf, string cpf1) : this(cpf) {
            this.cpf1 = cpf1;
            
        }

        public virtual void AumentaSalario() {
            Salario *= 1.1;
        }
    }
}
