using System;
using System.Collections.Generic;
using System.Text;

namespace ModelNosSeusPes
{
    public class Marca
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public List<Modelo> Modelos { get; set; }
    }
}
