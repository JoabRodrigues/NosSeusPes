using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NosSeusPes
{

    [Table("Cores")]
    public class Cor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public String Nome { get; set; } 
        public List<Sapato> Sapatos { get; set; }
    }
}
