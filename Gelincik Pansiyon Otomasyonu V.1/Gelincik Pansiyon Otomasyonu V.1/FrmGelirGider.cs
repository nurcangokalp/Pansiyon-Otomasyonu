using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Gelincik_Pansiyon_Otomasyonu_V._1
{
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=GelincikPansiyon;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt32(textBox1.Text);
            LblPersonelMaas.Text = (personel * 2000).ToString();

            int sonuc;
            sonuc= Convert.ToInt32(LblKasaTutari.Text)-(Convert.ToInt32(LblPersonelMaas.Text) + Convert.ToInt32(LblUrunTutari1.Text) + Convert.ToInt32(LblUrunTutari2.Text) + Convert.ToInt32(LblUrunTutari3.Text) + Convert.ToInt32(LblFaturalar1.Text) + Convert.ToInt32(LblFaturalar2.Text) + Convert.ToInt32(LblFaturalar3.Text));
            LblSonuc.Text = sonuc.ToString();
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            //Kasadaki Toplam Tutar
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select sum(Ucret) as toplam from MusteriKaydet", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                LblKasaTutari.Text = oku["toplam"].ToString();
            }
            baglanti.Close();

            //Gıdaların Toplam Tutarı
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("select sum(Gida) as toplam1 from Stoklar", baglanti);
            SqlDataReader oku2 = cmd2.ExecuteReader();
            while (oku2.Read())
            {
                LblUrunTutari1.Text = oku2["toplam1"].ToString();
            }
            baglanti.Close();

            //İceceklerin Toplam Tutarı
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("select sum(İcecek) as toplam2 from Stoklar", baglanti);
            SqlDataReader oku3 = cmd3.ExecuteReader();
            while (oku3.Read())
            {
                LblUrunTutari2.Text = oku3["toplam2"].ToString();
            }
            baglanti.Close();

            //Cerezlerin Toplam Tutarı
            baglanti.Open();
            SqlCommand cmd4 = new SqlCommand("select sum(Cerezler) as toplam3 from Stoklar", baglanti);
            SqlDataReader oku4 = cmd4.ExecuteReader();
            while (oku4.Read())
            {
                LblUrunTutari3.Text = oku4["toplam3"].ToString();
            }
            baglanti.Close();

            //Elektrik Faturası
            baglanti.Open();
            SqlCommand cmd5 = new SqlCommand("select sum(Elektrik) as toplam4 from Faturalar", baglanti);
            SqlDataReader oku5 = cmd5.ExecuteReader();
            while (oku5.Read())
            {
                LblFaturalar1.Text = oku5["toplam4"].ToString();
            }
            baglanti.Close();

            //Su Faturası
            baglanti.Open();
            SqlCommand cmd6 = new SqlCommand("select sum(Su) as toplam5 from Faturalar", baglanti);
            SqlDataReader oku6 = cmd6.ExecuteReader();
            while (oku6.Read())
            {
                LblFaturalar2.Text = oku6["toplam5"].ToString();
            }
            baglanti.Close();

            //İnternet Faturası
            baglanti.Open();
            SqlCommand cmd7 = new SqlCommand("select sum(İnternet) as toplam6 from Faturalar", baglanti);
            SqlDataReader oku7 = cmd7.ExecuteReader();
            while (oku7.Read())
            {
                LblFaturalar3.Text = oku7["toplam6"].ToString();
            }
            baglanti.Close();


        }

    }
}
