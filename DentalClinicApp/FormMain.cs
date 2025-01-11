using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DentalClinicApp
{
    public partial class FormMain : Form
    {
        string connectionString = "Server=localhost;Database=DentalClinic;Integrated Security=True;";

        public FormMain()
        {
            InitializeComponent();
        }

        private Form activeForm = null;


        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelGetir.Controls.Add(childForm);
            panelGetir.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnOdemeler_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormOdemeler());
        }

        private void btnMalzemeler_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMalzemeler());
        }

        private void btnIstatistikler_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formİstatistikler());
        }

        private void btnKullanıcılar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormKullanıcılar());
        }

        private void pbMinimaze_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHasta2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRandevu());
        }

        private void btnHasta3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHastaListesi());
        }

        private void btnHasta1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormGunlukListe());
        }





        private void LoadChart1()
        {
            string query = @"
                SELECT Doktor, COUNT(*) AS HastaSayisi
                FROM HastaListesi
                WHERE CONVERT(DATE, RandevuTarihi) = CONVERT(DATE, GETDATE())
                GROUP BY Doktor";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable data = new DataTable();
            adapter.Fill(data);

            chart1.Series.Clear();

            Series series = new Series
            {
                Name = "Hasta Sayısı",
                ChartType = SeriesChartType.Column
            };

            foreach (DataRow row in data.Rows)
            {
                series.Points.AddXY(row["Doktor"], row["HastaSayisi"]);
            }

            chart1.Series.Add(series);
        }





        private void LoadChart2()
        {
            string query = @"
                SELECT İslem, COUNT(*) AS IslemSayisi
                FROM HastaListesi
                WHERE CONVERT(DATE, RandevuTarihi) = CONVERT(DATE, GETDATE())
                GROUP BY İslem";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable data = new DataTable();
            adapter.Fill(data);

            chart2.Series.Clear();

            Series series = new Series
            {
                Name = "İşlem Türü",
                ChartType = SeriesChartType.Pie
            };

            foreach (DataRow row in data.Rows)
            {
                series.Points.AddXY(row["İslem"], row["IslemSayisi"]);
            }

            chart2.Series.Add(series);
        }





        private void LoadDataGrid()
        {
            // Şu anki saati al
            TimeSpan currentTime = DateTime.Now.TimeOfDay;

            // SQL sorgusu: Şu anki saatten sonrasını sorgula (ilk 5 hasta)
            string query = @"
                SELECT TOP 5 RandevuTarihi, RandevuSaati, TCKimlik, Adsoyad, İslem, Doktor
                FROM HastaListesi
                WHERE CONVERT(DATE, RandevuTarihi) = CONVERT(DATE, GETDATE()) AND
                      CONVERT(TIME, RandevuSaati) >= @CurrentTime
                ORDER BY RandevuSaati ASC";


            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CurrentTime", currentTime);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);


            dataGridView1.DataSource = data;
        }




        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadChart1();
            LoadChart2();
        }





        private void buttonGetir_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
    }
}
