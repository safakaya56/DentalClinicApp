namespace DentalClinicApp
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelGetir = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGetir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnKullanıcılar = new System.Windows.Forms.Button();
            this.btnIstatistikler = new System.Windows.Forms.Button();
            this.btnMalzemeler = new System.Windows.Forms.Button();
            this.btnOdemeler = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHasta3 = new System.Windows.Forms.Button();
            this.btnHasta2 = new System.Windows.Forms.Button();
            this.btnHasta1 = new System.Windows.Forms.Button();
            this.btnHastaIslemleri = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbMinimaze = new System.Windows.Forms.PictureBox();
            this.panelGetir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panelSide.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimaze)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGetir
            // 
            this.panelGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.panelGetir.Controls.Add(this.label2);
            this.panelGetir.Controls.Add(this.label1);
            this.panelGetir.Controls.Add(this.buttonGetir);
            this.panelGetir.Controls.Add(this.dataGridView1);
            this.panelGetir.Controls.Add(this.chart2);
            this.panelGetir.Controls.Add(this.chart1);
            this.panelGetir.Controls.Add(this.panelSide);
            this.panelGetir.Controls.Add(this.panel3);
            this.panelGetir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGetir.Location = new System.Drawing.Point(0, 0);
            this.panelGetir.Name = "panelGetir";
            this.panelGetir.Size = new System.Drawing.Size(1500, 900);
            this.panelGetir.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(722, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sıradaki Hastalar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(722, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Günün İstatistikleri";
            // 
            // buttonGetir
            // 
            this.buttonGetir.Location = new System.Drawing.Point(1243, 311);
            this.buttonGetir.Name = "buttonGetir";
            this.buttonGetir.Size = new System.Drawing.Size(159, 66);
            this.buttonGetir.TabIndex = 11;
            this.buttonGetir.Text = "Verileri Getir";
            this.buttonGetir.UseVisualStyleBackColor = true;
            this.buttonGetir.Click += new System.EventHandler(this.buttonGetir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(377, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(852, 327);
            this.dataGridView1.TabIndex = 10;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            this.chart2.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(913, 560);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(489, 300);
            this.chart2.TabIndex = 9;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(343, 560);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(486, 300);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // panelSide
            // 
            this.panelSide.AutoScroll = true;
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(77)))), ((int)(((byte)(74)))));
            this.panelSide.Controls.Add(this.btnKullanıcılar);
            this.panelSide.Controls.Add(this.btnIstatistikler);
            this.panelSide.Controls.Add(this.btnMalzemeler);
            this.panelSide.Controls.Add(this.btnOdemeler);
            this.panelSide.Controls.Add(this.panel2);
            this.panelSide.Controls.Add(this.btnHastaIslemleri);
            this.panelSide.Controls.Add(this.panelLogo);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 47);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(230, 853);
            this.panelSide.TabIndex = 7;
            // 
            // btnKullanıcılar
            // 
            this.btnKullanıcılar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKullanıcılar.FlatAppearance.BorderSize = 0;
            this.btnKullanıcılar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(161)))), ((int)(((byte)(153)))));
            this.btnKullanıcılar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(161)))), ((int)(((byte)(153)))));
            this.btnKullanıcılar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullanıcılar.ForeColor = System.Drawing.Color.White;
            this.btnKullanıcılar.Image = ((System.Drawing.Image)(resources.GetObject("btnKullanıcılar.Image")));
            this.btnKullanıcılar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKullanıcılar.Location = new System.Drawing.Point(0, 420);
            this.btnKullanıcılar.Name = "btnKullanıcılar";
            this.btnKullanıcılar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnKullanıcılar.Size = new System.Drawing.Size(230, 45);
            this.btnKullanıcılar.TabIndex = 8;
            this.btnKullanıcılar.Text = "  Kullanıcılar";
            this.btnKullanıcılar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKullanıcılar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKullanıcılar.UseVisualStyleBackColor = true;
            this.btnKullanıcılar.Click += new System.EventHandler(this.btnKullanıcılar_Click);
            // 
            // btnIstatistikler
            // 
            this.btnIstatistikler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIstatistikler.FlatAppearance.BorderSize = 0;
            this.btnIstatistikler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(161)))), ((int)(((byte)(153)))));
            this.btnIstatistikler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(161)))), ((int)(((byte)(153)))));
            this.btnIstatistikler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIstatistikler.ForeColor = System.Drawing.Color.White;
            this.btnIstatistikler.Image = ((System.Drawing.Image)(resources.GetObject("btnIstatistikler.Image")));
            this.btnIstatistikler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIstatistikler.Location = new System.Drawing.Point(0, 375);
            this.btnIstatistikler.Name = "btnIstatistikler";
            this.btnIstatistikler.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnIstatistikler.Size = new System.Drawing.Size(230, 45);
            this.btnIstatistikler.TabIndex = 7;
            this.btnIstatistikler.Text = "  İstatistikler";
            this.btnIstatistikler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIstatistikler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIstatistikler.UseVisualStyleBackColor = true;
            this.btnIstatistikler.Click += new System.EventHandler(this.btnIstatistikler_Click);
            // 
            // btnMalzemeler
            // 
            this.btnMalzemeler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMalzemeler.FlatAppearance.BorderSize = 0;
            this.btnMalzemeler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(161)))), ((int)(((byte)(153)))));
            this.btnMalzemeler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(161)))), ((int)(((byte)(153)))));
            this.btnMalzemeler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMalzemeler.ForeColor = System.Drawing.Color.White;
            this.btnMalzemeler.Image = ((System.Drawing.Image)(resources.GetObject("btnMalzemeler.Image")));
            this.btnMalzemeler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMalzemeler.Location = new System.Drawing.Point(0, 330);
            this.btnMalzemeler.Name = "btnMalzemeler";
            this.btnMalzemeler.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMalzemeler.Size = new System.Drawing.Size(230, 45);
            this.btnMalzemeler.TabIndex = 6;
            this.btnMalzemeler.Text = "  Malzeme Stoğu";
            this.btnMalzemeler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMalzemeler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMalzemeler.UseVisualStyleBackColor = true;
            this.btnMalzemeler.Click += new System.EventHandler(this.btnMalzemeler_Click);
            // 
            // btnOdemeler
            // 
            this.btnOdemeler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOdemeler.FlatAppearance.BorderSize = 0;
            this.btnOdemeler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(161)))), ((int)(((byte)(153)))));
            this.btnOdemeler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(161)))), ((int)(((byte)(153)))));
            this.btnOdemeler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdemeler.ForeColor = System.Drawing.Color.White;
            this.btnOdemeler.Image = ((System.Drawing.Image)(resources.GetObject("btnOdemeler.Image")));
            this.btnOdemeler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdemeler.Location = new System.Drawing.Point(0, 285);
            this.btnOdemeler.Name = "btnOdemeler";
            this.btnOdemeler.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnOdemeler.Size = new System.Drawing.Size(230, 45);
            this.btnOdemeler.TabIndex = 5;
            this.btnOdemeler.Text = "  Ödemeler";
            this.btnOdemeler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdemeler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOdemeler.UseVisualStyleBackColor = true;
            this.btnOdemeler.Click += new System.EventHandler(this.btnOdemeler_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(122)))), ((int)(((byte)(115)))));
            this.panel2.Controls.Add(this.btnHasta3);
            this.panel2.Controls.Add(this.btnHasta2);
            this.panel2.Controls.Add(this.btnHasta1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 120);
            this.panel2.TabIndex = 2;
            // 
            // btnHasta3
            // 
            this.btnHasta3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(122)))), ((int)(((byte)(115)))));
            this.btnHasta3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHasta3.FlatAppearance.BorderSize = 0;
            this.btnHasta3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(161)))), ((int)(((byte)(153)))));
            this.btnHasta3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(161)))), ((int)(((byte)(153)))));
            this.btnHasta3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHasta3.ForeColor = System.Drawing.Color.White;
            this.btnHasta3.Location = new System.Drawing.Point(0, 80);
            this.btnHasta3.Name = "btnHasta3";
            this.btnHasta3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHasta3.Size = new System.Drawing.Size(230, 40);
            this.btnHasta3.TabIndex = 4;
            this.btnHasta3.Text = " Hasta Arşivi";
            this.btnHasta3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHasta3.UseVisualStyleBackColor = false;
            this.btnHasta3.Click += new System.EventHandler(this.btnHasta3_Click);
            // 
            // btnHasta2
            // 
            this.btnHasta2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(122)))), ((int)(((byte)(115)))));
            this.btnHasta2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHasta2.FlatAppearance.BorderSize = 0;
            this.btnHasta2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(161)))), ((int)(((byte)(153)))));
            this.btnHasta2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(161)))), ((int)(((byte)(153)))));
            this.btnHasta2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHasta2.ForeColor = System.Drawing.Color.White;
            this.btnHasta2.Location = new System.Drawing.Point(0, 40);
            this.btnHasta2.Name = "btnHasta2";
            this.btnHasta2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHasta2.Size = new System.Drawing.Size(230, 40);
            this.btnHasta2.TabIndex = 3;
            this.btnHasta2.Text = " Randevu İşlemleri";
            this.btnHasta2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHasta2.UseVisualStyleBackColor = false;
            this.btnHasta2.Click += new System.EventHandler(this.btnHasta2_Click);
            // 
            // btnHasta1
            // 
            this.btnHasta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(122)))), ((int)(((byte)(115)))));
            this.btnHasta1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHasta1.FlatAppearance.BorderSize = 0;
            this.btnHasta1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(161)))), ((int)(((byte)(153)))));
            this.btnHasta1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(161)))), ((int)(((byte)(153)))));
            this.btnHasta1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHasta1.ForeColor = System.Drawing.Color.White;
            this.btnHasta1.Location = new System.Drawing.Point(0, 0);
            this.btnHasta1.Name = "btnHasta1";
            this.btnHasta1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHasta1.Size = new System.Drawing.Size(230, 40);
            this.btnHasta1.TabIndex = 2;
            this.btnHasta1.Text = " Günlük Hasta Listesi";
            this.btnHasta1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHasta1.UseVisualStyleBackColor = false;
            this.btnHasta1.Click += new System.EventHandler(this.btnHasta1_Click);
            // 
            // btnHastaIslemleri
            // 
            this.btnHastaIslemleri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHastaIslemleri.FlatAppearance.BorderSize = 0;
            this.btnHastaIslemleri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(161)))), ((int)(((byte)(153)))));
            this.btnHastaIslemleri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(161)))), ((int)(((byte)(153)))));
            this.btnHastaIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaIslemleri.ForeColor = System.Drawing.Color.White;
            this.btnHastaIslemleri.Image = ((System.Drawing.Image)(resources.GetObject("btnHastaIslemleri.Image")));
            this.btnHastaIslemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHastaIslemleri.Location = new System.Drawing.Point(0, 120);
            this.btnHastaIslemleri.Name = "btnHastaIslemleri";
            this.btnHastaIslemleri.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHastaIslemleri.Size = new System.Drawing.Size(230, 45);
            this.btnHastaIslemleri.TabIndex = 1;
            this.btnHastaIslemleri.Text = "  Hasta İşlemleri";
            this.btnHastaIslemleri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHastaIslemleri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHastaIslemleri.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(230, 120);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(3, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(231, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(127)))), ((int)(((byte)(122)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1500, 47);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(138)))));
            this.panel4.Controls.Add(this.pbExit);
            this.panel4.Controls.Add(this.pbMinimaze);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1387, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(113, 47);
            this.panel4.TabIndex = 0;
            // 
            // pbExit
            // 
            this.pbExit.BackgroundImage = global::DentalClinicApp.Properties.Resources.icons8_exit_48;
            this.pbExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbExit.Location = new System.Drawing.Point(69, 7);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(32, 30);
            this.pbExit.TabIndex = 0;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // pbMinimaze
            // 
            this.pbMinimaze.BackgroundImage = global::DentalClinicApp.Properties.Resources.icons8_minimize_48;
            this.pbMinimaze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMinimaze.Location = new System.Drawing.Point(16, 7);
            this.pbMinimaze.Name = "pbMinimaze";
            this.pbMinimaze.Size = new System.Drawing.Size(34, 32);
            this.pbMinimaze.TabIndex = 0;
            this.pbMinimaze.TabStop = false;
            this.pbMinimaze.Click += new System.EventHandler(this.pbMinimaze_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.panelGetir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelGetir.ResumeLayout(false);
            this.panelGetir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panelSide.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimaze)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelGetir;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btnKullanıcılar;
        private System.Windows.Forms.Button btnIstatistikler;
        private System.Windows.Forms.Button btnMalzemeler;
        private System.Windows.Forms.Button btnOdemeler;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHasta2;
        private System.Windows.Forms.Button btnHasta1;
        private System.Windows.Forms.Button btnHastaIslemleri;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbMinimaze;
        private System.Windows.Forms.Button btnHasta3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonGetir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

