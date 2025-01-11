
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DentalClinicApp
{
    public partial class FormLogin : Form
    {
        private readonly string connectionString = "Server=localhost;Database=DentalClinic;Trusted_Connection=True;";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBoxKullaniciAdi.Text.Trim();
            string sifre = textBoxSifre.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", kullaniciAdi);
                command.Parameters.AddWithValue("@Password", sifre);

                connection.Open();
                int result = (int)command.ExecuteScalar();
                connection.Close();

                if (result > 0)
                {
                    this.Hide();
                    FormMain formMain = new FormMain();
                    formMain.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimaze_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void chckSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chckSifreGoster.Checked)
            {
                textBoxSifre.PasswordChar = '\0'; 
            }
            else
            {
                textBoxSifre.PasswordChar = '*'; 
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxSifre.PasswordChar = '*';
        }
    }
}
