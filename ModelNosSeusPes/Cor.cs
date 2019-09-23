using System;
using System.Collections.Generic;
using System.Text;

namespace ModelNosSeusPes
{

    [Table("Cores")]
    public class Cor
    {
        public int Id { get; set; }
        public String Nome { get; set; } 
        public List<Sapato> Sapatos { get; set; }
    }
}
