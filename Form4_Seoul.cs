using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject_Travel
{
    public partial class Form4_Seoul : Form
    {
        public Form4_Seoul()
        {
            InitializeComponent();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            Form5_Reservation form5_Reservation = new Form5_Reservation();
            form5_Reservation.Show();
            this.Close();
        }

        private void btn_End_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form0 form0 = new Form0();
            form0.Visible = true;

            this.Close(); // ShowDialog 쓸지도
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            MessageBox.Show("미구현입니다 (˵ • ᴗ < ˵ ) ✧");
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            MessageBox.Show("미구현입니다 (˵ • ᴗ < ˵ ) ✧");
        }
    }
}
