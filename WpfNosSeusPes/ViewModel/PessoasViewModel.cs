using NosSeusPes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfNosSeusPes.ViewModel
{
    public class PessoasViewModel
    {
        public ObservableCollection<Pessoa> Pessoas { get; set; }

        public Pessoa PessoaSelecionada { get; set; }

        private ModelNosSeusPes Context { get; set; }

        public PessoasViewModel()
        {
            Context = new ModelNosSeusPes();

            this.Pessoas = new ObservableCollection<Pessoa>(Context.Pessoas.ToList());
            this.PessoaSelecionada = Context.Pessoas.FirstOrDefault();
        }

        public void Adicionar()
        {
            Pessoa p = new Pessoa();
            this.Pessoas.Add(p);
            this.Context.Pessoas.Add(p);
            this.PessoaSelecionada = p;
        }

        public void Salvar()
        {
            this.Context.SaveChanges();
        }
    }
}
