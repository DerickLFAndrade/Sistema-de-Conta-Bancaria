using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Funci {
    public class Funcionarios {
       
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int TotalFuncionario { get; private set;}
        public static int totalFuncionario;    
        
        public Funcionarios (string nome, string cpf) {
            Nome = nome;
            Cpf = cpf;
            Console.WriteLine("Criando Funcionário");
            TotalDeFuncionarios ++;
        }
    }
}
