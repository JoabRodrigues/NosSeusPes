using System;
using System.Collections.Generic;
using System.Text;

namespace ModelNosSeusPes
{
    [Table("Vendas")]
    public class Venda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public Double Preco { get; set; }
        public int Quantidade { get; set; }
        public Pessoa Cliente { get; set; }
        public IList<Sapato> Sapatos { get; set; }
    }
}
