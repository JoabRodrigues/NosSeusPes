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
        public List<Modelo> Modelos { get; set; }

        public void Cadastra(int? id, string nome)
        {
            if (id != null) // essa validação é feita para criar novo marca
            {
                var marca = new Marca();
                marca.Nome = nome;
            }
            else // caso o id não seja nulo, iremos buscar ele no banco para editar as informações. Assim usamos o mesmo método de criação para edição.
            {
                var marca = new Marca(); //Aqui busca o marca no banco passando o id
                marca.Nome = nome;
            }

            //Aqui será salvo as informações do sapato, acessamos a tabela Marca no banco e adicionamos as informações

        }
    }
}
