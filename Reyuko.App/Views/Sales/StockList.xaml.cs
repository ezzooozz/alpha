﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Reyuko.App.Views.Sales
{
    /// <summary>
    /// </summary>
    public partial class StockList : Window
    {
        public StockList()
        {
            InitializeComponent();
        }

        public object UserControl { get; internal set; }


        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
