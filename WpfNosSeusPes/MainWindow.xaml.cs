﻿using System;
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
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void BtnClientes_Click(object sender, RoutedEventArgs e)
        {
            WpfCliente WpfCliente = new WpfCliente();
            WpfCliente.Show();
        }

        private void btnProdutos_Click(object sender, RoutedEventArgs e)
        {
            WpfProdutos wpfProdutos = new WpfProdutos();
            wpfProdutos.Show();
        }

        private void BtnVendas_Click(object sender, RoutedEventArgs e)
        {
            WpfVenda WpfVenda = new WpfVenda();
            WpfVenda.Show();
        }
    }
}
