using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NosSeusPes
{
    [Table("Marcas")]
    public class Marca
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public List<Sapato> Sapatos { get; set; }
    }
}
