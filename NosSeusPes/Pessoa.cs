using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NosSeusPes
{
    [Table("Pessoas")]
    public class Pessoa
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Endereco { get; set; }
        public IList<Venda> Vendas { get; set; }

    }
}
