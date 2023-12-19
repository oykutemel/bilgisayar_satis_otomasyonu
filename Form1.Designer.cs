
namespace Bilgisayar_satış
{
    partial class frmAnaModul
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaModul));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnUrunler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnStoklar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMusterıler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnFirmalar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAnasayfa = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPersoneller = new DevExpress.XtraBars.BarButtonItem();
            this.BtnHare = new DevExpress.XtraBars.BarButtonItem();
            this.BtnHareketler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnRaporlar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAyarlar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnTeknikTakip = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.lblGiren = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(26, 30, 26, 30);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.BtnUrunler,
            this.BtnStoklar,
            this.BtnMusterıler,
            this.BtnFirmalar,
            this.BtnAnasayfa,
            this.BtnPersoneller,
            this.BtnHare,
            this.BtnHareketler,
            this.BtnRaporlar,
            this.BtnAyarlar,
            this.BtnTeknikTakip});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 18;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 289;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1194, 193);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // BtnUrunler
            // 
            this.BtnUrunler.Caption = "ÜRÜNLER";
            this.BtnUrunler.Id = 1;
            this.BtnUrunler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunler.ImageOptions.Image")));
            this.BtnUrunler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnUrunler.ImageOptions.LargeImage")));
            this.BtnUrunler.Name = "BtnUrunler";
            this.BtnUrunler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnUrunler_ItemClick);
            // 
            // BtnStoklar
            // 
            this.BtnStoklar.Caption = "STOKLAR";
            this.BtnStoklar.Id = 2;
            this.BtnStoklar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnStoklar.ImageOptions.Image")));
            this.BtnStoklar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnStoklar.ImageOptions.LargeImage")));
            this.BtnStoklar.Name = "BtnStoklar";
            // 
            // BtnMusterıler
            // 
            this.BtnMusterıler.Caption = "MÜŞTERİLER";
            this.BtnMusterıler.Id = 8;
            this.BtnMusterıler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMusterıler.ImageOptions.Image")));
            this.BtnMusterıler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnMusterıler.ImageOptions.LargeImage")));
            this.BtnMusterıler.Name = "BtnMusterıler";
            this.BtnMusterıler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnMusterıler_ItemClick);
            // 
            // BtnFirmalar
            // 
            this.BtnFirmalar.Caption = "FİRMALAR";
            this.BtnFirmalar.Id = 9;
            this.BtnFirmalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnFirmalar.ImageOptions.Image")));
            this.BtnFirmalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnFirmalar.ImageOptions.LargeImage")));
            this.BtnFirmalar.Name = "BtnFirmalar";
            // 
            // BtnAnasayfa
            // 
            this.BtnAnasayfa.Caption = "ANA SAYFA";
            this.BtnAnasayfa.Id = 10;
            this.BtnAnasayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnasayfa.ImageOptions.Image")));
            this.BtnAnasayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAnasayfa.ImageOptions.LargeImage")));
            this.BtnAnasayfa.Name = "BtnAnasayfa";
            // 
            // BtnPersoneller
            // 
            this.BtnPersoneller.Caption = "PERSONELLER";
            this.BtnPersoneller.Id = 11;
            this.BtnPersoneller.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPersoneller.ImageOptions.Image")));
            this.BtnPersoneller.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnPersoneller.ImageOptions.LargeImage")));
            this.BtnPersoneller.Name = "BtnPersoneller";
            this.BtnPersoneller.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPersoneller_ItemClick);
            // 
            // BtnHare
            // 
            this.BtnHare.Caption = "HAREKETLER";
            this.BtnHare.Id = 12;
            this.BtnHare.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnHare.ImageOptions.Image")));
            this.BtnHare.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnHare.ImageOptions.LargeImage")));
            this.BtnHare.Name = "BtnHare";
            // 
            // BtnHareketler
            // 
            this.BtnHareketler.Caption = "HAREKETLER";
            this.BtnHareketler.Id = 14;
            this.BtnHareketler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnHareketler.ImageOptions.Image")));
            this.BtnHareketler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnHareketler.ImageOptions.LargeImage")));
            this.BtnHareketler.Name = "BtnHareketler";
            // 
            // BtnRaporlar
            // 
            this.BtnRaporlar.Caption = "RAPORLAR";
            this.BtnRaporlar.Id = 15;
            this.BtnRaporlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnRaporlar.ImageOptions.Image")));
            this.BtnRaporlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnRaporlar.ImageOptions.LargeImage")));
            this.BtnRaporlar.Name = "BtnRaporlar";
            // 
            // BtnAyarlar
            // 
            this.BtnAyarlar.Caption = "AYARLAR";
            this.BtnAyarlar.Id = 16;
            this.BtnAyarlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAyarlar.ImageOptions.Image")));
            this.BtnAyarlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAyarlar.ImageOptions.LargeImage")));
            this.BtnAyarlar.Name = "BtnAyarlar";
            // 
            // BtnTeknikTakip
            // 
            this.BtnTeknikTakip.Caption = "TEKNİK TAKİP";
            this.BtnTeknikTakip.Id = 17;
            this.BtnTeknikTakip.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTeknikTakip.ImageOptions.Image")));
            this.BtnTeknikTakip.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnTeknikTakip.ImageOptions.LargeImage")));
            this.BtnTeknikTakip.Name = "BtnTeknikTakip";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "BİLGİSAYAR SATIŞ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnAnasayfa, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnUrunler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnMusterıler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnPersoneller);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnRaporlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnTeknikTakip);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnAyarlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnStoklar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnHare);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnFirmalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnHareketler);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // lblGiren
            // 
            this.lblGiren.AutoSize = true;
            this.lblGiren.Location = new System.Drawing.Point(983, 99);
            this.lblGiren.Name = "lblGiren";
            this.lblGiren.Size = new System.Drawing.Size(42, 17);
            this.lblGiren.TabIndex = 2;
            this.lblGiren.Text = "label1";
            // 
            // frmAnaModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 553);
            this.Controls.Add(this.lblGiren);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmAnaModul";
            this.Ribbon = this.ribbonControl1;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAnaModul_FormClosed);
            this.Load += new System.EventHandler(this.frmAnaModul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BtnUrunler;
        private DevExpress.XtraBars.BarButtonItem BtnStoklar;
        private DevExpress.XtraBars.BarButtonItem BtnMusterıler;
        private DevExpress.XtraBars.BarButtonItem BtnFirmalar;
        private DevExpress.XtraBars.BarButtonItem BtnAnasayfa;
        private DevExpress.XtraBars.BarButtonItem BtnPersoneller;
        private DevExpress.XtraBars.BarButtonItem BtnHare;
        private DevExpress.XtraBars.BarButtonItem BtnHareketler;
        private DevExpress.XtraBars.BarButtonItem BtnRaporlar;
        private DevExpress.XtraBars.BarButtonItem BtnAyarlar;
        private DevExpress.XtraBars.BarButtonItem BtnTeknikTakip;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.Label lblGiren;
    }
}

