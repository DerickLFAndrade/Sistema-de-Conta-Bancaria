using System;

namespace ByteBank.Funcionarios {
    internal class Program {
       

        static void Main() {
            CriarFuncionarios();
            UsarSistema();
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

        public static void UsarSistema() {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor fontes = new Diretor("Fontes", "444.444.444-44", 8465.64);
            fontes.Senha = "123";

            Gerente lucas = new Gerente("Lucas", "Gerente de contas", 3451.35);
            lucas.Senha = "123";

            Auxiliar fernando = new Auxiliar ("Fernando", "auxiliar de contas", 3451.35);
            lucas.Senha = "123";

            ParceiroComercial fornecedor = new ParceiroComercial();
            fornecedor.Senha = "111";

            sistemaInterno.Logar(fontes, "123");

            sistemaInterno.Logar(lucas, "123");

            sistemaInterno.Logar(fornecedor, "123");
        }

    }

  
}
