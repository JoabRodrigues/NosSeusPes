using System;
using System.Collections.Generic;
using System.Text;

namespace ModelNosSeusPes
{
    public class PessoaFisica : Pessoa
    {
        public String CPF { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
