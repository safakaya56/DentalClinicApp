using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DentalClinicApp
{
    public partial class FormOdemeler : Form
    {
        public FormOdemeler()
        {
            InitializeComponent();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // -------------------------------------------------------------
        // TABPAGE 1
        // -------------------------------------------------------------

        private void btnAra_Click(object sender, EventArgs e)
        {
            string tcKimlik = txtTC.Text.Trim();
            if (string.IsNullOrEmpty(tcKimlik))
            {
                MessageBox.Show("Lütfen bir T.C. Kimlik numarası girin!");
                return;
            }

            string query = "SELECT TOP 1 Adsoyad, İslem FROM HastaListesi WHERE TCKimlik = @TCKimlik";
            string connectionString = "Server=localhost;Database=DentalClinic;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TCKimlik", tcKimlik);
                conn.Open();
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtIsim.Text = reader["Adsoyad"].ToString();
                    txtIslem.Text = reader["İslem"].ToString();
                }
                else
                {
                    MessageBox.Show("İlgili veri bulunamadı.");
                }
            }
        }

        private void btnOdemeEkle_Click(object sender, EventArgs e)
        {
            string tcKimlik = txtTC.Text.Trim();
            string adSoyad = txtIsim.Text.Trim();
            string odemeMiktari = txtMiktar.Text.Trim();



            if (string.IsNullOrEmpty(tcKimlik) || string.IsNullOrEmpty(adSoyad) || string.IsNullOrEmpty(odemeMiktari))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
                return;
            }


            if (!decimal.TryParse(odemeMiktari, out decimal miktar))
            {
                MessageBox.Show("Lütfen geçerli bir ödeme miktarı girin!");
                return;
            }

            if (miktar <= 0)
            {
                MessageBox.Show("Ödeme miktarı sıfırdan büyük olmalıdır!");
                return;
            }


            string connectionString = "Server=localhost;Database=DentalClinic;Trusted_Connection=True;";
            string kontrolQuery = "SELECT COUNT(*) FROM Odemeler WHERE TCKimlik = @TCKimlik";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand kontrolCmd = new SqlCommand(kontrolQuery, conn))
            {
                kontrolCmd.Parameters.AddWithValue("@TCKimlik", tcKimlik);
                conn.Open();

                int kayitSayisi = (int)kontrolCmd.ExecuteScalar();
                if (kayitSayisi > 0)
                {
                    MessageBox.Show("Bu kişiye ait bir ödeme kaydı zaten mevcut.Lütfen Borç İşlemleri sekmesinden düzenleme yapınız.");
                    ClearData();
                    return;
                }

                string ekleQuery = "INSERT INTO Odemeler (TCKimlik, Adsoyad, OdemeMiktari) VALUES (@TCKimlik, @Adsoyad, @OdemeMiktari)";
                using (SqlCommand ekleCmd = new SqlCommand(ekleQuery, conn))
                {
                    ekleCmd.Parameters.AddWithValue("@TCKimlik", tcKimlik);
                    ekleCmd.Parameters.AddWithValue("@Adsoyad", adSoyad);
                    ekleCmd.Parameters.AddWithValue("@OdemeMiktari", decimal.Parse(odemeMiktari));
                    ekleCmd.ExecuteNonQuery();

                    MessageBox.Show("Ödeme başarıyla eklendi.");
                    ClearData();
                }
            }
        }

        private void ClearData()
        {
            txtTC.Clear();
            txtIsim.Clear();
            txtMiktar.Clear();
            txtIslem.Clear();
        }

        // -------------------------------------------------------------
        // TABPAGE 2
        // -------------------------------------------------------------

        private void btnOdemeBilgisi_Click(object sender, EventArgs e)
        {
            string tcKimlik = txtTC1.Text.Trim();
            if (string.IsNullOrEmpty(tcKimlik))
            {
                MessageBox.Show("Lütfen bir T.C. Kimlik numarası girin!");
                return;
            }

            string query = "SELECT TOP 1 Adsoyad, OdemeMiktari FROM Odemeler WHERE TCKimlik = @TCKimlik";
            string connectionString = "Server=localhost;Database=DentalClinic;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TCKimlik", tcKimlik);
                conn.Open();
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtIsim1.Text = reader["Adsoyad"].ToString();
                    txtBorc.Text = reader["OdemeMiktari"].ToString();
                }
                else
                {
                    MessageBox.Show("Bu T.C. Kimlik numarası ile ödeme kaydı bulunamadı.");
                }
            }
        }

        private void btnOdemeEkle1_Click(object sender, EventArgs e)
        {
            try
            {
                string tcKimlik = txtTC1.Text.Trim();
                decimal mevcutBorc = decimal.Parse(txtBorc.Text.Trim());
                decimal odemeMiktari = decimal.Parse(txtMiktar1.Text.Trim());

                if (odemeMiktari <= 0)
                {
                    MessageBox.Show("Lütfen geçerli bir ödeme miktarı girin!");
                    return;
                }

                if (odemeMiktari > mevcutBorc)
                {
                    MessageBox.Show("Ödeme miktarı borçtan fazla olamaz!");
                    return;
                }

                decimal yeniBorc = mevcutBorc - odemeMiktari;
                string connectionString = "Server=localhost;Database=DentalClinic;Trusted_Connection=True;";

                string query = yeniBorc > 0
                    ? "UPDATE Odemeler SET OdemeMiktari = @YeniBorc WHERE TCKimlik = @TCKimlik"
                    : "DELETE FROM Odemeler WHERE TCKimlik = @TCKimlik";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@YeniBorc", yeniBorc);
                    cmd.Parameters.AddWithValue("@TCKimlik", tcKimlik);
                    conn.Open();
                    cmd.ExecuteNonQuery();


                    MessageBox.Show(yeniBorc > 0 ? "Ödeme alındı. Güncellenmiş borç: " + yeniBorc : "Borç tamamen ödendi ve kayıt silindi.");
                    if (yeniBorc == 0)
                    {
                        txtIsim1.Clear();
                        txtBorc.Clear();
                        txtMiktar1.Clear();
                    }
                    else
                    {
                        txtBorc.Text = yeniBorc.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
