namespace DentalClinicApp
{
    partial class FormLogin
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelGirisEkrani = new System.Windows.Forms.Panel();
            this.chckSifreGoster = new System.Windows.Forms.CheckBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelSifre = new System.Windows.Forms.Label();
            this.labelUyari = new System.Windows.Forms.Label();
            this.labelUyari2 = new System.Windows.Forms.Label();
            this.labelKullaniciAdi = new System.Windows.Forms.Label();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbMinimaze = new System.Windows.Forms.PictureBox();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelGirisEkrani.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimaze)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(127)))), ((int)(((byte)(122)))));
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Controls.Add(this.panel2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(525, 700);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::DentalClinicApp.Properties.Resources.loginLogo;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(52, 84);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(424, 430);
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(536, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 607);
            this.panel2.TabIndex = 1;
            // 
            // panelGirisEkrani
            // 
            this.panelGirisEkrani.BackColor = System.Drawing.Color.White;
            this.panelGirisEkrani.Controls.Add(this.chckSifreGoster);
            this.panelGirisEkrani.Controls.Add(this.buttonLogin);
            this.panelGirisEkrani.Controls.Add(this.labelSifre);
            this.panelGirisEkrani.Controls.Add(this.labelUyari);
            this.panelGirisEkrani.Controls.Add(this.labelUyari2);
            this.panelGirisEkrani.Controls.Add(this.labelKullaniciAdi);
            this.panelGirisEkrani.Controls.Add(this.textBoxSifre);
            this.panelGirisEkrani.Controls.Add(this.textBoxKullaniciAdi);
            this.panelGirisEkrani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGirisEkrani.Location = new System.Drawing.Point(525, 0);
            this.panelGirisEkrani.Name = "panelGirisEkrani";
            this.panelGirisEkrani.Size = new System.Drawing.Size(675, 700);
            this.panelGirisEkrani.TabIndex = 2;
            // 
            // chckSifreGoster
            // 
            this.chckSifreGoster.AutoSize = true;
            this.chckSifreGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckSifreGoster.Location = new System.Drawing.Point(242, 329);
            this.chckSifreGoster.Name = "chckSifreGoster";
            this.chckSifreGoster.Size = new System.Drawing.Size(134, 24);
            this.chckSifreGoster.TabIndex = 4;
            this.chckSifreGoster.Text = "Şifreyi Göster";
            this.chckSifreGoster.UseVisualStyleBackColor = true;
            this.chckSifreGoster.CheckedChanged += new System.EventHandler(this.chckSifreGoster_CheckedChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(127)))), ((int)(((byte)(122)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonLogin.Location = new System.Drawing.Point(123, 323);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(92, 34);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Giriş";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelSifre
            // 
            this.labelSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSifre.Location = new System.Drawing.Point(119, 224);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(88, 25);
            this.labelSifre.TabIndex = 3;
            this.labelSifre.Text = "Şifre";
            // 
            // labelUyari
            // 
            this.labelUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUyari.ForeColor = System.Drawing.Color.Red;
            this.labelUyari.Location = new System.Drawing.Point(119, 404);
            this.labelUyari.Name = "labelUyari";
            this.labelUyari.Size = new System.Drawing.Size(96, 24);
            this.labelUyari.TabIndex = 3;
            this.labelUyari.Text = "UYARI!";
            // 
            // labelUyari2
            // 
            this.labelUyari2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUyari2.Location = new System.Drawing.Point(119, 428);
            this.labelUyari2.Name = "labelUyari2";
            this.labelUyari2.Size = new System.Drawing.Size(327, 44);
            this.labelUyari2.TabIndex = 3;
            this.labelUyari2.Text = "Hesap oluşturmak için yetkili kişi ile iletişime geçin";
            // 
            // labelKullaniciAdi
            // 
            this.labelKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKullaniciAdi.Location = new System.Drawing.Point(119, 121);
            this.labelKullaniciAdi.Name = "labelKullaniciAdi";
            this.labelKullaniciAdi.Size = new System.Drawing.Size(111, 25);
            this.labelKullaniciAdi.TabIndex = 3;
            this.labelKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(123, 261);
            this.textBoxSifre.Multiline = true;
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.PasswordChar = '*';
            this.textBoxSifre.Size = new System.Drawing.Size(323, 35);
            this.textBoxSifre.TabIndex = 2;
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(123, 158);
            this.textBoxKullaniciAdi.Multiline = true;
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(323, 35);
            this.textBoxKullaniciAdi.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(127)))), ((int)(((byte)(122)))));
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(525, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 47);
            this.panel3.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.pbExit);
            this.panel1.Controls.Add(this.pbMinimaze);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(562, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 47);
            this.panel1.TabIndex = 0;
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
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelGirisEkrani);
            this.Controls.Add(this.panelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "666666666666666666666666666666666666666666666666666666666666666666666666666666666" +
    "666666666666666666666666666666666";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelGirisEkrani.ResumeLayout(false);
            this.panelGirisEkrani.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimaze)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelGirisEkrani;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.Label labelKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Label labelUyari2;
        private System.Windows.Forms.Label labelUyari;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbMinimaze;
        private System.Windows.Forms.CheckBox chckSifreGoster;
    }
}