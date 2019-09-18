using System;
using System.Collections.Generic;
using System.Text;

namespace ModelNosSeusPes
{
    public class Modelo
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public Boolean PresencaDeCardarco { get; set; }
        public String Material { get; set; }
        public Marca Marca { get; set; }
    }
}
