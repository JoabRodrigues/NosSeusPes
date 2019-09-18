using System;
using System.Collections.Generic;
using System.Text;

namespace ModelNosSeusPes
{
    public class Pessoa
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Endereco { get; set; }
        public IList<Venda> Vendas { get; set; }

    }
}
