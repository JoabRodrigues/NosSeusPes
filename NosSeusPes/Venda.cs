using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NosSeusPes
{
    [Table("Vendas")]
    public class Venda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        
        public Double ValorTotal { get; set; }
        public Pessoa Cliente { get; set; }
        public IList<VendaItem> VendaItens { get; set; }
    }
}
