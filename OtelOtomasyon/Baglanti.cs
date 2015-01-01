using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace OtelOtomasyon
{
    public class Baglanti
    {
        //public static SqlConnection baglanti = new SqlConnection("Data Source = PC\\SA;User Id=sa;Password=1234;Initial Catalog=Otomasyon;Integrated Security=true;");
        public static SqlConnection baglanti = new SqlConnection("Data Source=HAZAN\\CEMİLEKONCA;Initial Catalog=Otomasyon;Integrated Security=true;");
        public static void Baglan()
        {
            if (baglanti.State==ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }
        public static void Kapat()
        {
            baglanti.Close();
        }
    }
}
