using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios {
    internal class Auxiliar : Funcionarios {

        public Auxiliar(string nome, string desc, double salario) {
            //Matricula = mat;
            Nome = nome;
            Descricao = desc;
            Salario = salario;
        }
        public override void AumentaSalario() {
            Salario *= 1.05;
        }

    }
}
