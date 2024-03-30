
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace Gelincik_Pansiyon_Otomasyonu_V._1
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=GelincikPansiyon;Integrated Security=True");


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from AdminGiris where Kullanici=@Kullaniciadi AND Sifre=@Sifresi";
                SqlParameter spr1 = new SqlParameter("Kullaniciadi",TxtKullaniciAdi.Text.Trim());
                SqlParameter spr2= new SqlParameter("Sifresi",txtSifre.Text.Trim());
                SqlCommand cmd= new SqlCommand(sql,baglanti);
                cmd.Parameters.Add(spr1);
                cmd.Parameters.Add(spr2);

                DataTable dt= new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                if(dt.Rows.Count>0){
                    FrmAna fr = new FrmAna();
                    fr.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("  Hatalý Giriþ!!!  ");
            }

            
        }

        private void TxtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}