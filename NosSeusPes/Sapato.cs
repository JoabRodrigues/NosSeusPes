using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NosSeusPes
{
    [Table("Sapatos")]
    public class Sapato
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public int tamanho { get; set; }
        public int quantidade { get; set; }
        public Cor Cor { get; set; }
        public int corId { get; set; }
        public Modelo Modelo { get; set; }
        public int modeloId { get; set; }
        public IList<Venda> Vendas { get; set; }

        public void Cadastra(int? id, string nome, int tamanho, int quantidade, int cor, int modelo)
        {
            if(id != null) // essa validação é feita para criar novo sapato
            {
                var sapato = new Sapato();
                sapato.nome = nome;
                sapato.tamanho = tamanho;
                sapato.quantidade = quantidade;
                sapato.corId = cor;
                sapato.modeloId = modelo;
            }
            else // caso o id não seja nulo, iremos buscar ele no banco para editar as informações. Assim usamos o mesmo método de criação para edição.
            {
                var sapato = new Sapato(); // Aqui busca o sapato no banco passando o id
                sapato.nome = nome;
                sapato.tamanho = tamanho;
                sapato.quantidade = quantidade;
                sapato.corId = cor;
                sapato.modeloId = modelo;
            }
                   
            //Aqui será salvo as informações do sapato, acessamos a tabela Sapato no banco e adicionamos as informações

        }
    }
        
}
