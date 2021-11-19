using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios {
    public class Funcionario {
       //ATRIBUTOS DA CLASSE
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; set; }
        //ATRIBUTOS DA CLASSE
        
        public Funcionario (string cpf) { //Construtor
            CPF = cpf;
            TotalDeFuncionarios++;
        }

        public virtual double GetBonificacao() { //Método
             
            return Salario *  0.10;
        }

    }
}
