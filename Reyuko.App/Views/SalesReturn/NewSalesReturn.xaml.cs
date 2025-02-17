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

namespace Reyuko.App.Views.SalesReturn
{
    /// <summary>
    
    /// </summary>
    public partial class NewSalesReturn : UserControl
    {
        public NewSalesReturn()
        {
            InitializeComponent();
            Switcher.pageSwitchNewSalesReturn = this;
            this.Init();
        }
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        public IEnumerable<Kontak> kontaks { get; set; }
        public Kontak kontakSelected { get; set; }
        private IEnumerable<DataMataUang> dataMataUangs { get; set; }
        private DataMataUang DataMataUangSelected { get; set; }
        private IEnumerable<invoice> invoices { get; set; }
        public Kontak petugasSelected;
        private invoice invoiceSelected;
        public IEnumerable<Dokumen> dokumens { get; set; }
        public Dokumen dokumenSelected { get; set; }
        public IEnumerable<Lokasi> lokasi { get; set; }
        public Lokasi lokasiSelected { get; set; }
        public IEnumerable<OptionAnnual> optionAnnuals { get; set; }
        public OptionAnnual optionAnnualSelected { get; set; }
        public IEnumerable<DataDepartemen> dataDepartemens { get; set; }
        public DataDepartemen Selectdepartment { get; set; }
        public IEnumerable<DataProyek> dataProyeks { get; set; }
        public IEnumerable<Termspembayaran> termspembayarans { get; set; }
        public Termspembayaran termspembayaranSelected;
        public IEnumerable<DropdownBankKas> dropdownBankkas { get; set; }
        public DropdownBankKas dropdownBankkasSelected;
        public IEnumerable<OrderProdukJual> orderProdukJuals { get; set; }
        public DataProyek Selectproyek { get; set; }
        public DataDepartemen dataDepartemenSelected;
        public DataProyek dataProyekSelected;

    
        private void Init()
        {
            this.ClearForm();
            this.LoadCustomer();
            this.LoadNoDokumen();
            this.LoadCurrency();
            this.LoadLokasi();
            this.LoadAnnual();
            this.LoadStaff();
            this.LoadnoInvoice();
            this.LoadCash();
            
        }
        private void ClearForm()
        {
            srcustomer.Text = "";
            txtemail.Text = "";
            txthp.Text = "";
            dtSales.Text = DateTime.Now.ToShortDateString();
            this.DataMataUangSelected = null;
            cbCurrency.SelectedIndex = -1;
            srnodokumen.Text = "";
            txtsalesreturnno.Text = "";
            txtNote.Text = "";
            this.lokasiSelected = null;
            cbLocation.SelectedIndex = -1;
            cbDepartment.SelectedIndex = -1;
            cbProyek.SelectedIndex = -1;
            chkinclusive.IsChecked = false;
            dtDelivery.Text = DateTime.Now.ToShortDateString();
            chkannual.IsChecked = false;
            this.optionAnnualSelected = null;
            cbAnnual.SelectedIndex = -1;
            txtAnnualFrequency.Text = "";
            dtAnnual.Text = DateTime.Now.ToShortDateString();
            txtTotalTax.Text = "";
            txtAfterTotalTax.Text = "";
            txtoutstanding.Text = "";
        }
        public void LoadCustomer()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "pelanggan");
                srcustomer.ItemsSource = this.kontaks;
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
        public void LoadCash()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dropdownBankkas = uow.DropdownBankKas.GetAll();
                cbCash.ItemsSource = this.dropdownBankkas;
                cbCash.SelectedValuePath = "Id";
                cbCash.DisplayMemberPath = "DropdownBankkas";
            }
        }
        public void LoadnoInvoice()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.invoices = uow.Invoice.GetAll();
                cbinvoiceNumber.ItemsSource = this.invoices;
                cbinvoiceNumber.SelectedValuePath = "Id";
                cbinvoiceNumber.DisplayMemberPath = "NoInvoice";
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
        private void department_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.dataDepartemenSelected = null;
            if (cbDepartment.SelectedItem != null)
            {
                dataDepartemenSelected = (DataDepartemen)cbDepartment.SelectedItem;
            }
        }
        private void cash_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.dropdownBankkasSelected = null;
            if (cbCash.SelectedItem != null)
            {
                dropdownBankkasSelected = (DropdownBankKas)cbCash.SelectedItem;
            }
        }
        private void staff_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.petugasSelected = null;
            if (srstaff.SelectedItem != null)
            {
                this.petugasSelected = (Kontak)srstaff.SelectedItem;
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

        private void LoadLokasi()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.lokasi = uow.Lokasi.GetAll();
                cbLocation.ItemsSource = this.lokasi;
                cbLocation.SelectedValuePath = "Id";
                cbLocation.DisplayMemberPath = "NamaTempatLokasi";
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

        private void customer_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.kontakSelected = null;
            if (srcustomer.SelectedItem != null)
            {
                this.kontakSelected = (Kontak)srcustomer.SelectedItem;
                txtemail.Text = this.kontakSelected.EmailA;
                txthp.Text = this.kontakSelected.NoHPA;
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
        private void noinvoice_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.invoiceSelected = null;
            if (cbinvoiceNumber.SelectedItem != null)
            {
                this.invoiceSelected = (invoice)cbinvoiceNumber.SelectedItem;
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
        private void annual_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.optionAnnualSelected = null;
            if (cbAnnual.SelectedItem != null)
            {
                this.optionAnnualSelected = (OptionAnnual)cbAnnual.SelectedItem;
            }
        }

       
        private void Savesales_Click(object sender, RoutedEventArgs e)
        {
            if (srcustomer.Name == "" || txtemail.Name == "" || txthp.Name == "" || dtSales.Text == "" || cbCurrency.Text == "" || txtsalesreturnno.Text == "" || cbLocation.Text == "" || dtDelivery.Text == "" || srstaff.Name == "" || txtAnnualFrequency.Text == "" || dtAnnual.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            SalesreturnBLL returnBLL = new SalesreturnBLL();
            SalesreturnBLL ReturnBLL = new SalesreturnBLL();
            Salesreturn salesreturn = new Salesreturn();
            if (this.kontakSelected != null)
            {
                salesreturn.IdPelanggan = this.kontakSelected.Id;
                salesreturn.NamaPelanggan = this.kontakSelected.NamaA;
            }
            salesreturn.Email = txtemail.Text;
            salesreturn.NoHp = txthp.Text;
            salesreturn.TanggalReturPenjualan = DateTime.Parse(dtSales.Text);
            if (this.DataMataUangSelected != null)
            {
                salesreturn.IdMataUang = this.DataMataUangSelected.Id;
                salesreturn.MataUang = this.DataMataUangSelected.NamaMataUang;
                salesreturn.KursTukar = this.DataMataUangSelected.KursTukar;
            }
            if (this.dokumenSelected != null)
            {
                salesreturn.IdNoReferensiDokumen = this.dokumenSelected.Id;
                salesreturn.NoReferensiDokumen = this.dokumenSelected.NoReferensiDokumen;
            }
            salesreturn.NoReturPenjualan = txtsalesreturnno.Text;
            if (this.invoiceSelected != null)
            {
                salesreturn.IdReferalTransaksi = this.invoiceSelected.IdOrderPenjualan;
                salesreturn.NoReferensiTransaksi = this.invoiceSelected.NoOrderPenjualan;
            }
            salesreturn.Keterangan = txtNote.Text;
            if (this.lokasiSelected != null)
            {
                salesreturn.IdLokasi = this.lokasiSelected.Id;
                salesreturn.NamaLokasi = this.lokasiSelected.NamaTempatLokasi;
            }
            if (this.dataDepartemenSelected != null)
            {
                salesreturn.IdDepartemen = this.dataDepartemenSelected.Id;
            }
            if (this.dataProyekSelected != null)
            {
                salesreturn.IdProyek = this.dataProyekSelected.Id;
            }
            salesreturn.CheckboxInclusiveTax = chkinclusive.IsChecked;
            salesreturn.TanggalPengantaran = DateTime.Parse(dtDelivery.Text);
            salesreturn.DurasiBerulang = double.Parse(txtAnnualFrequency.Text);
            salesreturn.TanggalBerulang = DateTime.Parse(dtAnnual.Text);
            if (this.optionAnnualSelected != null)
            {
                salesreturn.IdOpsiAnnual = this.optionAnnualSelected.IdOptionAnnual;
                salesreturn.Annual = this.optionAnnualSelected.Annual;
            }
            if (this.petugasSelected != null)
            {
                salesreturn.IdPetugas = this.petugasSelected.Id;
                salesreturn.NamaPetugas = this.petugasSelected.NamaA;
            }
            if (this.invoiceSelected != null)
            {
                salesreturn.IdTransaksi = this.invoiceSelected.IdTransaksi;
            }
            salesreturn.Checkboxberulang = chkannual.IsChecked;
            salesreturn.IdKodeTransaksi = 25;
            salesreturn.KodeTransaksi = "SR";
            salesreturn.IdPeriodeAkuntansi = 1;
            salesreturn.RealRecongitionTime = DateTime.Now;
            salesreturn.TotalSebelumPajak = double.Parse(txtTotalbeforeTax.Text);
            salesreturn.TotalPajak = double.Parse(txtTotalTax.Text);
            salesreturn.TotalSetelahPajak = double.Parse(txtAfterTotalTax.Text);
            if (ReturnBLL.AddSalesreturns(salesreturn) > 0)
            {
                //  this.ClearForm();
                MessageBox.Show("Sales Return successfully added !");
            }
            else
            {
                MessageBox.Show("Sales Return failed to add !");
            }
            SalesReturn v = new SalesReturn();
            Switcher.SwitchNewSalesReturn(v);
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
        public void LoadDataSku()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.orderProdukJuals = uow.OrderProdukJual.GetAll().Where(m => m.Checkbokaktif == true);
                DGSKUSalesReturn.ItemsSource = this.orderProdukJuals;
                int sum = 0;
                for (int i = 0; i < DGSKUSalesReturn.Items.Count; i++)
                {
                    sum += Convert.ToInt32((DGSKUSalesReturn.Items[i] as OrderProdukJual).TotalPajakProduk);
                }
                txtTotalTax.Text = sum.ToString();
                int sumar = 0;
                for (int i = 0; i < DGSKUSalesReturn.Items.Count; i++)
                {
                    sumar += Convert.ToInt32((DGSKUSalesReturn.Items[i] as OrderProdukJual).HargaJual);
                }
                txtTotalbeforeTax.Text = sumar.ToString();
                int suma = 0;
                for (int i = 0; i < DGSKUSalesReturn.Items.Count; i++)
                {
                    suma += Convert.ToInt32((DGSKUSalesReturn.Items[i] as OrderProdukJual).TotalOrderProduk);
                }
                txtAfterTotalTax.Text = (float.Parse(suma.ToString()) + float.Parse(txtTotalTax.Text)).ToString();
                txtoutstanding.Text = txtAfterTotalTax.Text;
            }
        }
        private void btnsku(object sender, RoutedEventArgs e)
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

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            SalesReturn v = new SalesReturn();
            Switcher.SwitchNewSalesReturn(v);
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
     
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void TxtInvoiceNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtsalesreturnno.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtsalesreturnno.Text = "";
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

        private void TxtNote_TextChanged(object sender, TextChangedEventArgs e)
        {

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

        private void rbpayment_Checked(object sender, RoutedEventArgs e)
        {
            this.rbpayment.IsChecked = true;
            {
                cbPayment.Visibility = Visibility.Visible;
                cbCash1.Visibility = Visibility.Hidden;
                cbCash1.SelectedIndex = -1;
                this.LoadPaymentTerms();
            }
        }

        private void rbcash_Checked(object sender, RoutedEventArgs e)
        {
            this.rbcash.IsChecked = true;
            {
                cbCash1.Visibility = Visibility.Visible;
                cbPayment.Visibility = Visibility.Hidden;
                cbPayment.SelectedIndex = -1;
            //    this.lo();
            }
        }
    }
}
             
    

