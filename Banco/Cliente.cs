using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Cliente {

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Proffisao { get; set; }

        public override string ToString()
        {
            return $@"Nome do titular: {Nome}
Cpf: {Cpf}
Profissão: {Proffisao}"; 

        }

    }

}
