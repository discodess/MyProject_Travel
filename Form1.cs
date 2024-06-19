using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MyProject_Travel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            // 1번 희망하는 해외여행 종류
            if (rb_Package.Checked) Form0.b_package = true;
            else if (!rb_Package.Checked) Form0.b_package = false;

            if (rb_Free.Checked) Form0.b_free = true;
            else if (!rb_Free.Checked) Form0.b_free = false;


            // 2번 여행가는 인원수
            if (rb_One.Checked) Form0.personnel = 1;
            else if (!rb_One.Checked) Form0.personnel = 0;

            if (rb_Two.Checked) Form0.personnel = 1;
            else if (!rb_Two.Checked) Form0.personnel = 0;

            if (rb_Three.Checked) Form0.personnel = 1;
            else if (!rb_Three.Checked) Form0.personnel = 0;

            if (rb_Four.Checked) Form0.personnel = 1;
            else if (!rb_Four.Checked) Form0.personnel = 0;

            // 3번 희망 여행기간
            Form0.i_trip_day = int.Parse(tb_Day.Text);
            //Form0.i_trip_day = int.Parse(tb_Age.Text);

            // 4번 여행지 체크박스 
            if (rb_Taiwan.Checked)
            {
                Form0.b_taiwan = true;
                //MessageBox.Show(Form0.b_taiwan.ToString());   // 잘 되는지 확인해보는 코드
            }
            else if (!rb_Taiwan.Checked) Form0.b_taiwan = false;

            if (rb_China.Checked) Form0.b_china = true;
            else if (!rb_China.Checked) Form0.b_china = false;

            if (rb_Japan.Checked) Form0.b_japan = true;
            else if (!rb_Japan.Checked) Form0.b_japan = false;

            if (rb_Europe.Checked) Form0.b_europe = true;
            else if (!rb_Europe.Checked) Form0.b_europe = false;

            if (rb_US.Checked) Form0.b_us = true;
            else if (!rb_US.Checked) Form0.b_us = false;


            // 5번 여행 시 고려사항        
            if (cb_Period.Checked) Form0.b_period = true;
            else if (!cb_Period.Checked) Form0.b_period = false;

            if (cb_Pay.Checked) Form0.b_pay = true;
            else if (!cb_Pay.Checked) Form0.b_pay = false;

            if (cb_Security.Checked) Form0.b_security = true;
            else if (!cb_Security.Checked) Form0.b_security = false;

            if (cb_Goal.Checked) Form0.b_goal = true;
            else if (!cb_Goal.Checked) Form0.b_goal = false;

            if (cb_Food.Checked) Form0.b_food = true;
            else if (!cb_Food.Checked) Form0.b_food = false;

            if (cb_Shopping.Checked) Form0.b_shopping = true;
            else if (!cb_Shopping.Checked) Form0.b_shopping = false;


            // 6번 여행 예상 금액
            if (rb_100.Checked) Form0.b_100 = true;
            else if (!rb_100.Checked) Form0.b_100 = false;

            if (rb_200.Checked) Form0.b_200 = true;
            else if (!rb_200.Checked) Form0.b_200 = false;

            if (rb_500.Checked) Form0.b_500 = true;
            else if (!rb_500.Checked) { Form0.b_500 = false; }

            if (rb_500UP.Checked) Form0.b_500UP = true;
            else if (!rb_500UP.Checked) { Form0.b_500UP = false; }


            // 7번 성별
            if (rb_Man.Checked) Form0.b_man = true;
            else if (!rb_Man.Checked) Form0.b_man = false;

            if (rb_Girl.Checked) Form0.b_girl = true;
            else if (!rb_Girl.Checked) Form0.b_girl = false;

            // 8번 나이
            Form0.i_age = int.Parse(tb_Age.Text);


        }

        private void btn_End_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            MessageBox.Show("미구현입니다 (˵ • ᴗ < ˵ ) ✧");
        }

        private void btn_Analytics_Click(object sender, EventArgs e)
        {
            MessageBox.Show("미구현입니다 (˵ • ᴗ < ˵ ) ✧");
        }

        private void btn_Calender_Click(object sender, EventArgs e)
        {
            MessageBox.Show("미구현입니다 (˵ • ᴗ < ˵ ) ✧");
        }
    }
}
