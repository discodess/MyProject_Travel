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
    public partial class Form000_Join : Form
    {
        public Form000_Join()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show("사용가능한 아이디입니다.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Form00_Login form00_login = new Form00_Login();
            //form00_login.Visible = true;

            this.Close(); // ShowDialog 쓸지도
        }

        private void btnDoJoin_Click(object sender, EventArgs e)
        {
            Form00_Login.ID = string.Format(tbID.Text);
            Form00_Login.PassWord = string.Format(tbPassWord.Text);

            MessageBox.Show("회원가입이 완료되었습니다.");

            this.Close();
        }
    }
}
