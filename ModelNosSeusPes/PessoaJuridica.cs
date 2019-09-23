using System;
using System.Collections.Generic;
using System.Text;

namespace ModelNosSeusPes
{
    public class PessoaJuridica : Pessoa
    {
        public String CNPJ { get; set; }
        public String RazaoSocial { get; set; }
    }
}
