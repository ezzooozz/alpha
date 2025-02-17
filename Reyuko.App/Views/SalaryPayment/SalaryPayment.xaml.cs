﻿using Reyuko.BLL.Core;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using System;
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

namespace Reyuko.App.Views.SalaryPayment
{
    /// <summary>
    
    /// </summary>
    public partial class SalaryPayment : UserControl
    {
        public SalaryPayment()
        {
            InitializeComponent();
            Switcher.pageSwitchersalary = this;            
            this.Init();
        }
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        private IEnumerable<OrderPembayaranGaji> orderPembayaranGajis { get; set; }
        private OrderPembayaranGaji orderPembayaranGajiSelected;
       
        private void Init()
        {
            this.LoadPembayaranGaji();
        }


        public void LoadPembayaranGaji()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.orderPembayaranGajis = uow.OrderPembayaranGaji.GetAll();
                DGSalaryPayment.ItemsSource = this.orderPembayaranGajis;             
            }
        }
        private void NewSalaryPayment_Click(object sender, RoutedEventArgs e)
        {
            NewSalaryPayment v = new NewSalaryPayment();
            Switcher.Switchsalary(v);
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Print.Print)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                Print.Print print = new Print.Print();
                print.Show();
            }
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {

        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }
     
    }
}
             
    

