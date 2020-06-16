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
using Reyuko.App.Views.Document;

namespace Reyuko.App.Views.ReceivedGood
{
    /// <summary>
    
    /// </summary>
    public partial class NewReceivedGood : UserControl
    {
        public NewReceivedGood()
        {
            InitializeComponent();
            Switcher.pageSwitcherNewreceived = this;
            this.Init();
        }
        private IEnumerable<ReceivedGood> receivedGoods { get; set; }

       
        private void Clearform()
        {
        }

        private IEnumerable<Kontak> kontaks { get; set; }
        public Kontak kontakSelected { get; set; }
        private IEnumerable<DataMataUang> dataMataUangs { get; set; }
        private DataMataUang DataMataUangSelected { get; set; }
        public IEnumerable<Dokumen> dokumens { get; set; }
        public Dokumen dokumenSelected { get; set; }
        public IEnumerable<Lokasi> lokasis { get; set; }
        public Lokasi lokasiSelected;
        public IEnumerable<OptionAnnual> optionAnnuals { get; set; }
        public OptionAnnual optionAnnualSelected;
        public IEnumerable<OrderProdukBeli> orderProdukBelis { get; set; }
        public IEnumerable<Termspembayaran> termspembayarans { get; set; }
        public Termspembayaran termspembayaranSelected;
        public IEnumerable<DataDepartemen> dataDepartemens { get; set; }
        public DataDepartemen dataDepartemenSelected;
        public IEnumerable<DataProyek> dataProyeks { get; set; }
        public DataProyek dataProyekSelected;
        public IEnumerable<DropdownBankKas> dropdownBankKas { get; set; }
        public DropdownBankKas dropdownBankKasSelected;
        public IEnumerable<PurchaseOrder> purchaseOrders { get; set; }
        public PurchaseOrder purchaseOrderSelected { get; set; }
        public IEnumerable<Purchasedelivery> purchasedeliveries { get; set; }
        public Purchasedelivery purchaseDeliverySelected { get; set; }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        private void Init()
        {
            this.LoadVendor();
            this.LoadNoDokumen();            
            this.LoadCurrency();
            this.LoadLokasi();
            this.LoadAnnual();
            this.LoadStaff();
            this.LoadCash();
            this.Clearform();
            this.LoadPO();
            this.LoadPD();
        }

