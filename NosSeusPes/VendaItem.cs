using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NosSeusPes
{
    [Table("VendaItens")]
    public class VendaItem
    {
        public int Id { get; set; }
        public Double Preco { get; set; }
        public int Quantidade { get; set; }
        public Double ValorTotal { get; set; }
        public Venda Venda { get; set; }
        public Sapato Sapato { get; set; }
    }
}
