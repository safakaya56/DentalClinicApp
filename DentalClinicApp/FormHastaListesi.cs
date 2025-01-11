using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace DentalClinicApp
{
    public partial class FormHastaListesi : Form
    {
        private readonly string connectionString = "Server=localhost;Database=DentalClinic;Trusted_Connection=True;";

        public FormHastaListesi()
        {
            InitializeComponent();
            LoadHastaListesi();
        }

        private void LoadHastaListesi()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM HastaListesi";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewListe.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hasta listesi yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaldir_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewListe.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewListe.SelectedRows[0];

                if (selectedRow.Cells["TCKimlik"] == null || selectedRow.Cells["TCKimlik"].Value == null)
                {
                    MessageBox.Show("Geçerli bir TCKimlik bilgisi bulunamadı.");
                    return;
                }

                string tcKimlik = selectedRow.Cells["TCKimlik"].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Seçili kaydı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM HastaListesi WHERE TCKimlik = @TCKimlik";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@TCKimlik", tcKimlik);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Kayıt başarıyla silindi.");

                        LoadHastaListesi();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçiniz.");
            }
        }
    }
}
