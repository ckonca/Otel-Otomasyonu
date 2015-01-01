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
    public partial class OdaListele : Form
    {
        List<string> odalar = new List<string>();
        List<string> oda_limit = new List<string>();
        List<string> oda_durum = new List<string>();
        SqlDataReader oku;
        bool yesil=false, kirmizi=false;
        public OdaListele()
        {
            InitializeComponent();
        }

        private void OdaListele_Load(object sender, EventArgs e)
        {
            dtGrView.Visible = false;
            gBox.Controls.Clear();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtn_dolu_CheckedChanged(object sender, EventArgs e)
        {
            gBox.Controls.Clear();
            dtGrView.Visible = true;
            gBox.Text = rbtn_dolu.Text;
            SqlCommand cmd = new SqlCommand("SELECT Isim,Oda_id,Limit FROM Odalar WHERE Durum='Dolu'", Baglanti.baglanti);
            kirmizi = true;
            yesil = false;
            Oda_Getir(cmd,kirmizi,yesil);
        }
        private void rbtn_tum_CheckedChanged(object sender, EventArgs e)
        {
            gBox.Controls.Clear();
            gBox.Text = rbtn_tum.Text;
            SqlCommand cmd = new SqlCommand("SELECT Isim,Oda_id,Limit,Durum FROM Odalar", Baglanti.baglanti);
            kirmizi = true;
            yesil = true;
            Oda_Getir(cmd, kirmizi, yesil);
        }

        private void rbtn_bos_CheckedChanged(object sender, EventArgs e)
        {
            gBox.Controls.Clear();
            gBox.Text = rbtn_bos.Text;
            SqlCommand cmd = new SqlCommand("SELECT Isim,Oda_id,Limit FROM Odalar WHERE Durum='Boş'", Baglanti.baglanti);
            kirmizi = false;
            yesil = true;
            Oda_Getir(cmd, kirmizi, yesil);
        }
        public void Oda_Getir(SqlCommand cmd,bool renk1,bool renk2)
        {
            
            int oda_sayisi;//oda sayısı kadar buton oluşturmak için(boş/dolu/tümü)
            Baglanti.Baglan();
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                odalar.Add(oku["Isim"].ToString());//odalar listesine oda isimlerini ekliyoruz
                oda_limit.Add(oku["Limit"].ToString());
                oda_durum.Add(oku["Durum"].ToString());
            }
            oku.Close();
            oku.Dispose();
            Baglanti.Kapat();
            oda_sayisi = odalar.Count;
            if (oda_sayisi > 0)
            {
                int x = 10, y = 20;//for buton position
                for (int i = 0; i < oda_sayisi; i++)
                {
                    var buton = new Button();
                    buton.Text = odalar[i].ToString()+"\n"+oda_limit[i]+" kişilik";
                    buton.Width = 140; buton.Height = 50; buton.Location = new Point(x, y);
                    if (renk1==true&&renk2==false)
                    {
                     buton.BackColor = Color.Red;   
                    }
                    else if (renk1==false&&renk2==true)
                    {
                        buton.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        if (oda_durum[i]=="Dolu")
                        {
                            buton.BackColor = Color.Red;  
                        }
                        else
                        {
                            buton.BackColor = Color.YellowGreen;  
                        }
                    }
                    
                    buton.Click += new EventHandler(BosOdalarKlik);
                    x += 160;
                    if (i > 0 && i % 4 == 3)
                    {
                        x = 10; y += 70;
                    }
                    gBox.Controls.Add(buton); //groupBox içinde düzgün görünüm için
                }
            }
        }

        void BosOdalarKlik(object sender, EventArgs e)
        {
            Button gelen = sender as Button;

            KayitGirisi yeni_kayit = new KayitGirisi();
            yeni_kayit.oda_listele = true;
            yeni_kayit.odaIsmi = gelen.Text;
            yeni_kayit.Show();
        }

        

    }
}
