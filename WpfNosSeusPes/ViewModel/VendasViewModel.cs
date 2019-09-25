using NosSeusPes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfNosSeusPes.ViewModel
{
    public class VendasViewModel
    {
        public ObservableCollection<Venda> Vendas { get; set; }
        public Venda VendaSelecionada { get; set; }
        public List<Pessoa> Pessoas { get; set; }
        public List<VendaItem> VendaItens { get; set; }
        private ModelNosSeusPes Context { get; set; }

        public VendasViewModel()
        {
            Context = new ModelNosSeusPes();

            Vendas = new ObservableCollection<Venda>(Context.Vendas.ToList());
            VendaSelecionada = Context.Vendas.FirstOrDefault();
            Pessoas = new List<Pessoa>(Context.Pessoas.ToList());

            // consulta para trazer apenas os itens da venda em questão
            //VendaItens = new List<VendaItem>(Context.VendaItens.ToList());
        }

        public void Adicionar()
        {
            Venda v = new Venda();
            v.Data = DateTime.Now;
            v.VendaItens = new ObservableCollection<VendaItem>();
            Vendas.Add(v);
            Context.Vendas.Add(v);
            VendaSelecionada = v;    
        }

        public void AdicionarVendaItem()
        {
            VendaItem vi = new VendaItem();
            VendaSelecionada.VendaItens.Add(vi);
            Context.VendaItens.Add(vi);
        }

        public void Salvar()
        {
            Context.SaveChanges();
        }

    }
}
