using NosSeusPes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfNosSeusPes.ViewModel
{
    public class SapatoViewModel
    {
        public ObservableCollection<Sapato> Sapatos { get; set; }

        public Sapato SapatoSelecionado { get; set; }

        private ModelNosSeusPes Context { get; set; }
        public Sapato p { get; private set; }

        public SapatoViewModel()
        {
            Context = new ModelNosSeusPes();

            this.Sapatos = new ObservableCollection<Sapato>(Context.Sapatos.ToList());
            this.SapatoSelecionado = Context.Sapatos.FirstOrDefault();
        }

        public void Adicionar()
        {
            Sapato s = new Sapato();
            this.Sapatos.Add(s);
            this.Context.Sapatos.Add(s);
            this.SapatoSelecionado = s;
        }

        public void Salvar()
        {
            this.Context.SaveChanges();
        }

    }
}
