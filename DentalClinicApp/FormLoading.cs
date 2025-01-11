using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinicApp
{
    public partial class FormLoading : Form
    {
        public FormLoading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            progressBarLoading.Value += 1;
            
            if (progressBarLoading.Value==100)
            {
                timer1.Stop();
                progressBarLoading.Enabled = false;
                this.Hide();
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
            }
        }
    }
}
