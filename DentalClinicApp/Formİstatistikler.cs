using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DentalClinicApp
{
    public partial class Formİstatistikler : Form
    {
        private string connectionString = "Server=localhost;Database=DentalClinic;Integrated Security=True;";

        public Formİstatistikler()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            LoadChart1();  
            LoadChart2(); 
        }

        
        private void LoadChart1()
        {
            string query = @"
                SELECT CONVERT(DATE, RandevuTarihi) AS tarih, COUNT(*) AS hasta_sayisi
                FROM dbo.HastaListesi
                WHERE CONVERT(DATE, RandevuTarihi) >= DATEADD(DAY, -10, GETDATE())
                GROUP BY CONVERT(DATE, RandevuTarihi)
                ORDER BY CONVERT(DATE, RandevuTarihi) DESC";

            FillChart(chart1, query, "Hasta Sayısı", SeriesChartType.Column);
        }

        
        private void LoadChart2()
        {
            string query = @"
                SELECT İslem, COUNT(*) AS islem_sayisi
                FROM dbo.HastaListesi
                GROUP BY İslem
                ORDER BY islem_sayisi DESC";

            FillChart(chart2, query, "İşlem Türü", SeriesChartType.Pie);
        }

      
        private void FillChart(Chart chart, string query, string seriesName, SeriesChartType chartType)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable data = new DataTable();
                adapter.Fill(data);

                chart.Series.Clear();
                chart.ChartAreas.Clear();
                chart.ChartAreas.Add(new ChartArea());

                Series series = new Series
                {
                    Name = seriesName,
                    IsValueShownAsLabel = true,
                    ChartType = chartType
                };

                foreach (DataRow row in data.Rows)
                {
                    series.Points.AddXY(row[0], row[1]);
                }

                chart.Series.Add(series);
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
