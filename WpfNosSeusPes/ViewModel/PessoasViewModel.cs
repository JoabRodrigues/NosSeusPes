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

        public void Adicionar(int Tipo)
        {
           
            if(Tipo == 1)
            {
                PessoaFisica p = new PessoaFisica();
                p.DataNascimento = new DateTime();
                this.Pessoas.Add(p);
                this.Context.Pessoas.Add(p);
                this.PessoaSelecionada = p;
            }
            else
            {
                PessoaJuridica p = new PessoaJuridica();
                this.Pessoas.Add(p);
                this.Context.Pessoas.Add(p);
                this.PessoaSelecionada = p;
            }
            
        }

        public void Salvar()
        {
            Context.SaveChanges();
        }

        public void Excluir()
        {
            if (this.PessoaSelecionada.Id != 0)
            {
                this.Context.Pessoas.Remove(
                    this.PessoaSelecionada);
            }
            this.Pessoas.Remove(this.PessoaSelecionada);
        }
    }
}
