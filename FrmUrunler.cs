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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_URUNLER",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // VERİİLERİ KAYDETME
            SqlCommand komut = new SqlCommand(" insert into TBL_URUNLER (ID,URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtId.Text);
            komut.Parameters.AddWithValue("@P2", txtAd.Text);
            komut.Parameters.AddWithValue("@P3", txtMarka.Text);
            komut.Parameters.AddWithValue("@P4", txtModel.Text);
            komut.Parameters.AddWithValue("@P5", mskYıl.Text);
            komut.Parameters.AddWithValue("@P6", int.Parse((nudAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@P7", decimal.Parse((txtAlış.Text).ToString()));
            komut.Parameters.AddWithValue("@P8", decimal.Parse((txtSatış.Text).ToString()));
            komut.Parameters.AddWithValue("@P9", rchDetay.Text);
            komut.ExecuteNonQuery();//sorgu çalıştır
            bgl.baglanti().Close();
            MessageBox.Show("Ürün sisteme eklendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlDataReader sd;
            SqlCommand komut = new SqlCommand("Select * From TBL_URUNLER Where ID = @P1;", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtId.Text);

            sd = komut.ExecuteReader();

            if (sd.Read())
            {

                komut = new SqlCommand("insert into TBL_S_URUN (ID,URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9);", bgl.baglanti());

                komut.Parameters.AddWithValue("@P1", sd.GetInt32(0));
                komut.Parameters.AddWithValue("@P2", sd.GetString(1));
                komut.Parameters.AddWithValue("@P3", sd.GetString(2));
                komut.Parameters.AddWithValue("@P4", sd.GetString(3));
                komut.Parameters.AddWithValue("@P5", sd.GetString(4));
                komut.Parameters.AddWithValue("@P6", sd.GetString(5));
                komut.Parameters.AddWithValue("@P7", sd.GetSqlDecimal(6));
                komut.Parameters.AddWithValue("@P8", sd.GetSqlDecimal(7));
                komut.Parameters.AddWithValue("@P9", sd.GetString(8));
                
                //komut.Parameters.AddWithValue("@P12",);


                komut.ExecuteNonQuery();



                komut = new SqlCommand("Delete from TBL_URUNLER  where ID =@P1", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", txtId.Text);
                komut.ExecuteNonQuery();//sorgu çalıştır
                bgl.baglanti().Close();
                MessageBox.Show("Urünler  silindi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listele();
            }




        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_URUNLER set URUNAD=@P1,MARKA=@P2,MODEL=@P3,YIL=@P4,ADET=@P5,ALISFIYAT=@P6,SATISFIYAT=@P7,DETAY=@P8 WHERE ID=@P9", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtMarka.Text);
            komut.Parameters.AddWithValue("@P3", txtModel.Text);
            komut.Parameters.AddWithValue("@P4", mskYıl.Text);
            komut.Parameters.AddWithValue("@P5", int.Parse((nudAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@P6", decimal.Parse((txtAlış.Text).ToString()));
            komut.Parameters.AddWithValue("@P7", decimal.Parse((txtSatış.Text).ToString()));
            komut.Parameters.AddWithValue("@P8", rchDetay.Text);
            komut.Parameters.Add("@P9", txtId.Text);
            komut.ExecuteNonQuery();//sorgu çalıştır
            bgl.baglanti().Close();
            MessageBox.Show("Ürün bilgisi güncelledi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {// veri satırından veri alma
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtId.Text = dr["ID"].ToString();
            txtAd.Text = dr["URUNAD"].ToString();
            txtMarka.Text = dr["MARKA"].ToString();
            txtModel.Text = dr["MODEL"].ToString();
            mskYıl.Text = dr["YIL"].ToString();
            nudAdet.Value = decimal.Parse(dr["ADET"].ToString());
            txtAlış.Text = dr["ALISFIYAT"].ToString();
            txtSatış.Text = dr["SATISFIYAT"].ToString();
            rchDetay.Text = dr["DETAY"].ToString();

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
