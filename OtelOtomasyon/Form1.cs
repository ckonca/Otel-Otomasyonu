using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyon
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaMenu ana_menu = new AnaMenu();
            if ((text_kullanici.TextLength )!= 0 && (text_sifre.TextLength!= 0))
            {
                ana_menu.Show();
                this.Visible=false;
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz");
            }
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
