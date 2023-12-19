using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Bilgisayar_satış
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            frmAnaModul fr = new frmAnaModul();


            SqlCommand komut = new SqlCommand("Select * From TBL_ADMIN where KullaniciAd=@P1 and Sifre=@P2", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtKullanici.Text);
            komut.Parameters.AddWithValue("@P2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                int kullanici_id = dr.GetInt32(0);
                komut = new SqlCommand("Select * From TBL_K_BILGILER Where K_ID = @P1;", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", kullanici_id);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {

                    fr.unvan = "Admin";
                    fr.kullanici_adi = dr.GetString(2) + " " + dr.GetString(3);


                    fr.Show();
                    this.Hide();
                }

            }
            else
            {
                komut = new SqlCommand("Select * From TBL_PERSONELLER where MAIL=@P1 and SIFRE=@P2", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", txtKullanici.Text);
                komut.Parameters.AddWithValue("@P2", txtSifre.Text);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    fr.unvan = "Personel";
                    fr.kullanici_adi = dr.GetString(1) + " " + dr.GetString(2);


                    fr.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Hatalı girişi hatalı", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            bgl.baglanti().Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtSifre.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtSifre.Properties.UseSystemPasswordChar = true;

            }
        }
    }
}
