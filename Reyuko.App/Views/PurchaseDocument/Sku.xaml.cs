﻿using Reyuko.BLL.Core;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Reyuko.App.Views.PurchaseDocument
{
    /// <summary>
   
    /// </summary>
    public partial class Sku : Window
    {
        public Sku(NewPurchasedOrder newpurchaseorder)
        {
            InitializeComponent();
            this.newpurchaseorder = newpurchaseorder;
            this.Init();
        }
        public IEnumerable<produk> produks { get; set; }
        public produk produkSelected;
        private void ClearForm()
        {
        }

        private void Init()
        {
            this.ClearForm();
            this.Loadproduk();
        }
        public NewPurchasedOrder newpurchaseorder;
        private void Loadproduk()
        {
             using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
             {
                    this.produks = uow.produk.GetAll();
                    srsku.ItemsSource = this.produks;
             }
        }
        private void produk_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.produkSelected = null;
            if (srsku.SelectedItem != null)
            {
                this.produkSelected = (produk)srsku.SelectedItem;
                txtunit.Text = this.produkSelected.SatuanDasar;
                txtprice.Text = this.produkSelected.HargaPokokAverage.ToString();
                txtdiskon.Text = this.produkSelected.DiskonProdukPersen;
                txttax.Text = this.produkSelected.PersentasePajak.ToString();
                txtdiskon1.Text = ((float.Parse(txtprice.Text.ToString()) * float.Parse(txtdiskon.Text.ToString()) / 100)).ToString();
            }
        }
        public OrderProdukBeli GetData()
        {
            OrderProdukBeli oData = new OrderProdukBeli();
            if (this.produkSelected != null)
            {
                oData.IdProduk = this.produkSelected.IdProduk;
                oData.Sku = this.produkSelected.SKU;
                oData.SatuanDasar = this.produkSelected.SatuanDasar;
                oData.HargaBeli = this.produkSelected.HargaBeli;
                oData.NamaProduk = this.produkSelected.NamaProduk;
          //      oData.PersentasePajak = this.produkSelected.PersentasePajak;
            }
            oData.TotalProduk = int.Parse(txttotal.Text);
            oData.TotalOrderProduk = double.Parse(txttotal1.Text);
            oData.PersentasePajak = double.Parse(txttotaltax.Text);
            oData.Checkboxaktif = true;
            return oData;
        }
        public void Addsku_Clicks(object sender, RoutedEventArgs e)
        {
            PurchaseordersBLL purchaseorderBLL = new PurchaseordersBLL();
                if (purchaseorderBLL.AddOrderProdukbeli(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Add Order Buy Product successfully added !");
                    this.newpurchaseorder.LoadDataSku();
                }
                else
                {
                    MessageBox.Show("Add Order Buy Product failed to add !");
                }
            this.Close();
        }

        private void Cancel_Clicks(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void load(object sender, EventArgs e)
        {
        }

        private void txttotal_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txttotal.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txttotal.Text = "";
                    return;
                }
            }
            txttotal1.Text = ((float.Parse(txttotal.Text.ToString()) * float.Parse(txtprice.Text.ToString())) - (float.Parse(txtdiskon.Text.ToString())/100 * float.Parse(txtprice.Text.ToString()))*float.Parse(txttotal.Text.ToString())).ToString();
            txttotaltax.Text = (float.Parse(txttotal1.Text.ToString()) * float.Parse(txttax.Text.ToString())).ToString();
        }
            
       
    }
}
