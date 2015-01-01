using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyon
{
    public partial class KayitGirisi : Form
    {

        public string durum = "kaydet"; // "guncelle" yeni kayıt//güncelle seçeneği için
        public string odaIsmi;
        public bool oda_listele=false;//comboBox_oda_no OdaListele sınıfından mı değer gelecek diye
        SqlCommand komut;
        public KayitGirisi()
        {
            InitializeComponent();
        }
        private void KayitGirisi_Load(object sender, EventArgs e)
        {
            if (oda_listele)
            {
                comboBox_oda_no.Text = odaIsmi.Substring(0,3);
            }
        }
        private void button_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        void Temizle()
        {
            textBox_musteri_no.Clear();
            textBox_ad.Clear();
            textBox_soyad.Clear();
            textBox_tc.Clear();
            textBox_yas.Clear();
            textBox_telefon.Clear();
            textBox_mail.Clear();
            textBox_adres.Clear();
            comboBox_cinsiyet.ResetText();
            comboBox_medeni.ResetText();
            comboBox_oda_no.ResetText();
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            Baglanti.Baglan();
            Kaydet();
            MessageBox.Show("Veri başarı ile kayedildi");
            Baglanti.Kapat();
            
        }
        void Kaydet()
        {
            komut= new SqlCommand("INSERT INTO Musteriler(MusteriNo,TCKimlik,Ad,Soyad,Yas,MedeniHal,Cinsiyet) VALUES (@musteri_no,@tc_kimlik,@ad,@soyad,@yas,@medeni_hal,@cinsiyet) SELECT scope_identity()",Baglanti.baglanti);
            Baglanti.Baglan();
            komut.Parameters.AddWithValue("@musteri_no",textBox_musteri_no.Text);
            komut.Parameters.AddWithValue("@tc_kimlik", textBox_tc.Text);
            komut.Parameters.AddWithValue("@ad",textBox_ad.Text);
            komut.Parameters.AddWithValue("@soyad", textBox_soyad.Text);
            komut.Parameters.AddWithValue("@yas",int.Parse(textBox_yas.Text));
            komut.Parameters.AddWithValue("@medeni_hal",comboBox_medeni.Text);
            komut.Parameters.AddWithValue("@cinsiyet",comboBox_cinsiyet.Text);
            
            int musteri_id = Convert.ToInt32(komut.ExecuteScalar());
            komut = new SqlCommand("INSERT INTO Iletisim_bilgileri(Telefon,Email,Adres,Musteri_id) VALUES (@telefon,@mail,@adres,@musteri_id)", Baglanti.baglanti);
            komut.Parameters.AddWithValue("@telefon",textBox_telefon.Text);
            komut.Parameters.AddWithValue("@mail",textBox_mail.Text);
            komut.Parameters.AddWithValue("@adres",textBox_adres.Text);
            komut.Parameters.AddWithValue("@musteri_id", musteri_id);
            komut.ExecuteNonQuery();
            Baglanti.Kapat();
        }
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_oda_bul_Click(object sender, EventArgs e)
        {
            OdaListele listele = new OdaListele();
            listele.Show();
        }
        private void cBox_tip_SelectedIndexChanged(object sender, EventArgs e)
        {
            Baglanti.Baglan();
            SqlCommand komut = new SqlCommand("SELECT Isim FROM Odalar WHERE Limit='"+(cBox_tip.SelectedIndex+1)+"' AND Durum='Boş'", Baglanti.baglanti);
            SqlDataReader oku;
            try
            {
                oku = komut.ExecuteReader();
                comboBox_oda_no.Items.Clear();
                while (oku.Read())
                {
                    comboBox_oda_no.Items.Add(oku["Isim"].ToString());
                }
                oku.Close();
                oku.Dispose();
                Baglanti.Kapat();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
