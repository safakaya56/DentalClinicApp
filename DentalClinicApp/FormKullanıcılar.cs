using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace DentalClinicApp
{
    public partial class FormKullanıcılar : Form
    {
        private readonly string connectionString = "Server=localhost;Database=DentalClinic;Trusted_Connection=True;";

        public FormKullanıcılar()
        {
            InitializeComponent();
            LoadUsers();
        }




        
        private void LoadUsers()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewUsers.DataSource = dataTable;
            }
        }





        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }






        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text))
            {
                MessageBox.Show("Lütfen tam adı girin.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adını girin.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Lütfen şifreyi girin.");
                return;
            }

            if (comboBoxTitle.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir pozisyon seçin.");
                return;
            }

            using (var connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (FullName, Username, Password, Title, ProfilePicture) VALUES (@FullName, @Username, @Password, @Title, @ProfilePicture)";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FullName", textBoxFullName.Text.Trim());
                command.Parameters.AddWithValue("@Username", textBoxUsername.Text.Trim());
                command.Parameters.AddWithValue("@Password", textBoxPassword.Text.Trim());
                command.Parameters.AddWithValue("@Title", comboBoxTitle.SelectedItem.ToString());

                if (pictureBoxProfile.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBoxProfile.Image.Save(ms, pictureBoxProfile.Image.RawFormat);
                        command.Parameters.Add("@ProfilePicture", SqlDbType.VarBinary).Value = ms.ToArray();
                    }
                }
                else
                {
                    command.Parameters.Add("@ProfilePicture", SqlDbType.VarBinary).Value = DBNull.Value;
                }

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                LoadUsers();
                MessageBox.Show("Kullanıcı eklendi.");
            }
        }



        
        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["Id"].Value);
                using (var connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Users WHERE Id = @Id";
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", userId);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    LoadUsers();
                    MessageBox.Show("Kullanıcı silindi.");
                }
            }
            else
            {
                MessageBox.Show("Silmek için bir kullanıcı seçin.");
            }
        }




       
        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxProfile.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
