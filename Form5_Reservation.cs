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
    public partial class Form5_Reservation : Form
    {
        public Form5_Reservation()
        {
            InitializeComponent();

        }



        private void btnHome_Click(object sender, EventArgs e)
        {
            Form0 form0 = new Form0();
            form0.Visible = true;

            this.Close(); // ShowDialog 쓸지도
        }

        private void Analytics_Click(object sender, EventArgs e)
        {
            MessageBox.Show("미구현입니다 (˵ • ᴗ < ˵ ) ✧");
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            MessageBox.Show("미구현입니다 (˵ • ᴗ < ˵ ) ✧");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Form6_Food form6_Food = new Form6_Food();

            form6_Food.ShowDialog();
        }

        private void btnCheck1_Click(object sender, EventArgs e)
        {
            int a = Form6_Food.total;

            lbOrder1.Text = Form6_Food.str + a.ToString() + "원";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }
    }
}
