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
    /// Lógica interna para WpfProdutos.xaml
    /// </summary>
    public partial class WpfProdutos : Window
    {
        public SapatoViewModel SapatoViewModel { get; set; }
        public WpfProdutos()
        {
            InitializeComponent();
            this.SapatoViewModel = new SapatoViewModel();
            this.DataContext = this; ;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.SapatoViewModel.Adicionar();
        }
    }
}
