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
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
        }
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayitGirisi yeni_kayit = new KayitGirisi();
            yeni_kayit.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MusteriAra ara = new MusteriAra();
            ara.Show();
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdaListele listele = new OdaListele();
            listele.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        
    }
}
