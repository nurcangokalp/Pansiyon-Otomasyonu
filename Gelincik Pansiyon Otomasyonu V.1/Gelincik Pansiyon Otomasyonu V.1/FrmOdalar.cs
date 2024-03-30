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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=GelincikPansiyon;Integrated Security=True");


        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            //Oda1
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand("select * from Oda1",baglanti);
            SqlDataReader oku1 = cmd1.ExecuteReader();
            
            while (oku1.Read())
            {
               BtnOda1.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda1.Text != "1")
            {
                BtnOda1.BackColor = Color.Red;
            }
            //Oda2
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("select * from Oda2", baglanti);
            SqlDataReader oku2 = cmd2.ExecuteReader();
           
            while (oku2.Read())
            {
                BtnOda2.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda2.Text != "2")
            {
                BtnOda2.BackColor = Color.Red;
            }
            //Oda3
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("select * from Oda3", baglanti);
            SqlDataReader oku3 = cmd3.ExecuteReader();

            while (oku3.Read())
            {
                BtnOda3.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda3.Text != "3")
            {
                BtnOda3.BackColor = Color.Red;
            }
            //Oda4
            baglanti.Open();
            SqlCommand cmd4 = new SqlCommand("select * from Oda4", baglanti);
            SqlDataReader oku4 = cmd4.ExecuteReader();

            while (oku4.Read())
            {
                BtnOda4.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda4.Text != "4")
            {
                BtnOda4.BackColor = Color.Red;
            }
            //Oda5
            baglanti.Open();
            SqlCommand cmd5 = new SqlCommand("select * from Oda5", baglanti);
            SqlDataReader oku5 = cmd5.ExecuteReader();

            while (oku5.Read())
            {
                BtnOda5.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda5.Text != "5")
            {
                BtnOda5.BackColor = Color.Red;
            }
            //Oda6
            baglanti.Open();
            SqlCommand cmd6 = new SqlCommand("select * from Oda6", baglanti);
            SqlDataReader oku6 = cmd6.ExecuteReader();

            while (oku6.Read())
            {
                BtnOda6.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda6.Text != "6")
            {
                BtnOda6.BackColor = Color.Red;
            }
            //Oda7
            baglanti.Open();
            SqlCommand cmd7 = new SqlCommand("select * from Oda7", baglanti);
            SqlDataReader oku7 = cmd7.ExecuteReader();

            while (oku7.Read())
            {
                BtnOda7.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda7.Text != "7")
            {
                BtnOda7.BackColor = Color.Red;
            }
            //Oda8
            baglanti.Open();
            SqlCommand cmd8 = new SqlCommand("select * from Oda8", baglanti);
            SqlDataReader oku8 = cmd8.ExecuteReader();

            while (oku8.Read())
            {
                BtnOda8.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda8.Text != "8")
            {
                BtnOda8.BackColor = Color.Red;
            }
            //Oda9
            baglanti.Open();
            SqlCommand cmd9 = new SqlCommand("select * from Oda9", baglanti);
            SqlDataReader oku9 = cmd9.ExecuteReader();

            while (oku9.Read())
            {
                BtnOda9.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda9.Text != "9")
            {
                BtnOda9.BackColor = Color.Red;
            }
            //Oda10
            baglanti.Open();
            SqlCommand cmd10 = new SqlCommand("select * from Oda10", baglanti);
            SqlDataReader oku10 = cmd10.ExecuteReader();

            while (oku10.Read())
            {
                BtnOda10.Text = oku10["Adi"].ToString() + " " + oku10["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda10.Text != "10")
            {
                BtnOda10.BackColor = Color.Red;
            }
            //Oda11
            baglanti.Open();
            SqlCommand cmd11 = new SqlCommand("select * from Oda11", baglanti);
            SqlDataReader oku11 = cmd11.ExecuteReader();

            while (oku11.Read())
            {
                BtnOda11.Text = oku11["Adi"].ToString() + " " + oku11["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda11.Text != "11")
            {
                BtnOda11.BackColor = Color.Red;
            }
            //Oda12
            baglanti.Open();
            SqlCommand cmd12 = new SqlCommand("select * from Oda12", baglanti);
            SqlDataReader oku12= cmd12.ExecuteReader();

            while (oku12.Read())
            {
                BtnOda12.Text = oku12["Adi"].ToString() + " " + oku12["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda12.Text != "12")
            {
                BtnOda12.BackColor = Color.Red;
            }

        }

        private void BtnOda2_Click(object sender, EventArgs e)
        {

        }
        private void BtnOda1_Click(object sender, EventArgs e)
        {

        }
    }
}
