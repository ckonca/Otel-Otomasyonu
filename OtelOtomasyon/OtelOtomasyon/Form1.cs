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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Opacity = 0;             //bu ve altaki satır form_load olurken formun visiblşe olması için
           // this.ShowInTaskbar = false;
            Login();
        }
        public void Login()
        {
            Login log = new Login();
            log.Show();
        }
    }
}
