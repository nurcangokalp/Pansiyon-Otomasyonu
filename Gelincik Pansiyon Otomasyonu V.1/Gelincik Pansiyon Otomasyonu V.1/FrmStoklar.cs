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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=GelincikPansiyon;Integrated Security=True");

        private void veriler()
        {
            //MessageBox.Show("Test");
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Stoklar", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["İcecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void veriler2()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("select * from Faturalar", baglanti);
            SqlDataReader oku2 = cmd2.ExecuteReader();
            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["Elektrik"].ToString();
                ekle.SubItems.Add(oku2["Su"].ToString());
                ekle.SubItems.Add(oku2["İnternet"].ToString());
                listView2.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void BtnKaydet1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Stoklar (Gida,İcecek,Cerezler) values ('" + TxtGidalar.Text + "' , '" + Txtİcecekler.Text + "' , '" + TxtCerezler.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
           // MessageBox.Show("Test10");
            veriler();

        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {

            veriler();
            veriler2();

        }

        private void BtnKaydet2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("insert into Faturalar (Elektrik,Su,İnternet) values ('" + TxtElektrik.Text + "' , '" + TxtSu.Text + "' , '" + TxtInternet.Text + "')", baglanti);
            cmd2.ExecuteNonQuery();
            baglanti.Close();
            veriler2();

        }
    }
}
