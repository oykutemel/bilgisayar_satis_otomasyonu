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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("insert into TBL_MUSTERILER(AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", mskTel1.Text);
            komut.Parameters.AddWithValue("@P4", mskTc.Text);
            komut.Parameters.AddWithValue("@P5", txtMaıl.Text);
            komut.Parameters.AddWithValue("@P6",cmbil.Text );
            komut.Parameters.AddWithValue("@P7", cmbilce.Text);
            komut.Parameters.AddWithValue("@P8",rchAdres.Text );
            komut.ExecuteNonQuery();//sorgu çalıştır
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri sisteme eklendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtId.Text = dr["ID"].ToString();
            txtAd.Text = dr["AD"].ToString();
            txtSoyad.Text = dr["SOYAD"].ToString();
            mskTel1.Text = dr["TELEFON"].ToString();
            mskTc.Text = dr["TC"].ToString();
            txtMaıl.Text= dr["MAIL"].ToString();
            cmbil.Text = dr["IL"].ToString();
            cmbilce.Text = dr["ILCE"].ToString();
            rchAdres.Text = dr["ADRES"].ToString();
        }
        

        private void FrmMusteriler_Load_1(object sender, EventArgs e)
        {
            listele();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            SqlDataReader sd;
            SqlCommand komut = new SqlCommand("Select * From TBL_MUSTERILER Where ID = @P1;", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtId.Text);

            sd = komut.ExecuteReader();

            if (sd.Read())
            {

                komut = new SqlCommand("Insert Into TBL_S_MUSTERI (ID,AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES) Values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9);", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", sd.GetInt32(0));
                komut.Parameters.AddWithValue("@P2", sd.GetString(1));
                komut.Parameters.AddWithValue("@P3", sd.GetString(2));
                komut.Parameters.AddWithValue("@P4", sd.GetString(3));
                komut.Parameters.AddWithValue("@P5", sd.GetString(4));
                komut.Parameters.AddWithValue("@P6", sd.GetString(5));
                komut.Parameters.AddWithValue("@P7", sd.GetString(6));
                komut.Parameters.AddWithValue("@P8", sd.GetString(7));
                komut.Parameters.AddWithValue("@P9", sd.GetString(8));
                
                //komut.Parameters.AddWithValue("@P12",);

                komut.ExecuteNonQuery();

                komut = new SqlCommand("Delete From TBL_MUSTERILER  where ID =@P1", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", txtId.Text);
                komut.ExecuteNonQuery();//sorgu çalıştır
                bgl.baglanti().Close();
                MessageBox.Show("Müşteri  silindi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listele();
            }
            
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_MUSTERILER  set AD=@P1,SOYAD=@P2,TELEFON=@P3,TC=@P4,MAIL=@P5,IL=@P6,ILCE=@P7,ADRES=@P8 WHERE ID=@P9", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", mskTel1.Text);
            komut.Parameters.AddWithValue("@P4", mskTc.Text);
            komut.Parameters.AddWithValue("@P5", txtMaıl.Text);
            komut.Parameters.AddWithValue("@P6", cmbil.Text);
            komut.Parameters.AddWithValue("@P7", cmbilce.Text);
            komut.Parameters.AddWithValue("@P8", rchAdres.Text);
            komut.Parameters.Add("@P9", txtId.Text);
            komut.ExecuteNonQuery();//sorgu çalıştır
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri bilgisi güncellendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        /* void sehirlistesi()
         {
             SqlCommand komut = new SqlCommand("Select Sehir From TBL_ILLER", bgl.baglanti());
             SqlDataReader dr = komut.ExecuteReader();
             while(dr.Read())
             {
                 cmbil.Items.Add();
                 cmbil.Properties.Items.Add(dr[0]);

             }
             bgl.baglanti().Close();

         }
         private void FrmMusteriler_Load(object sender, EventArgs e)
         {
             // TODO: Bu kod satırı 'dboBilgisayarOtomasyonDataSet.TBL_ILCELER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
             this.tBL_ILCELERTableAdapter.Fill(this.dboBilgisayarOtomasyonDataSet.TBL_ILCELER);
             listele();
             sehirlistesi();
         }

         private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
         {
             cmbilce.propeties.Items.Add(dr[0])

                 Properties.Items.Add(Dr[0]);
             SqlCommand komut = new SqlCommand("Select ILCE from TBL_ILCELER where Sehir=@P1", bgl.baglanti());
             komut.Parameters.AddWithValue("@P1", cmbil.SelectedIndex);
             SqlDataReader dr = komut.ExecuteReader();
             while(dr.Read())
             {
                 cmbilce.Properties.Items.Add(dr[0]);
             }
             bgl.baglanti().Close();

         }properties hatası */

    }
}
