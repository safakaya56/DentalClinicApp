using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DentalClinicApp
{
    public partial class FormGunlukListe : Form
    {
        public FormGunlukListe()
        {
            InitializeComponent();
        }


        string connectionString = "Server=localhost;Database=DentalClinic;Trusted_Connection=True;";



        private void FormGunlukListe_Load(object sender, EventArgs e)
        {

            DateTime today = DateTime.Today;


            string query = "SELECT RandevuTarihi, RandevuSaati, TCKimlik, Adsoyad, İslem, Doktor " +
                           "FROM HastaListesi WHERE RandevuTarihi = @today";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@today", today);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);


                dataGridViewGunluk.DataSource = dataTable;
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
