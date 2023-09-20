namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMusteriEkle = new Button();
            txtMusteriAdi = new TextBox();
            cmbOdemeTipi = new ComboBox();
            lstMusteriKuyruk = new ListBox();
            btnMesaiBaslat = new Button();
            lstSiparisler = new ListBox();
            cmbMenuler = new ComboBox();
            flpEkstralar = new FlowLayoutPanel();
            cmbIcecekler = new ComboBox();
            numMenuAdet = new NumericUpDown();
            btnSiparisVer = new Button();
            btnDukkanAc = new Button();
            lstPersoneller = new ListBox();
            flpKasalar = new FlowLayoutPanel();
            btnMenuOlustur = new Button();
            lblToplamTutar = new Label();
            btnMesaiBitir = new Button();
            lblGunSonu = new Label();
            label1 = new Label();
            label2 = new Label();
            lblOdemeTipi = new Label();
            lblPersoneller = new Label();
            ((System.ComponentModel.ISupportInitialize)numMenuAdet).BeginInit();
            SuspendLayout();
            // 
            // btnMusteriEkle
            // 
            btnMusteriEkle.Location = new Point(251, 215);
            btnMusteriEkle.Name = "btnMusteriEkle";
            btnMusteriEkle.Size = new Size(103, 47);
            btnMusteriEkle.TabIndex = 0;
            btnMusteriEkle.Text = "Müşteri Ekle";
            btnMusteriEkle.UseVisualStyleBackColor = true;
            btnMusteriEkle.Click += btnMusteriEkle_Click;
            // 
            // txtMusteriAdi
            // 
            txtMusteriAdi.Location = new Point(220, 117);
            txtMusteriAdi.Name = "txtMusteriAdi";
            txtMusteriAdi.Size = new Size(173, 27);
            txtMusteriAdi.TabIndex = 1;
            // 
            // cmbOdemeTipi
            // 
            cmbOdemeTipi.FormattingEnabled = true;
            cmbOdemeTipi.Location = new Point(220, 180);
            cmbOdemeTipi.Name = "cmbOdemeTipi";
            cmbOdemeTipi.Size = new Size(173, 28);
            cmbOdemeTipi.TabIndex = 2;
            // 
            // lstMusteriKuyruk
            // 
            lstMusteriKuyruk.FormattingEnabled = true;
            lstMusteriKuyruk.ItemHeight = 20;
            lstMusteriKuyruk.Location = new Point(220, 268);
            lstMusteriKuyruk.Name = "lstMusteriKuyruk";
            lstMusteriKuyruk.Size = new Size(173, 104);
            lstMusteriKuyruk.TabIndex = 3;
            // 
            // btnMesaiBaslat
            // 
            btnMesaiBaslat.Location = new Point(248, 12);
            btnMesaiBaslat.Name = "btnMesaiBaslat";
            btnMesaiBaslat.Size = new Size(111, 60);
            btnMesaiBaslat.TabIndex = 5;
            btnMesaiBaslat.Text = "Mesai Başlat";
            btnMesaiBaslat.UseVisualStyleBackColor = true;
            btnMesaiBaslat.Click += btnMesaiBaslat_Click;
            // 
            // lstSiparisler
            // 
            lstSiparisler.FormattingEnabled = true;
            lstSiparisler.ItemHeight = 20;
            lstSiparisler.Location = new Point(967, 116);
            lstSiparisler.Name = "lstSiparisler";
            lstSiparisler.Size = new Size(450, 84);
            lstSiparisler.TabIndex = 7;
            // 
            // cmbMenuler
            // 
            cmbMenuler.FormattingEnabled = true;
            cmbMenuler.Location = new Point(416, 116);
            cmbMenuler.Name = "cmbMenuler";
            cmbMenuler.Size = new Size(516, 28);
            cmbMenuler.TabIndex = 9;
            // 
            // flpEkstralar
            // 
            flpEkstralar.Location = new Point(470, 247);
            flpEkstralar.Name = "flpEkstralar";
            flpEkstralar.Size = new Size(427, 83);
            flpEkstralar.TabIndex = 10;
            // 
            // cmbIcecekler
            // 
            cmbIcecekler.FormattingEnabled = true;
            cmbIcecekler.Location = new Point(710, 198);
            cmbIcecekler.Name = "cmbIcecekler";
            cmbIcecekler.Size = new Size(222, 28);
            cmbIcecekler.TabIndex = 9;
            // 
            // numMenuAdet
            // 
            numMenuAdet.Location = new Point(796, 155);
            numMenuAdet.Name = "numMenuAdet";
            numMenuAdet.Size = new Size(136, 27);
            numMenuAdet.TabIndex = 11;
            // 
            // btnSiparisVer
            // 
            btnSiparisVer.Location = new Point(1114, 13);
            btnSiparisVer.Name = "btnSiparisVer";
            btnSiparisVer.Size = new Size(112, 60);
            btnSiparisVer.TabIndex = 12;
            btnSiparisVer.Text = "Siparis Ver";
            btnSiparisVer.UseVisualStyleBackColor = true;
            btnSiparisVer.Click += btnSiparisVer_Click;
            // 
            // btnDukkanAc
            // 
            btnDukkanAc.Location = new Point(40, 12);
            btnDukkanAc.Name = "btnDukkanAc";
            btnDukkanAc.Size = new Size(115, 61);
            btnDukkanAc.TabIndex = 13;
            btnDukkanAc.Text = "Dükkanı Aç";
            btnDukkanAc.UseVisualStyleBackColor = true;
            btnDukkanAc.Click += btnDukkanAc_Click;
            // 
            // lstPersoneller
            // 
            lstPersoneller.FormattingEnabled = true;
            lstPersoneller.ItemHeight = 20;
            lstPersoneller.Location = new Point(12, 125);
            lstPersoneller.Name = "lstPersoneller";
            lstPersoneller.Size = new Size(173, 104);
            lstPersoneller.TabIndex = 14;
            // 
            // flpKasalar
            // 
            flpKasalar.Location = new Point(12, 247);
            flpKasalar.Name = "flpKasalar";
            flpKasalar.Size = new Size(173, 125);
            flpKasalar.TabIndex = 15;
            // 
            // btnMenuOlustur
            // 
            btnMenuOlustur.Location = new Point(535, 13);
            btnMenuOlustur.Name = "btnMenuOlustur";
            btnMenuOlustur.Size = new Size(114, 60);
            btnMenuOlustur.TabIndex = 16;
            btnMenuOlustur.Text = "Menü Olustur";
            btnMenuOlustur.UseVisualStyleBackColor = true;
            btnMenuOlustur.Click += btnMenuOlustur_Click;
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Location = new Point(1129, 209);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(97, 20);
            lblToplamTutar.TabIndex = 17;
            lblToplamTutar.Text = "Toplam Tutar";
            // 
            // btnMesaiBitir
            // 
            btnMesaiBitir.Location = new Point(1387, 13);
            btnMesaiBitir.Name = "btnMesaiBitir";
            btnMesaiBitir.Size = new Size(116, 60);
            btnMesaiBitir.TabIndex = 18;
            btnMesaiBitir.Text = "Mesai Bitir";
            btnMesaiBitir.UseVisualStyleBackColor = true;
            btnMesaiBitir.Click += btnMesaiBitir_Click;
            // 
            // lblGunSonu
            // 
            lblGunSonu.AutoSize = true;
            lblGunSonu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGunSonu.Location = new Point(595, 188);
            lblGunSonu.Name = "lblGunSonu";
            lblGunSonu.Size = new Size(28, 28);
            lblGunSonu.TabIndex = 19;
            lblGunSonu.Text = "....";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(595, 155);
            label1.Name = "label1";
            label1.Size = new Size(202, 28);
            label1.TabIndex = 20;
            label1.Text = "GÜN SONU RAPORU ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 92);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 21;
            label2.Text = "Müşteri Adı";
            // 
            // lblOdemeTipi
            // 
            lblOdemeTipi.AutoSize = true;
            lblOdemeTipi.Location = new Point(256, 157);
            lblOdemeTipi.Name = "lblOdemeTipi";
            lblOdemeTipi.Size = new Size(87, 20);
            lblOdemeTipi.TabIndex = 22;
            lblOdemeTipi.Text = "Ödeme Tipi";
            // 
            // lblPersoneller
            // 
            lblPersoneller.AutoSize = true;
            lblPersoneller.Location = new Point(12, 102);
            lblPersoneller.Name = "lblPersoneller";
            lblPersoneller.Size = new Size(148, 20);
            lblPersoneller.TabIndex = 23;
            lblPersoneller.Text = "Personeller, Görevleri";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1515, 518);
            Controls.Add(lblPersoneller);
            Controls.Add(lblOdemeTipi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblGunSonu);
            Controls.Add(btnMesaiBitir);
            Controls.Add(lblToplamTutar);
            Controls.Add(btnMenuOlustur);
            Controls.Add(flpKasalar);
            Controls.Add(lstPersoneller);
            Controls.Add(btnDukkanAc);
            Controls.Add(btnSiparisVer);
            Controls.Add(numMenuAdet);
            Controls.Add(flpEkstralar);
            Controls.Add(cmbIcecekler);
            Controls.Add(cmbMenuler);
            Controls.Add(lstSiparisler);
            Controls.Add(btnMesaiBaslat);
            Controls.Add(lstMusteriKuyruk);
            Controls.Add(cmbOdemeTipi);
            Controls.Add(txtMusteriAdi);
            Controls.Add(btnMusteriEkle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numMenuAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMusteriEkle;
        private TextBox txtMusteriAdi;
        private ComboBox cmbOdemeTipi;
        private ListBox lstMusteriKuyruk;
        private Button btnMesaiBaslat;
        private ListBox lstSiparisler;
        private ComboBox cmbMenuler;
        private FlowLayoutPanel flpEkstralar;
        private ComboBox cmbIcecekler;
        private NumericUpDown numMenuAdet;
        private Button btnSiparisVer;
        private Button btnDukkanAc;
        private ListBox lstPersoneller;
        private FlowLayoutPanel flpKasalar;
        private Button btnMenuOlustur;
        private Label lblToplamTutar;
        private Button btnMesaiBitir;
        private Label lblGunSonu;
        private Label label1;
        private Label label2;
        private Label lblOdemeTipi;
        private Label lblPersoneller;
    }
}