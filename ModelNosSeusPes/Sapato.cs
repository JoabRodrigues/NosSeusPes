using System;
using System.Collections.Generic;
using System.Text;

namespace ModelNosSeusPes
{
    public class Sapato
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public int Tamanho { get; set; }
        public int Quantidade { get; set; }
        public Cor Cor { get; set; }
        public Modelo Modelo { get; set; }
        public IList<Venda> Vendas { get; set; }
    }
}
