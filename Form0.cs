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
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        // 해외 설문지 변수들 //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // 1번 희망하는 해외여행 종류 변수들
        static public bool b_package = false;
        static public bool b_free = false;

        // 2번 여행가는 인원수 변수
        static public int personnel = 0;

        // 3번 여행 희망기간 변수
        static public int i_trip_day = 0;

        // 4번 여행지 지역 변수들
        //public static bool b_taiwan  = false;
        static public bool b_taiwan = false;
        static public bool b_china = false;
        static public bool b_japan = false;
        static public bool b_europe = false;
        static public bool b_us = false;

        // 5번 해외 여행 시 고려사항 변수들
        static public bool b_period = false;
        static public bool b_pay = false;
        static public bool b_security = false;
        static public bool b_goal = false;
        static public bool b_food = false;
        static public bool b_shopping = false;

        // 6번 1인당 예상 금액 변수들
        static public bool b_100 = false;
        static public bool b_200 = false;
        static public bool b_500 = false;
        static public bool b_500UP = false;

        // 7번 성별 변수
        static public bool b_man = false;
        static public bool b_girl = false;

        // 8번 나이 변수
        static public int i_age = 0;






        // 국내 설문지 변수들 //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // 1. 패키지여행 or 자유여행
        static public bool b_kor_package = false;
        static public bool b_kor_free = false;

        // 2. 여행가는 인원수
        static public bool b_kor_one = false;
        static public bool b_kor_two = false;
        static public bool b_kor_three = false;
        static public bool b_kor_four = false;

        // 3. 희망여행기간
        static public string str_kor_day = "";

        // 4. 희망 여행지
        static public bool b_kor_soul = false;
        static public bool b_kor_gyeonggi = false;
        static public bool b_kor_gangwon = false;
        static public bool b_kor_daejeon = false;
        static public bool b_kor_cheongju = false;
        static public bool b_kor_busan = false;

        // 5. 출발 지역
        static public bool b_kor_start_soul = false;
        static public bool b_kor_start_gyeonggi = false;
        static public bool b_kor_start_gangwon = false;
        static public bool b_kor_start_daejeon = false;
        static public bool b_kor_start_cheongju = false;
        static public bool b_kor_start_busan = false;


        // 6. 국내 여행시 고려사항
        static public bool b_kor_period = false;
        static public bool b_kor_pay = false;
        static public bool b_kor_food = false;
        static public bool b_kor_shopping = false;

        // 7. 교통수단
        static public bool b_kor_car = false;
        static public bool b_kor_bus = false;
        static public bool b_kor_etc = false;

        // 8. 1인당 예상금액
        static public bool b_kor_10 = false;
        static public bool b_kor_30 = false;
        static public bool b_kor_100 = false;
        static public bool b_kor_100UP = false;

        // 9. 당신의 성별
        static public bool b_kor_man = false;
        static public bool b_kor_girl = false;

        // 10. 당신의 나이는?
        static public string str_kor_age = "";




        private void tbn_Go_Click(object sender, EventArgs e)
        {
            btn_Go.Visible = false;

            lb_Q1.Visible = true;
            btn_Foreign.Visible = true;
            btn_Kor.Visible = true;


            //this.Visible = false;
            //Form1 form1 = new Form1();
            //form1.ShowDialog();
        }

        private void tbn_Foreign_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Visible = false;

            form1.Show(); // ShowDialog 쓸지도
        }

        private void tbn_Kor_Click(object sender, EventArgs e)
        {
            Form3_kor form3_kor = new Form3_kor();
            this.Visible = false;

            form3_kor.Show(); // ShowDialog 쓸지도
        }

        private void btn_End_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Calender_Click(object sender, EventArgs e)
        {
            MessageBox.Show("미구현입니다 (˵ • ᴗ < ˵ ) ✧");
        }

        private void btn_Analytics_Click(object sender, EventArgs e)
        {
            MessageBox.Show("미구현입니다 (˵ • ᴗ < ˵ ) ✧");
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            MessageBox.Show("현재 홈 위치입니다.");
        }
    }
}
