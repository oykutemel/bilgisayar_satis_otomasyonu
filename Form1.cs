using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgisayar_satış
{
    public partial class frmAnaModul : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmAnaModul()
        {
            InitializeComponent();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
        FrmUrunler fr; // urunlerden fr nesnesi 
        private void BtnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null)// bir defa  açmak için 
            {
                fr = new FrmUrunler();
                fr.MdiParent = this;
                fr.Show();
            }
        }
        FrmMusteriler fr2;
        private void BtnMusterıler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null)// bir defa  açmak için 
            {
                fr2 = new FrmMusteriler();
                fr2.MdiParent = this;
                fr2.Show();
            }
        }
        FrmPersonel fr4;
        private void BtnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4 == null)// bir defa  açmak için 
            {
                fr4 = new FrmPersonel();
                fr4.MdiParent = this;
                fr4.Show();
            }

        }

        private void frmAnaModul_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public string kullanici_adi="";
        public string unvan = "";
        private void frmAnaModul_Load(object sender, EventArgs e)
        {
            lblGiren.Text = kullanici_adi;
            if (unvan == "Personel")
            {
                BtnPersoneller.Enabled = false;
                BtnRaporlar.Enabled = false;
            }
        }
        /*frmHareketler fr9;
private void BtnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
{
if (fr9 == null)// bir defa  açmak için 
{
fr9 = new frmHareketler();
fr9.MdiParent = this;
fr9.Show();
}
}*/

    }
}
