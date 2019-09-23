using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NosSeusPes
{

    [Table("Modelos")]
    public class Modelo
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public Boolean PresencaDeCardarco { get; set; }
        public int CadarcoSN { get; set; } 
        public String Material { get; set; }
        public int materialId { get; set; }
        public Marca Marca { get; set; }
        public int marcaId { get; set; }



        public void Cadastra(int? id, string nome, int cadarcoSN, int material, int marca)
        {
            if (id != null) // essa validação é feita para criar novo modelo
            {
                var modelo = new Modelo();
                modelo.Nome = nome ;
                modelo.CadarcoSN = cadarcoSN;
                modelo.marcaId = material;
                modelo.marcaId = marca;
            }
            else // caso o id não seja nulo, iremos buscar ele no banco para editar as informações. Assim usamos o mesmo método de criação para edição.
            {
                var modelo = new Modelo(); //Aqui busca o modelo no banco passando o id
                modelo.Nome = nome;
                modelo.CadarcoSN = cadarcoSN;
                modelo.marcaId = material;
                modelo.marcaId = marca;
            }

            //Aqui será salvo as informações do sapato, acessamos a tabela Modelo no banco e adicionamos as informações

        }
    }
}
