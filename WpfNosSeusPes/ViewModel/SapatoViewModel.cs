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
        public List<Cor> Cores { get; set; }
        public List<Marca> Marcas { get; set; }

        private ModelNosSeusPes Context { get; set; }
        public Sapato p { get; private set; }

        public SapatoViewModel()
        {
            Context = new ModelNosSeusPes();

            Sapatos = new ObservableCollection<Sapato>(Context.Sapatos.ToList());
            SapatoSelecionado = Context.Sapatos.FirstOrDefault();

            Cores = new List<Cor>(Context.Cores.ToList());
            Marcas = new List<Marca>(Context.Marcas.ToList());
        }

        public void Adicionar()
        {
            Sapato s = new Sapato();
            Sapatos.Add(s);
            Context.Sapatos.Add(s);
            SapatoSelecionado = s;
        }

        public void Excluir()
        {
            if (SapatoSelecionado.Id != 0)
            {
                Context.Sapatos.Remove(
                    SapatoSelecionado);
            }
            Sapatos.Remove(SapatoSelecionado);
        }

        public void Salvar()
        {
            Context.SaveChanges();
        }

    }
}
