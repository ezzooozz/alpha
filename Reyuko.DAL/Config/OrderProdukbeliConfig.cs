﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class OrderProdukBeliConfig : EntityTypeConfiguration<OrderProdukBeli>
    {
        public OrderProdukBeliConfig()
        {
            this.ToTable("order_produk_beli");
            this.HasKey(m => m.IdOrderProdukBeli);
            this.Property(m => m.IdOrderProdukBeli)
                .HasColumnName("id_order_produk_beli")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdTransaksi)
     .HasColumnName("id_transaksi");

            this.Property(m => m.IdReferralTransaksi)
                .HasColumnName("id_referral_transaksi");

            this.Property(m => m.Tanggal)
                .HasColumnName("tanggal");

            this.Property(m => m.IdLokasi)
                .HasColumnName("id_lokasi");

            this.Property(m => m.NamaLokasi)
                .HasColumnName("nama_lokasi");

            this.Property(m => m.IdProduk)
                .HasColumnName("id_produk");

            this.Property(m => m.ProdukKategori)
                .HasColumnName("produk_kategori");

            this.Property(m => m.Sku)
                .HasColumnName("sku");

            this.Property(m => m.NamaProduk)
                .HasColumnName("nama_produk");

            this.Property(m => m.SatuanDasar)
                .HasColumnName("satuan_dasar");

            this.Property(m => m.DiskonProduk)
                .HasColumnName("diskon_produk");

            this.Property(m => m.HargaBeli)
                .HasColumnName("harga_beli");

            this.Property(m => m.TotalProduk)
                .HasColumnName("total_produk");

            this.Property(m => m.PurchasedBalance)
                .HasColumnName("purchased_balance");

            this.Property(m => m.TotalOrderProduk)
                .HasColumnName("total_order_produk");

            this.Property(m => m.IdPajak)
                .HasColumnName("id_pajak");

            this.Property(m => m.NamaPajak)
                .HasColumnName("nama_pajak");

            this.Property(m => m.PersentasePajak)
                .HasColumnName("persentase_pajak");

            this.Property(m => m.TotalPajakProduk)
                .HasColumnName("total_pajak_produk");

            this.Property(m => m.IdAkunPajakProduk)
                .HasColumnName("id_akun_pajak_produk");

            this.Property(m => m.IdTypeProduk)
                .HasColumnName("id_type_produk");

            this.Property(m => m.TypeProduk)
                .HasColumnName("type_produk");

            this.Property(m => m.AkunPersediaan)
                .HasColumnName("akun_persediaan");

            this.Property(m => m.AkunPengirimanBeli)
                .HasColumnName("akun_pengiriman_beli");

            this.Property(m => m.IdBudget)
                .HasColumnName("id_budget");

            this.Property(m => m.IdProyek)
                .HasColumnName("id_proyek");

            this.Property(m => m.IdDepartemen)
                .HasColumnName("id_departemen"); 

            this.Property(m => m.Checkboxaktif)
                .HasColumnName("checkboxaktif");
        }
    }
}
