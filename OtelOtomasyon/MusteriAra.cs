using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyon
{
    public partial class MusteriAra : Form
    {
        SqlCommand komut;
        public MusteriAra()
        {
            InitializeComponent();
        }

        private void btn_guncel_Click(object sender, EventArgs e)
        {
            /*try
            {
                //komut yazılmadan önce tanımlanmalı
                SqlCommand ekleme_komutu = new SqlCommand("UPDATE  Personel SET Ad=@Ad,Soyad=@Soyad,Yas=@Yas,Tarih=@Tarih,Onay=@Onay WHERE ID=@ID ", Baglanti.baglanti);

                ekleme_komutu.Parameters.AddWithValue("@ID", liste.CurrentRow.Cells[0].Value);
                //değerleri parametre olarak göndereceğiz
                ekleme_komutu.Parameters.AddWithValue("@Ad", Ad.Text);
                ekleme_komutu.Parameters.AddWithValue("@Soyad", Soyad.Text);
                ekleme_komutu.Parameters.AddWithValue("@Yas", int.Parse(Yas.Text));
                ekleme_komutu.Parameters.AddWithValue("@Tarih", Tarih.Text);
                ekleme_komutu.Parameters.AddWithValue("@Onay", durum);
                

                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                ekleme_komutu.ExecuteNonQuery();
                Sql_Baglan();
                MessageBox.Show("Veri başarı ile güncellendi");
                baglanti.Close();
            }
            catch (SqlException)//veritabanından gelen hataları yakalamak için yani sadece sql kodlarını kullandığımzda
            {
                MessageBox.Show("Bir hata oluştu.Güncellenemedi");
            }
            KayitGirisi kayit = new KayitGirisi();
            kayit.Show();*/
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MusteriSorgula()
        {
            SqlDataAdapter tablo = new SqlDataAdapter(komut);
            DataTable veriler = new DataTable();
            tablo.Fill(veriler);
            liste.DataSource = veriler;
            komut.ExecuteNonQuery();
        }
        private void btn_bul_Click(object sender, EventArgs e)
        {
            Baglanti.Baglan();
            if (cbox_ara.SelectedIndex==0)
            {
                komut = new SqlCommand("SELECT * FROM Musteriler WHERE MusteriNo='"+tbox_ara.Text+"'",Baglanti.baglanti);
            }
           else if (cbox_ara.SelectedIndex==1)
            {
               komut = new SqlCommand("SELECT * FROM Musteriler WHERE TCKimlik='"+tbox_ara.Text+"'",Baglanti.baglanti);
            }
            else
            {
               komut = new SqlCommand("SELECT * FROM Musteriler WHERE Ad+' '+Soyad='" + tbox_ara.Text+ "'", Baglanti.baglanti);
            }
            MusteriSorgula();
            Baglanti.Kapat();
        }
        private void btn_tumu_listele_Click(object sender, EventArgs e)
        {
            Baglanti.Baglan();
            komut = new SqlCommand("SELECT * FROM Musteriler ", Baglanti.baglanti);
            MusteriSorgula(); 
            Baglanti.Kapat();
        }
    }
}
