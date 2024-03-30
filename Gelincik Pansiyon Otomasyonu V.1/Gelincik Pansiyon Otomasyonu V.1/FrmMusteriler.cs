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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti= new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=GelincikPansiyon;Integrated Security=True");

        private void verilerigoster()
        {
            listView1.Items.Clear();

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from MusteriKaydet", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CıkısTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id=int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            TxtKimlikNo.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskdTxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[7].Text;
            DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpCıkıstarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("delete from MusteriKaydet where Musteriid=(" + id + ")", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            TxtKimlikNo.Clear();
            MskdTxtTelefon.Clear();
            TxtMail.Text = " ";
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpGirisTarihi.Text = "";
            DtpCıkıstarihi.Text = "";
           

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update Musterikaydet set Adi='" + TxtAdi.Text + "',Soyadi='" + TxtSoyadi.Text + "',TC='" + TxtKimlikNo.Text + "',Telefon='" + MskdTxtTelefon.Text + "' ,Mail='" + TxtMail.Text + "',OdaNo='" + TxtOdaNo.Text + "',Ucret='" + TxtUcret.Text + "',GirisTarihi='" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "',CıkısTarihi='" + DtpCıkıstarihi.Value.ToString("yyyy-MM-dd") + "' where Musteriid=" + id + "", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from MusteriKaydet where Adi like '%"+ textBox1.Text+"%'" , baglanti);
            SqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CıkısTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }




    }
}
