using NosSeusPes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfNosSeusPes.ViewModel;

namespace WpfNosSeusPes
{
    /// <summary>
    /// Lógica interna para WpfCliente.xaml
    /// </summary>
    public partial class WpfCliente : Window
    {
        public PessoasViewModel PessoasViewModel { get; set; }
        public WpfCliente()
        {
            InitializeComponent();
            this.PessoasViewModel = new PessoasViewModel();
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Quer adicionar uma Pessoa Física? Aperte Não para Adicionar uma Pessoa Jurídica", "Pessoa Física", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                this.PessoasViewModel.Adicionar(2);
            }
            else
            {
                this.PessoasViewModel.Adicionar(1);
            }
            
        }
        
        private void Deletar_Click(object sender, RoutedEventArgs e)
        {
            PessoasViewModel.Excluir();
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            this.PessoasViewModel.Salvar();
            this.Close();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Pessoa p = PessoasViewModel.PessoaSelecionada;
            UserControl page = PessoaViewFactory.VisualizarPessoa(p);
            while (PessoaContent.Children.Count > 0)
            {
                PessoaContent.Children.RemoveAt(0);
            }
            if(page != null) {
                PessoaContent.Children.Add(page);
            }
            
        }

        public class PessoaViewFactory
        {
            static public UserControl VisualizarPessoa(Pessoa pessoa)
            {

                if (pessoa is PessoaFisica)
                {
                    var pg = new PessoaFisicaUC();
                    pg.Pessoa = (PessoaFisica)pessoa;
                    return pg;

                }
                else if (pessoa is PessoaJuridica)
                {
                    var pg = new PessoaJuridicaUC();
                    pg.Pessoa = (PessoaJuridica)pessoa;
                    return pg;
                }
                return null;
            }
        }

    }
}
