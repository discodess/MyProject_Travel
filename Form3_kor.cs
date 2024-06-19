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
    public partial class Form3_kor : Form
    {
        public Form3_kor()              // 국내 여행 설문지
        {
            InitializeComponent();
        }

        private void btn_kor_Next_Click(object sender, EventArgs e)
        {
            // 1번 희망하는 해외여행 종류
            if (rb_kor_Package.Checked) Form0.b_kor_package = true;
            else if (!rb_kor_Package.Checked) Form0.b_kor_package = false;      // ok

            if (rb_kor_Free.Checked) Form0.b_kor_free = true;
            else if (!rb_kor_Free.Checked) Form0.b_kor_free = false;            // ok


            // 2번 여행가는 인원수
            if (rb_kor_One.Checked) Form0.b_kor_one = true;
            else if (!rb_kor_One.Checked) Form0.b_kor_one = false;

            if (rb_kor_Two.Checked) Form0.b_kor_two = true;
            else if (!rb_kor_Two.Checked) Form0.b_kor_two = false;

            if (rb_kor_Three.Checked) Form0.b_kor_three = true;
            else if (!rb_kor_Three.Checked) Form0.b_kor_three = false;

            if (rb_kor_Four.Checked) Form0.b_kor_four = true;
            else if (!rb_kor_Four.Checked) Form0.b_kor_four = false;

            // 3번 희망 여행기간
            Form0.str_kor_day = string.Format(tb_kor_Day.Text);
            //Form0.i_trip_day = int.Parse(tb_Age.Text);

            // 4번 희망 여행지 체크박스 
            if (rb_kor_Soul.Checked) Form0.b_kor_soul = true;
            else if (!rb_kor_Soul.Checked) Form0.b_kor_soul = false;

            if (rb_kor_Gyeonggi.Checked) Form0.b_kor_gyeonggi = true;
            else if (!rb_kor_Gyeonggi.Checked) Form0.b_kor_gyeonggi = false;        // ok

            if (rb_kor_Gangwon.Checked) Form0.b_kor_gangwon = true;
            else if (!rb_kor_Gangwon.Checked) Form0.b_kor_gangwon = false;

            if (rb_kor_Daejeon.Checked) Form0.b_kor_daejeon = true;
            else if (!rb_kor_Daejeon.Checked) Form0.b_kor_daejeon = false;

            if (rb_kor_Cheongju.Checked) Form0.b_kor_cheongju = true;
            else if (!rb_kor_Cheongju.Checked) Form0.b_kor_cheongju = false;



            // 5번 출발 지역
            if (rb_kor_start_Soul.Checked) Form0.b_kor_start_soul = true;
            else if (!rb_kor_start_Soul.Checked) Form0.b_kor_start_soul = false;

            if (rb_kor_start_Gyeonggi.Checked) Form0.b_kor_start_gyeonggi = true;
            else if (!rb_kor_start_Gyeonggi.Checked) Form0.b_kor_start_gyeonggi = false;        // ok

            if (rb_kor_start_Gangwon.Checked) Form0.b_kor_start_gangwon = true;
            else if (!rb_kor_start_Gangwon.Checked) Form0.b_kor_start_gangwon = false;

            if (rb_kor_start_Daejeon.Checked) Form0.b_kor_start_daejeon = true;
            else if (!rb_kor_start_Daejeon.Checked) Form0.b_kor_start_daejeon = false;

            if (rb_kor_start_Cheongju.Checked) Form0.b_kor_start_cheongju = true;
            else if (!rb_kor_start_Cheongju.Checked) Form0.b_kor_start_cheongju = false;



            // 6번 여행 시 고려사항        
            if (cb_kor_Period.Checked) Form0.b_kor_period = true;
            else if (!cb_kor_Period.Checked) Form0.b_kor_period = false;

            if (cb_kor_Pay.Checked) Form0.b_kor_pay = true;
            else if (!cb_kor_Pay.Checked) Form0.b_kor_pay = false;

            if (cb_kor_Food.Checked) Form0.b_kor_food = true;
            else if (!cb_kor_Food.Checked) Form0.b_kor_food = false;

            if (cb_kor_Shopping.Checked) Form0.b_kor_shopping = true;
            else if (!cb_kor_Shopping.Checked) Form0.b_kor_shopping = false;


            // 7번 교통수단
            if (rb_kor_Car.Checked) Form0.b_kor_car = true;
            else if (!rb_kor_Car.Checked) Form0.b_kor_car = false;

            if (rb_kor_Bus.Checked) Form0.b_kor_bus = true;
            else if (!rb_kor_Bus.Checked) Form0.b_kor_bus = false;

            if (rb_kor_etc.Checked) Form0.b_kor_etc = true;
            else if (!rb_kor_etc.Checked) Form0.b_kor_etc = false;



            // 8번 여행 예상 금액
            if (rb_kor_10.Checked) Form0.b_kor_10 = true;
            else if (!rb_kor_10.Checked) Form0.b_kor_10 = false;

            if (rb_kor_30.Checked) Form0.b_kor_30 = true;
            else if (!rb_kor_30.Checked) Form0.b_kor_30 = false;

            if (rb_kor_100.Checked) Form0.b_kor_100 = true;
            else if (!rb_kor_100.Checked) { Form0.b_kor_100 = false; }

            if (rb_kor_100UP.Checked) Form0.b_kor_100UP = true;
            else if (!rb_kor_100UP.Checked) { Form0.b_kor_100UP = false; }


            // 9번 성별
            if (rb_kor_Man.Checked) Form0.b_kor_man = true;
            else if (!rb_kor_Man.Checked) Form0.b_kor_man = false;

            if (rb_kor_Girl.Checked) Form0.b_kor_girl = true;
            else if (!rb_kor_Girl.Checked) Form0.b_kor_girl = false;

            // 10번 나이
            Form0.str_kor_age = string.Format(tb_kor_Age.Text);


            if (!(rb_kor_Package.Checked || rb_kor_Free.Checked))
            {
                MessageBox.Show("1번 문항을 체크하세요.");
                return;
            }
            if (!(rb_kor_One.Checked || rb_kor_Two.Checked || rb_kor_Three.Checked || rb_kor_Four.Checked))
            {
                MessageBox.Show("2번 문항을 체크하세요.");
                return;
            }
            if (tb_kor_Day == null)
            {
                MessageBox.Show("3번 문항을 작성하세요.");
                return;
            }
            if (!(rb_kor_Soul.Checked || rb_kor_Gyeonggi.Checked || rb_kor_Gangwon.Checked || rb_kor_Daejeon.Checked || rb_kor_Cheongju.Checked || rb_kor_Busan.Checked))
            {
                MessageBox.Show("4번 문항을 체크하세요.");
                return;
            }
            if (!(rb_kor_start_Soul.Checked || rb_kor_start_Gyeonggi.Checked || rb_kor_start_Gangwon.Checked || rb_kor_start_Daejeon.Checked || rb_kor_start_Cheongju.Checked || rb_kor_start_Busan.Checked))
            {
                MessageBox.Show("5번 문항을 체크하세요.");
                return;
            }

            if (!(cb_kor_Period.Checked || cb_kor_Pay.Checked || cb_kor_Food.Checked || cb_kor_Shopping.Checked))
            {
                MessageBox.Show("6번 문항을 체크하세요.");
                return;
            }

            if (!(rb_kor_Car.Checked || rb_kor_Bus.Checked || rb_kor_etc.Checked))
            {
                MessageBox.Show("7번 문항을 체크하세요.");
                return;
            }

            if (!(rb_kor_10.Checked || rb_kor_30.Checked || rb_kor_100.Checked || rb_kor_100UP.Checked))
            {
                MessageBox.Show("8번 문항을 체크하세요.");
                return;
            }

            if (!(rb_kor_Man.Checked || rb_kor_Girl.Checked))
            {
                MessageBox.Show("9번 문항을 체크하세요.");
                return;
            }

            if (tb_kor_Age.Text == "")
            {
                MessageBox.Show("10번 문항을 작성하세요.");
                return;
            }

            Form4_Seoul form4_Seoul = new Form4_Seoul();
            this.Close();

            form4_Seoul.Show(); // ShowDialog 쓸지도



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

        // 아래부분은 희망여행지 부분이다. 미구현이여서 선택 못하게 해버림.

        private void rb_kor_Gyeonggi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("선택하실 수 없습니다.");
            rb_kor_Gyeonggi.Checked = false;
            rb_kor_Soul.Checked = true;
        }

        private void rb_kor_Gangwon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("선택하실 수 없습니다.");
            rb_kor_Gangwon.Checked = false;
            rb_kor_Soul.Checked = true;
        }

        private void rb_kor_Daejeon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("선택하실 수 없습니다.");
            rb_kor_Daejeon.Checked = false;
            rb_kor_Soul.Checked = true;
        }

        private void rb_kor_Cheongju_Click(object sender, EventArgs e)
        {
            MessageBox.Show("선택하실 수 없습니다.");
            rb_kor_Cheongju.Checked = false;
            rb_kor_Soul.Checked = true;
        }

        private void rb_kor_Busan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("선택하실 수 없습니다.");
            rb_kor_Busan.Checked = false;
            rb_kor_Soul.Checked = true;
        }

        // 아래부분은 출발지 선택 부분이다. 미구현이여서 선택 못하게 해버림.

        private void rb_kor_start_Soul_Click(object sender, EventArgs e)
        {
            MessageBox.Show("선택하실 수 없습니다.");
            rb_kor_start_Soul.Checked = false;
            rb_kor_start_Cheongju.Checked = true;
        }

        private void rb_kor_start_Gyeonggi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("선택하실 수 없습니다.");
            rb_kor_start_Gyeonggi.Checked = false;
            rb_kor_start_Cheongju.Checked = true;
        }

        private void rb_kor_start_Gangwon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("선택하실 수 없습니다.");
            rb_kor_start_Gangwon.Checked = false;
            rb_kor_start_Cheongju.Checked = true;
        }

        private void rb_kor_start_Busan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("선택하실 수 없습니다.");
            rb_kor_start_Busan.Checked = false;
            rb_kor_start_Cheongju.Checked = true;
        }
    }
}
