namespace DentalClinicApp
{
    partial class FormMalzemeler
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtSeriEkleme = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeriSilme = new System.Windows.Forms.TextBox();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtGosterSeri = new System.Windows.Forms.TextBox();
            this.btnSeriArama = new System.Windows.Forms.Button();
            this.txtGosterFiyat = new System.Windows.Forms.TextBox();
            this.txtGosterMiktar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGosterTur = new System.Windows.Forms.TextBox();
            this.txtSeriArama = new System.Windows.Forms.TextBox();
            this.txtGosterAd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.pbExit);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 710);
            this.panel1.TabIndex = 11;
            // 
            // pbExit
            // 
            this.pbExit.BackgroundImage = global::DentalClinicApp.Properties.Resources.icons8_exit_48;
            this.pbExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbExit.Location = new System.Drawing.Point(13, 13);
            this.pbExit.Margin = new System.Windows.Forms.Padding(4);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(32, 30);
            this.pbExit.TabIndex = 12;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(153, 34);
            this.tabControl1.MaximumSize = new System.Drawing.Size(750, 650);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 650);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.btnEkle);
            this.tabPage1.Controls.Add(this.txtSeriEkleme);
            this.tabPage1.Controls.Add(this.btnGuncelle);
            this.tabPage1.Controls.Add(this.txtFiyat);
            this.tabPage1.Controls.Add(this.txtAd);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtSeriSilme);
            this.tabPage1.Controls.Add(this.txtTur);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtMiktar);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnSil);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(742, 617);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stok Ekle";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(367, 316);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(128, 32);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // txtSeriEkleme
            // 
            this.txtSeriEkleme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSeriEkleme.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeriEkleme.ForeColor = System.Drawing.Color.DimGray;
            this.txtSeriEkleme.Location = new System.Drawing.Point(366, 270);
            this.txtSeriEkleme.Name = "txtSeriEkleme";
            this.txtSeriEkleme.Size = new System.Drawing.Size(129, 30);
            this.txtSeriEkleme.TabIndex = 1;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.AutoSize = true;
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(377, 540);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(88, 35);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click_1);
            // 
            // txtFiyat
            // 
            this.txtFiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiyat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.ForeColor = System.Drawing.Color.DimGray;
            this.txtFiyat.Location = new System.Drawing.Point(366, 225);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(129, 30);
            this.txtFiyat.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.ForeColor = System.Drawing.Color.DimGray;
            this.txtAd.Location = new System.Drawing.Point(366, 99);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(129, 30);
            this.txtAd.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(158, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(388, 37);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ürün Silme ve Güncelleme";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(253, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 37);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ürün Ekleme";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(219, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Malzeme Adı";
            // 
            // txtSeriSilme
            // 
            this.txtSeriSilme.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeriSilme.ForeColor = System.Drawing.Color.DimGray;
            this.txtSeriSilme.Location = new System.Drawing.Point(367, 486);
            this.txtSeriSilme.Name = "txtSeriSilme";
            this.txtSeriSilme.Size = new System.Drawing.Size(128, 30);
            this.txtSeriSilme.TabIndex = 1;
            // 
            // txtTur
            // 
            this.txtTur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTur.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTur.ForeColor = System.Drawing.Color.DimGray;
            this.txtTur.Location = new System.Drawing.Point(367, 138);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(128, 30);
            this.txtTur.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(219, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Malzeme Türü";
            // 
            // txtMiktar
            // 
            this.txtMiktar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMiktar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.ForeColor = System.Drawing.Color.DimGray;
            this.txtMiktar.Location = new System.Drawing.Point(366, 183);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(129, 30);
            this.txtMiktar.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(220, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Seri Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(219, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Stok Miktarı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(219, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Birim Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(219, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Seri Numarası";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(260, 540);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(84, 35);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.txtGosterSeri);
            this.tabPage2.Controls.Add(this.btnSeriArama);
            this.tabPage2.Controls.Add(this.txtGosterFiyat);
            this.tabPage2.Controls.Add(this.txtGosterMiktar);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.txtGosterTur);
            this.tabPage2.Controls.Add(this.txtSeriArama);
            this.tabPage2.Controls.Add(this.txtGosterAd);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(742, 617);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stok Kontrol";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(173, 205);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(129, 20);
            this.label19.TabIndex = 8;
            this.label19.Text = "Seri Numarası";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(174, 286);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 20);
            this.label17.TabIndex = 6;
            this.label17.Text = "Malzeme Adı";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(174, 328);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 20);
            this.label18.TabIndex = 7;
            this.label18.Text = "Malzeme Türü";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(241, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(232, 37);
            this.label16.TabIndex = 5;
            this.label16.Text = "Ürün Ara";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGosterSeri
            // 
            this.txtGosterSeri.BackColor = System.Drawing.SystemColors.Window;
            this.txtGosterSeri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGosterSeri.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGosterSeri.ForeColor = System.Drawing.Color.DimGray;
            this.txtGosterSeri.Location = new System.Drawing.Point(324, 459);
            this.txtGosterSeri.Name = "txtGosterSeri";
            this.txtGosterSeri.ReadOnly = true;
            this.txtGosterSeri.Size = new System.Drawing.Size(128, 30);
            this.txtGosterSeri.TabIndex = 1;
            // 
            // btnSeriArama
            // 
            this.btnSeriArama.BackColor = System.Drawing.Color.Transparent;
            this.btnSeriArama.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSeriArama.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSeriArama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeriArama.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeriArama.Location = new System.Drawing.Point(485, 198);
            this.btnSeriArama.Name = "btnSeriArama";
            this.btnSeriArama.Size = new System.Drawing.Size(87, 32);
            this.btnSeriArama.TabIndex = 4;
            this.btnSeriArama.Text = "Ara";
            this.btnSeriArama.UseVisualStyleBackColor = false;
            this.btnSeriArama.Click += new System.EventHandler(this.btnSeriArama_Click_1);
            // 
            // txtGosterFiyat
            // 
            this.txtGosterFiyat.BackColor = System.Drawing.SystemColors.Window;
            this.txtGosterFiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGosterFiyat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGosterFiyat.ForeColor = System.Drawing.Color.DimGray;
            this.txtGosterFiyat.Location = new System.Drawing.Point(324, 414);
            this.txtGosterFiyat.Name = "txtGosterFiyat";
            this.txtGosterFiyat.ReadOnly = true;
            this.txtGosterFiyat.Size = new System.Drawing.Size(128, 30);
            this.txtGosterFiyat.TabIndex = 1;
            // 
            // txtGosterMiktar
            // 
            this.txtGosterMiktar.BackColor = System.Drawing.SystemColors.Window;
            this.txtGosterMiktar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGosterMiktar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGosterMiktar.ForeColor = System.Drawing.Color.DimGray;
            this.txtGosterMiktar.Location = new System.Drawing.Point(324, 372);
            this.txtGosterMiktar.Name = "txtGosterMiktar";
            this.txtGosterMiktar.ReadOnly = true;
            this.txtGosterMiktar.Size = new System.Drawing.Size(128, 30);
            this.txtGosterMiktar.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(174, 460);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Seri Numarası";
            // 
            // txtGosterTur
            // 
            this.txtGosterTur.BackColor = System.Drawing.SystemColors.Window;
            this.txtGosterTur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGosterTur.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGosterTur.ForeColor = System.Drawing.Color.DimGray;
            this.txtGosterTur.Location = new System.Drawing.Point(324, 327);
            this.txtGosterTur.Name = "txtGosterTur";
            this.txtGosterTur.ReadOnly = true;
            this.txtGosterTur.Size = new System.Drawing.Size(128, 30);
            this.txtGosterTur.TabIndex = 1;
            // 
            // txtSeriArama
            // 
            this.txtSeriArama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSeriArama.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeriArama.ForeColor = System.Drawing.Color.DimGray;
            this.txtSeriArama.Location = new System.Drawing.Point(324, 204);
            this.txtSeriArama.Name = "txtSeriArama";
            this.txtSeriArama.Size = new System.Drawing.Size(128, 30);
            this.txtSeriArama.TabIndex = 1;
            // 
            // txtGosterAd
            // 
            this.txtGosterAd.BackColor = System.Drawing.SystemColors.Window;
            this.txtGosterAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGosterAd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGosterAd.ForeColor = System.Drawing.Color.DimGray;
            this.txtGosterAd.Location = new System.Drawing.Point(324, 285);
            this.txtGosterAd.Name = "txtGosterAd";
            this.txtGosterAd.ReadOnly = true;
            this.txtGosterAd.Size = new System.Drawing.Size(128, 30);
            this.txtGosterAd.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(174, 415);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Birim Fiyat";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(174, 373);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Stok Miktarı";
            // 
            // FormMalzemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 710);
            this.Controls.Add(this.panel1);
            this.Name = "FormMalzemeler";
            this.Text = "FormMalzemeler";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtSeriEkleme;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeriSilme;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtGosterSeri;
        private System.Windows.Forms.Button btnSeriArama;
        private System.Windows.Forms.TextBox txtGosterFiyat;
        private System.Windows.Forms.TextBox txtGosterMiktar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtGosterTur;
        private System.Windows.Forms.TextBox txtSeriArama;
        private System.Windows.Forms.TextBox txtGosterAd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pbExit;
    }
}