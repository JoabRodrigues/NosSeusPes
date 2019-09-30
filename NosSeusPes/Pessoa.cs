using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NosSeusPes
{
    [Table("Pessoas")]
    public class Pessoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public String Nome { get; set; }
        public String Endereco { get; set; }
        public IList<Venda> Vendas { get; set; }

    }
}
