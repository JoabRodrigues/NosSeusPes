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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfNosSeusPes
{
    /// <summary>
    /// Interação lógica para PessoaFisicaUC.xam
    /// </summary>
    public partial class PessoaFisicaUC : UserControl
    {
        public PessoaFisica Pessoa { get; set; }
        public PessoaFisicaUC()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
