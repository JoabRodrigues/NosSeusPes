using System;
using System.Collections.Generic;
using System.Text;

namespace NosSeusPes
{
    public class PessoaFisica : Sapato
    {
        public String CPF { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
