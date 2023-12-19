
namespace Bilgisayar_satış
{
    partial class FrmPersonel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.cmbilce = new System.Windows.Forms.ComboBox();
            this.cmbil = new System.Windows.Forms.ComboBox();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.mskTel1 = new System.Windows.Forms.MaskedTextBox();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.rchAdres = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.lblSoyad = new DevExpress.XtraEditors.LabelControl();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.lblAd = new DevExpress.XtraEditors.LabelControl();
            this.dboBilgisayarOtomasyonDataSet = new Bilgisayar_satış.DboBilgisayarOtomasyonDataSet();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.txtGörev = new DevExpress.XtraEditors.TextEdit();
            this.lblGörev = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboBilgisayarOtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGörev.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbilce
            // 
            this.cmbilce.FormattingEnabled = true;
            this.cmbilce.Location = new System.Drawing.Point(93, 258);
            this.cmbilce.Name = "cmbilce";
            this.cmbilce.Size = new System.Drawing.Size(118, 24);
            this.cmbilce.TabIndex = 32;
            // 
            // cmbil
            // 
            this.cmbil.FormattingEnabled = true;
            this.cmbil.Location = new System.Drawing.Point(94, 226);
            this.cmbil.Name = "cmbil";
            this.cmbil.Size = new System.Drawing.Size(118, 24);
            this.cmbil.TabIndex = 31;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(93, 195);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(120, 22);
            this.txtMail.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Ilçe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Il:";
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(93, 164);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(115, 23);
            this.mskTc.TabIndex = 27;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // mskTel1
            // 
            this.mskTel1.Location = new System.Drawing.Point(93, 137);
            this.mskTel1.Mask = "(999) 000-0000";
            this.mskTel1.Name = "mskTel1";
            this.mskTel1.Size = new System.Drawing.Size(121, 23);
            this.mskTel1.TabIndex = 24;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(34, 426);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(131, 24);
            this.btnGuncelle.TabIndex = 23;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(175, 396);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(131, 24);
            this.btnSil.TabIndex = 22;
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(34, 396);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(131, 24);
            this.btnKaydet.TabIndex = 20;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // rchAdres
            // 
            this.rchAdres.Location = new System.Drawing.Point(91, 288);
            this.rchAdres.Name = "rchAdres";
            this.rchAdres.Size = new System.Drawing.Size(120, 74);
            this.rchAdres.TabIndex = 19;
            this.rchAdres.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Adres:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(55, 189);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(28, 16);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Mail:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(67, 167);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(21, 16);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "TC:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(31, 140);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Telefon 1:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(93, 106);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(120, 22);
            this.txtSoyad.TabIndex = 6;
            // 
            // lblSoyad
            // 
            this.lblSoyad.Location = new System.Drawing.Point(50, 112);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(40, 16);
            this.lblSoyad.TabIndex = 5;
            this.lblSoyad.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(93, 78);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(120, 22);
            this.txtAd.TabIndex = 4;
            // 
            // lblAd
            // 
            this.lblAd.Location = new System.Drawing.Point(70, 84);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 16);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Ad:";
            // 
            // dboBilgisayarOtomasyonDataSet
            // 
            this.dboBilgisayarOtomasyonDataSet.DataSetName = "DboBilgisayarOtomasyonDataSet";
            this.dboBilgisayarOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(93, 50);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(120, 22);
            this.txtId.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(70, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(146, -1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(741, 439);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnTemizle);
            this.groupControl1.Controls.Add(this.txtGörev);
            this.groupControl1.Controls.Add(this.lblGörev);
            this.groupControl1.Controls.Add(this.cmbilce);
            this.groupControl1.Controls.Add(this.cmbil);
            this.groupControl1.Controls.Add(this.txtMail);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.mskTc);
            this.groupControl1.Controls.Add(this.mskTel1);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.rchAdres);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtSoyad);
            this.groupControl1.Controls.Add(this.lblSoyad);
            this.groupControl1.Controls.Add(this.txtAd);
            this.groupControl1.Controls.Add(this.lblAd);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(893, -1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(326, 470);
            this.groupControl1.TabIndex = 5;
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(171, 426);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(131, 24);
            this.btnTemizle.TabIndex = 35;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtGörev
            // 
            this.txtGörev.Location = new System.Drawing.Point(91, 368);
            this.txtGörev.Name = "txtGörev";
            this.txtGörev.Size = new System.Drawing.Size(120, 22);
            this.txtGörev.TabIndex = 34;
            // 
            // lblGörev
            // 
            this.lblGörev.Location = new System.Drawing.Point(47, 371);
            this.lblGörev.Name = "lblGörev";
            this.lblGörev.Size = new System.Drawing.Size(38, 16);
            this.lblGörev.TabIndex = 33;
            this.lblGörev.Text = "Görev:";
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 468);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmPersonel";
            this.Text = "FrmPersonel";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboBilgisayarOtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGörev.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbilce;
        public System.Windows.Forms.ComboBox cmbil;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.MaskedTextBox mskTel1;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.RichTextBox rchAdres;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.LabelControl lblSoyad;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.LabelControl lblAd;
        private DboBilgisayarOtomasyonDataSet dboBilgisayarOtomasyonDataSet;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtGörev;
        private DevExpress.XtraEditors.LabelControl lblGörev;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
    }
}