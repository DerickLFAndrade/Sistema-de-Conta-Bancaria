using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoNc
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao  { get; set; }

        public override string ToString()
        {
            return $@"
Nome do titular: {Nome}
CPF: {Cpf}
Profissão: {Profissao}";
        }

    }
}
