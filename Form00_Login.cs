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
    public partial class Form00_Login : Form
    {
        public Form00_Login()
        {
            InitializeComponent();
        }

        static public string ID = "";
        static public string PassWord = "";


        private void btnLogin_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;

            if ((tbID.Text == ID) && (tbPassWord.Text == PassWord))
            {
                progressBar1.Visible = true;
                progressBar1.Enabled = true;

                timer1.Start();
            }
            else
            {
                MessageBox.Show("정보가 일치하지 않습니다");
                return;
            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            Form000_Join form000_join = new Form000_Join();
            //this.Visible = false;

            form000_join.ShowDialog();
        }

        private void tbID_Click(object sender, EventArgs e)
        {
            tbID.Text = "";
        }

        private void tbPassWord_Click(object sender, EventArgs e)
        {
            tbPassWord.Text = "";
            tbPassWord.PasswordChar = '*';
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 2;

            if (progressBar1.Value >= 100)
            {
                timer1.Stop();

                Form0 form0 = new Form0();
                this.Visible = false;

                form0.ShowDialog(); // ShowDialog 쓸지도
            }
        }
    }
}
