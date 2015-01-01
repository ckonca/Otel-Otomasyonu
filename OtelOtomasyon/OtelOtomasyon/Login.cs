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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!(text_kullanici.Text.Length==0&&text_sifre.Text.Length==0))
            {
                Form1 form = new Form1();
                this.Opacity = 0;             //bu ve altaki satır form_load olurken formun visiblşe olması için
                this.ShowInTaskbar = false;
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz");
            }
        }
    }
}
