using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NosSeusPes
{
    [Table("Sapatos")]
    public class Sapato
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string Nome { get; set; }
        public int Tamanho { get; set; }
        public int Quantidade { get; set; }
        public Boolean PresencaDeCardarco { get; set; }
        public Cor Cor { get; set; }

        public Marca Marca { get; set; }

        public IList<Venda> Vendas { get; set; }

    }
        
}
