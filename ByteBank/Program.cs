
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios {
    internal class Program {
        static void Main() {
            CriarFuncionarios();
            Console.ReadLine();
        }

        public static void CriarFuncionarios () {
            Funcionarios lucas = new Gerente("Lucas", "Gerente de contas", 3451.35);

            Funcionarios derick = new Auxiliar("176.054.327.63", "", 6657.30);

            Funcionarios roberto = new Designer ("Roberto", "000.000.000.00", 4657.13);

            Funcionarios fontes = new Diretor("Fontes", "444.444.444-44", 8465.64);

            fontes.AumentaSalario();
            Console.WriteLine("Novo salário do diretor: R$ " + fontes.Salario);
        }

    }
}