        private void LoadPD()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.purchasedeliveries = uow.PurchaseDelivery.GetAll();
                cbPurchasedelivery.ItemsSource = this.purchasedeliveries;
                cbPurchasedelivery.SelectedValuePath = "IdPengirimanBarangPembelian";
                cbPurchasedelivery.DisplayMemberPath = "NoOrderPembelian";
            }
        }
        private void PD_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.purchaseDeliverySelected = null;
            if (cbPurchasedelivery.SelectedItem != null)
            {
                this.purchaseDeliverySelected = (Purchasedelivery)cbPurchasedelivery.SelectedItem;
            }
        }
        public void LoadDataSku()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.orderProdukBelis = uow.OrderProdukBeli.GetAll().Where(m => m.Checkboxaktif == true);
                DGSKUReceivedGood.ItemsSource = this.orderProdukBelis;
                int sum = 0;
                for (int i = 0; i < DGSKUReceivedGood.Items.Count; i++)
                {
                    sum += Convert.ToInt32((DGSKUReceivedGood.Items[i] as OrderProdukBeli).TotalPajakProduk);
                }
                txtTotalTax.Text = sum.ToString();
                int sumar = 0;
                for (int i = 0; i < DGSKUReceivedGood.Items.Count; i++)
                {
                    sumar += Convert.ToInt32((DGSKUReceivedGood.Items[i] as OrderProdukBeli).TotalOrderProduk);
                }
                txtTotalbeforeTax.Text = sumar.ToString();
                int suma = 0;
                for (int i = 0; i < DGSKUReceivedGood.Items.Count; i++)
                {
                    suma += Convert.ToInt32((DGSKUReceivedGood.Items[i] as OrderProdukBeli).TotalOrderProduk);
                }
                txtAfterTotalTax.Text = (float.Parse(suma.ToString()) + float.Parse(txtTotalTax.Text)).ToString();
         //       txtoutstanding.Text = txtAfterTotalTax.Text;
            }
        }
        
        private void LoadPO()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.purchaseOrders = uow.PurchaseOrder.GetAll();
                cbPurchaseorder.ItemsSource = this.purchaseOrders;
                cbPurchaseorder.SelectedValuePath = "IdOrderPembelian";
                cbPurchaseorder.DisplayMemberPath = "NoOrderPembelian";
            }
        }
        private void PO_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.purchaseOrderSelected = null;
            if (cbPurchaseorder.SelectedItem != null)
            {
                this.purchaseOrderSelected = (PurchaseOrder)cbPurchaseorder.SelectedItem;
            }
        }
        public void LoadPaymentTerms()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.termspembayarans = uow.Termspembayaran.GetAll();
                cbPayment.ItemsSource = this.termspembayarans;
                cbPayment.SelectedValuePath = "Id";
                cbPayment.DisplayMemberPath = "NamaSkema";
            }
        }
        private void payment_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.termspembayaranSelected = null;
            if (cbPayment.SelectedItem != null)
            {
                termspembayaranSelected = (Termspembayaran)cbPayment.SelectedItem;
            }
        }
        public void LoadStaff()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "employee");
                srstaff.ItemsSource = this.kontaks;
            }
        }
        private void LoadLokasi()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.lokasis = uow.Lokasi.GetAll();
                cbLocation.ItemsSource = this.lokasis;
                cbLocation.SelectedValuePath = "Id";
                cbLocation.DisplayMemberPath = "NamaTempatLokasi";
            }
        }
        private void LoadCash()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dropdownBankKas = uow.DropdownBankKas.GetAll();
                cbCash.ItemsSource = this.dropdownBankKas;
                cbCash.SelectedValuePath = "Id";
                cbCash.DisplayMemberPath = "DropdownBankkas";
            }
        }
        

        private void LoadAnnual()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.optionAnnuals = uow.OptionAnnual.GetAll();
                cbAnnual.ItemsSource = this.optionAnnuals;
                cbAnnual.SelectedValuePath = "IdOptionAnnual";
                cbAnnual.DisplayMemberPath = "Annual";
            }
        }
        public void LoadVendor()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "vendor"); 
                srvendor.ItemsSource = this.kontaks;
            }
        }
        private void vendor_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.kontakSelected = null;
            if (srvendor.SelectedItem != null)
            {
                this.kontakSelected = (Kontak)srvendor.SelectedItem;
                txtemail.Text = this.kontakSelected.EmailA;
                txthp.Text = this.kontakSelected.NoHPA;
            }

        }
        public void LoadNoDokumen()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dokumens = uow.Dokumen.GetAll();
                srnodokumen.ItemsSource = this.dokumens;
            }
        }

        private void LoadCurrency()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataMataUangs = uow.DataMataUang.GetAll().Where(m => m.CheckBoxAktif == true);
                cbCurrency.ItemsSource = this.dataMataUangs;
                cbCurrency.SelectedValuePath = "Id";
                cbCurrency.DisplayMemberPath = "NamaMataUang";
            }
        }
        public void LoadDepartmen()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataDepartemens = uow.DataDepartemen.GetAll();
                cbDepartment.ItemsSource = this.dataDepartemens;
                cbDepartment.SelectedValuePath = "Id";
                cbDepartment.DisplayMemberPath = "NamaDepartemen";
            }
        }

        public void LoadProyek()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataProyeks = uow.DataProyek.GetAll();
                cbProyek.ItemsSource = this.dataProyeks;
                cbProyek.SelectedValuePath = "Id";
                cbProyek.DisplayMemberPath = "NamaProyek";
            }
        }
        private void staff_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.kontakSelected = null;
            if (srstaff.SelectedItem != null)
            {
                this.kontakSelected = (Kontak)srstaff.SelectedItem;
            }
        }
        private void cash_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.dropdownBankKasSelected = null;
            if (cbCash.SelectedItem != null)
            {
                this.dropdownBankKasSelected = (DropdownBankKas)cbCash.SelectedItem;
            }
        }
        private void currency_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.DataMataUangSelected = null;
            if (cbCurrency.SelectedItem != null)
            {
                this.DataMataUangSelected = (DataMataUang)cbCurrency.SelectedItem;
            }
        }

        private void dokumen_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.dokumenSelected = null;
            if (srnodokumen.SelectedItem != null)
            {
                this.dokumenSelected = (Dokumen)srnodokumen.SelectedItem;
            }
        }
        private void lokasi_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.lokasiSelected = null;
            if (cbLocation.SelectedItem != null)
            {
                this.lokasiSelected = (Lokasi)cbLocation.SelectedItem;
            }
        }
        private void department_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.dataDepartemenSelected = null;
            if (cbDepartment.SelectedItem != null)
            {
                dataDepartemenSelected = (DataDepartemen)cbDepartment.SelectedItem;
            }
        }
        private void proyek_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.dataProyekSelected = null;
            if (cbProyek.SelectedItem != null)
            {
                dataProyekSelected = (DataProyek)cbProyek.SelectedItem;
            }
        }
        private void annual_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.optionAnnualSelected = null;
            if (cbAnnual.SelectedItem != null)
            {
                this.optionAnnualSelected = (OptionAnnual)cbAnnual.SelectedItem;
            }
        }
        
        private void vendor_Click(object sender, RoutedEventArgs e)
        {
           
        }
        public void dokumen_Click(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Document.Documentgood)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                Document.Documentgood newdokumen = new Document.Documentgood(this);
                newdokumen.Show();
            }
        }

        public Receivedgood GetData()
        {
            Receivedgood oData = new Receivedgood();
         
            
            oData.NoOrder = txtReceivedNumber.Text;
            oData.Keterangan = txtNote.Text;
            oData.TanggalPengiriman = DateTime.Parse(dtDelivery.Text);
            oData.DurasiBerulang = double.Parse(txtAnnualFrequency.Text);
            oData.TanggalBerulang = DateTime.Parse(dtAnnual.Text);
            
            if (this.DataMataUangSelected != null)
            {
                oData.IdMataUang = this.DataMataUangSelected.Id;
                oData.MataUang = this.DataMataUangSelected.NamaMataUang;
                oData.KursTukar = this.DataMataUangSelected.KursTukar;
            }
            if (this.dokumenSelected != null)
            {
                oData.IdNoReferensiDokumen = this.dokumenSelected.Id;
                oData.NoReferensiDokumentNi = this.dokumenSelected.NoReferensiDokumen;
            }
            
           
            if (this.lokasiSelected != null)
            {
                oData.IdLokasi = this.lokasiSelected.Id;
                oData.NamaLokasi = this.lokasiSelected.NamaTempatLokasi;
            }
            if (this.dataDepartemenSelected != null)
            {
                oData.IdDepartmen = this.dataDepartemenSelected.Id;

            }
            if (this.dataProyekSelected != null)
            {
                oData.IdProyek = this.dataProyekSelected.Id;

            }
            if (this.optionAnnualSelected != null)
            {
                oData.IdOptionAnnual = this.optionAnnualSelected.IdOptionAnnual;
                oData.Annual = this.optionAnnualSelected.Annual;
            }
            if (this.kontakSelected != null)
            {
                oData.IdPetugas = this.kontakSelected.Id;
                oData.NamaPetugas = this.kontakSelected.NamaA;
            }
            if (this.termspembayaranSelected != null)
            {
                oData.IdPaymentTerm = this.termspembayaranSelected.IdTermPembayaran;
                oData.PaymentTerm = this.termspembayaranSelected.NamaSkema;
            }

            oData.CheckManual = chkManual.IsChecked;
            oData.CheckboxInclusiveTax = chktax.IsChecked;
            oData.CheckboxBerulang = chkannual.IsChecked;

            return oData;
        }

        private void Savereceivedgood_Click(object sender, RoutedEventArgs e)
        {
            if (dtReceived.Text == "" || cbCurrency.Text == "" || txtReceivedNumber.Text == "" || cbPurchasedelivery.Text == "" || cbPurchaseorder.Text == "" || cbCash.Text == "" || cbLocation.Text == "" || dtDelivery.Text == "" || cbAnnual.Text == "" || txtAnnualFrequency.Text == "" || dtAnnual.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ReceivedGoodsBLL goodBLL = new ReceivedGoodsBLL();
            ReceivedGoodsBLL GoodBLL = new ReceivedGoodsBLL();
            Receivedgood receivedgood = new Receivedgood();
            receivedgood.IdKodeTransaksi = 8;
            receivedgood.KodeTransaksi = "PJ";
            receivedgood.IdPeriodeAkutansi = 1;
            receivedgood.NoOrder = txtReceivedNumber.Text;
            if (this.kontakSelected != null)
            {
                receivedgood.IdVendor = this.kontakSelected.Id;
                receivedgood.NamaVendor = this.kontakSelected.NamaA;
            }
            receivedgood.Email = txtemail.Text;
            receivedgood.NoHp = txthp.Text;
            receivedgood.TanggalOrder = DateTime.Parse(dtReceived.Text);
            if (this.DataMataUangSelected != null)
            {
                receivedgood.IdMataUang = this.DataMataUangSelected.Id;
                receivedgood.MataUang = this.DataMataUangSelected.KodeMataUang;
                receivedgood.KursTukar = this.DataMataUangSelected.KursTukar;
            }
            if (this.dokumenSelected != null)
            {
                receivedgood.IdNoReferensiDokumen = this.dokumenSelected.Id;
                receivedgood.NoReferensiDokumentNi = this.dokumenSelected.NoReferensiDokumen;
            }
            receivedgood.NoOrderPembeliaan = double.Parse(txtReceivedNumber.Text);
            if (this.purchaseDeliverySelected != null)
            {
                receivedgood.IdPD = this.purchaseDeliverySelected.IdPengirimanBarangPembelian;
                receivedgood.NoPD = this.purchaseDeliverySelected.NoPengirimanBarangPembelian;
            }
            if (this.purchaseOrderSelected != null)
            {
                receivedgood.IdOrderPembeliaan = this.purchaseOrderSelected.IdOrderPembelian;
                receivedgood.NoOrderPembeliaan = this.purchaseOrderSelected.NoOrderPembelian;
            }
            if (this.dropdownBankKasSelected != null)
            {
                receivedgood.IdBankCash = this.dropdownBankKasSelected.Id;
                receivedgood.BankCash = this.dropdownBankKasSelected.DropdownBankkas;
            }
            if (this.lokasiSelected != null)
            {
                receivedgood.IdLokasi = this.lokasiSelected.Id;
                receivedgood.NamaLokasi = this.lokasiSelected.NamaTempatLokasi;
            }
            receivedgood.Keterangan = txtNote.Text;
            if (this.dataDepartemenSelected != null)
            {
                receivedgood.IdDepartmen = this.dataDepartemenSelected.Id;
            }
            if (this.dataProyekSelected != null)
            {
                receivedgood.IdProyek = this.dataProyekSelected.Id;
            }
            receivedgood.CheckboxInclusiveTax = chktax.IsChecked;
            receivedgood.TanggalPengiriman = DateTime.Parse(dtDelivery.Text);
            receivedgood.CheckboxBerulang = chkannual.IsChecked;
            if (this.optionAnnualSelected != null)
            {
                receivedgood.IdOptionAnnual = this.optionAnnualSelected.IdOptionAnnual;
                receivedgood.Annual = this.optionAnnualSelected.Annual;
            }
            if (this.kontakSelected != null)
            {
                receivedgood.IdPetugas = this.kontakSelected.Id;
                receivedgood.NamaPetugas = this.kontakSelected.NamaA;
            }
            receivedgood.CicilanPerbulan = double.Parse(txtAnnualFrequency.Text);
            receivedgood.TanggalBerulang = DateTime.Parse(dtAnnual.Text);
            receivedgood.TotalSebelumPajak = double.Parse(txtTotalbeforeTax.Text);
            receivedgood.TotalPajak = double.Parse(txtTotalTax.Text);
            receivedgood.TotalDebitAkunPajakProduk = double.Parse(txtTotalTax.Text);
            receivedgood.TotalDebitAkunPersediaanProduk = double.Parse(txtTotalbeforeTax.Text);
            receivedgood.TotalSetelahPajak = double.Parse(txtAfterTotalTax.Text);
            //receivedgood.SaldoTerhutang = double.Parse(txtoutstanding.Text);
            
            receivedgood.RealRecordingTime = DateTime.Now;
            if (GoodBLL.AddReceivedGoods(receivedgood) > 0)
            {
                //  this.ClearForm();
                MessageBox.Show("Received Good successfully added !");
            }
            else
            {
                MessageBox.Show("Received Good failed to add !");
            }
            if (DGSKUReceivedGood.Items.Count > 0)
            {
                foreach (var item in DGSKUReceivedGood.Items)
                {
                    if (item is OrderProdukBeli)
                    {
                        OrderProdukBeli oNewData1 = (OrderProdukBeli)item;
                        oNewData1.Tanggal = DateTime.Parse(dtReceived.Text);
                        if (this.lokasiSelected != null)
                        {
                            oNewData1.IdLokasi = this.lokasiSelected.Id;
                            oNewData1.NamaLokasi = this.lokasiSelected.NamaTempatLokasi;
                        }
                        if (this.dataDepartemenSelected != null)
                        {
                            oNewData1.IdDepartemen = this.dataDepartemenSelected.Id;
                        }
                        if (this.dataProyekSelected != null)
                        {
                            oNewData1.IdProyek = this.dataProyekSelected.Id;
                        }
                        receivedgood.IdAkunPersediaanProduk = oNewData1.AkunPersediaan;
                        oNewData1.Checkboxaktif = false;
                        if (goodBLL.EditOrderProdukbeli(oNewData1, receivedgood) == true)
                        {
                        }
                    }
                }
                }
                ReceivedGood v = new ReceivedGood();
            Switcher.Switchnewreceived(v);
        }

        private void produk_Click(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Sku)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                Sku newsku = new Sku(this);
                newsku.Show();
            }
        }
        private void service_Click(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Skuservice)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                Skuservice newsku = new Skuservice(this);
                newsku.Show();
            }
        }
        private void custom_Click(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Sku)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                Sku newsku = new Sku(this);
                newsku.Show();
            }
        }
        private void StockList_Click(object sender, RoutedEventArgs e)
        {

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

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            ReceivedGood v = new ReceivedGood();
            Switcher.Switchnewreceived(v);
        }

        
        private void Custom_Click(object sender, RoutedEventArgs e)
        {

        }
        private void notes_Click(object sender, RoutedEventArgs e)
        {

        }
        private void saveasdraft_Click(object sender, RoutedEventArgs e)
        {

        }
        private void saveaspdf_Click(object sender, RoutedEventArgs e)
        {

        }
        private void duplicate_Click(object sender, RoutedEventArgs e)
        {

        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TxtReceivedNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtReceivedNumber.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtReceivedNumber.Text = "";
                    return;
                }

            }
        }

        private void TxtAnnualFrequency_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtAnnualFrequency.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtAnnualFrequency.Text = "";
                    return;
                }

            }
        }
        private void rbPayment_Checked(object sender, RoutedEventArgs e)
        {
            this.rbPayment.IsChecked = true;
            {
                cbPayment.Visibility = Visibility.Visible;
                cbCash1.Visibility = Visibility.Hidden;
                cbCash1.SelectedIndex = -1;
                this.LoadPaymentTerms();
            }
        }

        private void rbCash_Checked(object sender, RoutedEventArgs e)
        {
            this.rbCash.IsChecked = true;
            {
                cbCash1.Visibility = Visibility.Visible;
                cbPayment.Visibility = Visibility.Hidden;
                cbPayment.SelectedIndex = -1;
                //    this.lo();
            }
        }
        private void Rbdepartmen_Checked(object sender, RoutedEventArgs e)
        {
            this.rbdepartmen.IsChecked = true;
            {
                cbDepartment.Visibility = Visibility.Visible;
                cbProyek.Visibility = Visibility.Hidden;
                cbProyek.SelectedIndex = -1;
                this.LoadDepartmen();
            }
        }

        private void Rbproyek_Checked(object sender, RoutedEventArgs e)
        {
            this.rbproyek.IsChecked = true;
            {
                cbProyek.Visibility = Visibility.Visible;
                cbDepartment.Visibility = Visibility.Hidden;
                cbDepartment.SelectedIndex = -1;
                this.LoadProyek();
            }
        }

        
    }
}
             
    

