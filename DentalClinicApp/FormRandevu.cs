using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DentalClinicApp
{
    public partial class FormRandevu : Form
    {
        public FormRandevu()
        {
            InitializeComponent();

            DateTime today = DateTime.Today;
            dateTimePickerTarih.MinDate = today;
            dateTimePickerTarih.MaxDate = today;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private bool IsTimeTaken(string tarih, string saat)
        {
            using (SqlConnection connection = new SqlConnection("Server=localhost;Database=DentalClinic;Trusted_Connection=True;"))
            {
                string query = "SELECT COUNT(*) FROM Appointments WHERE RandevuTarihi = @RandevuTarihi AND RandevuSaati = @RandevuSaati";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@RandevuTarihi", tarih);
                command.Parameters.AddWithValue("@RandevuSaati", saat);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                    return true; 
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void ClearData()
        {
            cmbDoktor.SelectedIndex = -1; 
            cmbİslem.SelectedIndex = -1; 
            txtTC.Text = string.Empty;
            txtAdsoyad.Text = string.Empty;
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {

            string tarih = dateTimePickerTarih.Value.ToString("yyyy-MM-dd");
            string doktor = cmbDoktor.SelectedItem?.ToString();
            string saat = comboBoxSaat.SelectedItem?.ToString(); 
            string tcKimlik = txtTC.Text;
            string islem = cmbİslem.SelectedItem?.ToString(); 
            string adSoyad = txtAdsoyad.Text;

           
            if (string.IsNullOrEmpty(saat))
            {
                MessageBox.Show("Lütfen bir saat seçiniz!");
                return;
            }

            
            if (IsTimeTaken(tarih, saat))
            {
                MessageBox.Show("Bu saat dolu. Lütfen başka bir saat seçiniz.");
                return;
            }

            
            using (SqlConnection connection = new SqlConnection("Server=localhost;Database=DentalClinic;Trusted_Connection=True;"))
            {
                string queryAppointments = "INSERT INTO Appointments (RandevuTarihi, RandevuSaati, TCKimlik, Adsoyad, İslem ,Doktor) " +
                               "VALUES (@RandevuTarihi, @RandevuSaati, @TCKimlik, @Adsoyad, @Islem, @Doktor)";

                string queryHastaListesi = "INSERT INTO HastaListesi (RandevuTarihi, RandevuSaati, TCKimlik, Adsoyad, İslem, Doktor) " +
                                  "VALUES (@RandevuTarihi, @RandevuSaati, @TCKimlik, @Adsoyad, @Islem, @Doktor)";


                SqlCommand commandAppointments = new SqlCommand(queryAppointments, connection);
                SqlCommand commandHastaListesi = new SqlCommand(queryHastaListesi, connection);

                commandAppointments.Parameters.AddWithValue("@RandevuTarihi", tarih);
                commandAppointments.Parameters.AddWithValue("@Doktor", doktor);
                commandAppointments.Parameters.AddWithValue("@TCKimlik", tcKimlik);
                commandAppointments.Parameters.AddWithValue("@RandevuSaati", saat);
                commandAppointments.Parameters.AddWithValue("@Islem", islem);
                commandAppointments.Parameters.AddWithValue("@Adsoyad", adSoyad);

                commandHastaListesi.Parameters.AddWithValue("@RandevuTarihi", tarih);
                commandHastaListesi.Parameters.AddWithValue("@Doktor", doktor);
                commandHastaListesi.Parameters.AddWithValue("@TCKimlik", tcKimlik);
                commandHastaListesi.Parameters.AddWithValue("@RandevuSaati", saat);
                commandHastaListesi.Parameters.AddWithValue("@Islem", islem);
                commandHastaListesi.Parameters.AddWithValue("@Adsoyad", adSoyad);

                try
                {
                    connection.Open();
                    commandAppointments.ExecuteNonQuery();
                    commandHastaListesi.ExecuteNonQuery();
                    MessageBox.Show("Randevu kaydedildi.");
                    ClearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
