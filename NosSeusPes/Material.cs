using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NosSeusPes
{
    [Table("Materiais")]
    public class Material
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public void Cadastra(int? id, string nome)
        {
            if (id != null) // essa validação é feita para criar novo marca
            {
                var material = new Material();
                material.Nome = nome;
            }
            else // caso o id não seja nulo, iremos buscar ele no banco para editar as informações. Assim usamos o mesmo método de criação para edição.
            {
                var material = new Material(); //Aqui busca o marca no banco passando o id
                material.Nome = nome;
            }

            //Aqui será salvo as informações do sapato, acessamos a tabela Marca no banco e adicionamos as informações

        }
    }
}
