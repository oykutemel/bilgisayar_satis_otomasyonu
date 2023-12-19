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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void personellistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_PERSONELLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            mskTel1.Text = "";
            mskTc.Text = "";
            txtMail.Text = "";
            cmbil.Text = "";
            cmbilce.Text = "";
            rchAdres.Text = "";
            txtGörev.Text = "";
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            personellistele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_PERSONELLER(AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,GOREV) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", mskTel1.Text);
            komut.Parameters.AddWithValue("@P4", mskTc.Text);
            komut.Parameters.AddWithValue("@P5", txtMail.Text);
            komut.Parameters.AddWithValue("@P6", cmbil.Text);
            komut.Parameters.AddWithValue("@P7", cmbilce.Text);
            komut.Parameters.AddWithValue("@P8", rchAdres.Text);
            komut.Parameters.AddWithValue("@P9", txtGörev.Text);
            komut.ExecuteNonQuery();//sorgu çalıştır
            bgl.baglanti().Close();
            MessageBox.Show("Personel sisteme eklendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personellistele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["ID"].ToString();
                txtAd.Text = dr["AD"].ToString();
                txtSoyad.Text = dr["SOYAD"].ToString();
                mskTel1.Text = dr["TELEFON"].ToString();
                mskTc.Text = dr["TC"].ToString();
                txtMail.Text = dr["MAIL"].ToString();
                cmbil.Text = dr["IL"].ToString();
                cmbilce.Text = dr["ILCE"].ToString();
                rchAdres.Text = dr["ADRES"].ToString();
                txtGörev.Text = dr["GOREV"].ToString();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlDataReader sd;
            SqlCommand komut = new SqlCommand("Select * From TBL_PERSONELLER Where ID = @P1;",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtId.Text);

            sd = komut.ExecuteReader();

            if (sd.Read())
            {

                komut = new SqlCommand("Insert Into TBL_S_PERSONEL (ID,AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,GOREV,SIFRE) Values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11);",bgl.baglanti());

                komut.Parameters.AddWithValue("@P1",sd.GetInt32(0));
                komut.Parameters.AddWithValue("@P2", sd.GetString(1));
                komut.Parameters.AddWithValue("@P3", sd.GetString(2));
                komut.Parameters.AddWithValue("@P4", sd.GetString(3));
                komut.Parameters.AddWithValue("@P5", sd.GetString(4));
                komut.Parameters.AddWithValue("@P6", sd.GetString(5));
                komut.Parameters.AddWithValue("@P7", sd.GetString(6));
                komut.Parameters.AddWithValue("@P8", sd.GetString(7));
                komut.Parameters.AddWithValue("@P9", sd.GetString(8));
                komut.Parameters.AddWithValue("@P10", sd.GetString(9));
                komut.Parameters.AddWithValue("@P11", sd.GetString(10));
                //komut.Parameters.AddWithValue("@P12",);
                

                komut.ExecuteNonQuery();



                komut = new SqlCommand("Delete from TBL_PERSONELLER  where ID =@P1", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", txtId.Text);
                komut.ExecuteNonQuery();//sorgu çalıştır
                bgl.baglanti().Close();
                MessageBox.Show("Personel  silindi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                personellistele();
            }
            
           
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_PERSONELLER  set AD=@P1,SOYAD=@P2,TELEFON=@P3,TC=@P4,MAIL=@P5,IL=@P6,ILCE=@P7,ADRES=@P8,GOREV=@P9 WHERE ID=@P10", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", mskTel1.Text);
            komut.Parameters.AddWithValue("@P4", mskTc.Text);
            komut.Parameters.AddWithValue("@P5", txtMail.Text);
            komut.Parameters.AddWithValue("@P6", cmbil.Text);
            komut.Parameters.AddWithValue("@P7", cmbilce.Text);
            komut.Parameters.AddWithValue("@P8", rchAdres.Text);
            komut.Parameters.AddWithValue("@P9", txtGörev.Text);
            komut.Parameters.Add("@P10", txtId.Text);
            komut.ExecuteNonQuery();//sorgu çalıştır
            bgl.baglanti().Close();
            MessageBox.Show("Personel bilgisi güncellendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personellistele();
        }
    }
}
