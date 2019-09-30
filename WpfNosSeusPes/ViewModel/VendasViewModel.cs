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
        public List<Sapato> Sapatos { get; set; }
        private ModelNosSeusPes Context { get; set; }

        public VendasViewModel()
        {
            Context = new ModelNosSeusPes();

            Vendas = new ObservableCollection<Venda>(Context.Vendas.ToList());

            foreach(Venda v in Vendas)
            {
                v.VendaItens = new ObservableCollection<VendaItem>();

                v.VendaItens = Context.VendaItens.Where(i => i.Venda.Id == v.Id).ToList();
            }
            VendaSelecionada = Context.Vendas.FirstOrDefault();
            Pessoas = new List<Pessoa>(Context.Pessoas.ToList());
            Sapatos = Context.Sapatos.ToList();

        }

        public void ExcluirVenda()
        {
            if (VendaSelecionada.Id != 0)
            {
                Context.Vendas.Remove(
                    VendaSelecionada);
            }
            Vendas.Remove(VendaSelecionada);
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
           
        }

        public void Salvar()
        {
            Context.SaveChanges();
        }

    }
}
