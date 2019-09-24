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
            this.PessoasViewModel.Adicionar();
        }
        
        private void Deletar_Click(object sender, RoutedEventArgs e)
        {
            
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

        }


    }
}
