using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject_Travel
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            Form6_Food form6_Food = new Form6_Food();
            int a = Form6_Food.total;
            label2.Text = a.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            
            MessageBox.Show("결제완료되었습니다.");
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
