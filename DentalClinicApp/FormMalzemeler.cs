using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DentalClinicApp
{
    public partial class FormMalzemeler : Form
    {
        private string connectionString = "Server=localhost;Database=DentalClinic;Trusted_Connection=True;";

        public FormMalzemeler()
        {
            InitializeComponent();
        }

        private void pbExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeriArama_Click_1(object sender, EventArgs e)
        {
            string seri = txtSeriArama.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Malzemeler WHERE SeriNumarasi = @Seri", con);
                cmd.Parameters.AddWithValue("@Seri", seri);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtGosterAd.Text = reader["MalzemeAdi"].ToString();
                        txtGosterTur.Text = reader["MalzemeTuru"].ToString();
                        txtGosterMiktar.Text = reader["StokMiktari"].ToString();
                        txtGosterFiyat.Text = reader["BirimFiyati"].ToString();
                        txtGosterSeri.Text = reader["SeriNumarasi"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Malzeme bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMiktar.Text, out int miktar) || !decimal.TryParse(txtFiyat.Text, out decimal fiyat))
            {
                MessageBox.Show("Lütfen geçerli bir miktar ve fiyat girin.");
                return;
            }

            string query = "INSERT INTO Malzemeler (MalzemeAdi, MalzemeTuru, StokMiktari, BirimFiyati, SeriNumarasi) VALUES (@Ad, @Tur, @Miktar, @Fiyat, @Seri)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@Tur", txtTur.Text);
                cmd.Parameters.AddWithValue("@Miktar", miktar);
                cmd.Parameters.AddWithValue("@Fiyat", fiyat);
                cmd.Parameters.AddWithValue("@Seri", txtSeriEkleme.Text);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Malzeme başarıyla eklendi.");
                    ClearTextBoxes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            string seri = txtSeriSilme.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Malzemeler WHERE SeriNumarasi = @Seri", con);
                cmd.Parameters.AddWithValue("@Seri", seri);

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show("Malzeme silindi.");
                    else
                        MessageBox.Show("Malzeme bulunamadı.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            string seri = txtSeriSilme.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
           
                SqlCommand cmd = new SqlCommand("SELECT * FROM Malzemeler WHERE SeriNumarasi = @Seri", con);
                cmd.Parameters.AddWithValue("@Seri", seri);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                   
                    if (reader.Read())
                    {
                        txtAd.Text = reader["MalzemeAdi"].ToString();
                        txtTur.Text = reader["MalzemeTuru"].ToString();
                        txtMiktar.Text = reader["StokMiktari"].ToString();
                        txtFiyat.Text = reader["BirimFiyati"].ToString();
                        txtSeriEkleme.Text = reader["SeriNumarasi"].ToString();
                        reader.Close();

                        
                        SqlCommand deleteCmd = new SqlCommand("DELETE FROM Malzemeler WHERE SeriNumarasi = @Seri", con);
                        deleteCmd.Parameters.AddWithValue("@Seri", seri);
                        deleteCmd.ExecuteNonQuery();

                        MessageBox.Show("Malzeme bilgileri düzenleme kısmına taşındı ve veritabanından silindi. Yeni malzeme ekleyebilirsiniz.");
                    }
                    else
                    {
                        MessageBox.Show("Seri numarasına ait malzeme bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }


        private void ClearTextBoxes()
        {
            txtAd.Clear();
            txtTur.Clear();
            txtMiktar.Clear();
            txtFiyat.Clear();
            txtSeriEkleme.Clear();
        }
    }
}
