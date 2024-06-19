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
    public partial class Form6_Food : Form
    {
        public Form6_Food()
        {
            InitializeComponent();
        }

        static public string best1 = "0";
        static public string best2 = "0";
        static public string food1 = "0";
        static public string food2 = "0";
        static public string food3 = "0";
        static public string food4 = "0";
        static public string food5 = "0";
        static public string food6 = "0";
        static public string food7 = "0";
        static public string food8 = "0";
        static public string side = "0";
        static public string ade = "0";
        static public string wine = "0";
        static public string result = "0";
        static public string str = "";
        static public int total = 0;


        private void nNDbest1_ValueChanged(object sender, EventArgs e)
        {
            best1 = nNDbest1.Value.ToString();
        }

        private void nNDbest2_ValueChanged(object sender, EventArgs e)
        {
            best2 = nNDbest2.Value.ToString();

        }

        private void nNDFood1_ValueChanged(object sender, EventArgs e)
        {
            food1 = nNDFood1.Value.ToString();
        }

        private void nNDFood2_ValueChanged(object sender, EventArgs e)
        {
            food2 = nNDFood2.Value.ToString();
        }

        private void nNDFood3_ValueChanged(object sender, EventArgs e)
        {
            food3 = nNDFood3.Value.ToString();

        }

        private void nNDFood4_ValueChanged(object sender, EventArgs e)
        {
            food4 = nNDFood4.Value.ToString();
        }

        private void nNDFood5_ValueChanged(object sender, EventArgs e)
        {
            food5 = nNDFood5.Value.ToString();
        }

        private void nNDFood6_ValueChanged(object sender, EventArgs e)
        {
            food6 = nNDFood6.Value.ToString();
        }

        private void nNDFood7_ValueChanged(object sender, EventArgs e)
        {
            food7 = nNDFood7.Value.ToString();
        }

        private void nNDFood8_ValueChanged(object sender, EventArgs e)
        {
            food8 = nNDFood8.Value.ToString();
        }

        private void nNDSide1_ValueChanged(object sender, EventArgs e)
        {
            side = nNDSide1.Value.ToString();
        }

        private void nNDAde_ValueChanged(object sender, EventArgs e)
        {
            ade = nNDAde.Value.ToString();
        }

        private void nNDWine_ValueChanged(object sender, EventArgs e)
        {
            wine = nNDWine.Value.ToString();
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            best1 = "0";
            best2 = "0";
            food1 = "0";
            food2 = "0";
            food3 = "0";
            food4 = "0";
            food5 = "0";
            food6 = "0";
            food7 = "0";
            food8 = "0";
            side = "0";
            ade = "0";
            wine = "0";
            result = "0";
            total = 0;
            str = "";

            lbresult.Text = "";
            lbtotalprice.Text = "";

            nNDbest1.Value = 0;
            nNDbest2.Value = 0;
            nNDFood1.Value = 0;
            nNDFood2.Value = 0;
            nNDFood3.Value = 0;
            nNDFood4.Value = 0;
            nNDFood5.Value = 0;
            nNDFood6.Value = 0;
            nNDFood7.Value = 0;
            nNDFood8.Value = 0;
            nNDSide1.Value = 0;
            nNDAde.Value = 0;
            nNDWine.Value = 0;

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (best1 != "0")
            {
                str += lbbest1.Text + " " + best1 + "개\n";
                total += int.Parse(lbbest1price.Text) * int.Parse(best1);
            }
            if (best2 != "0")
            {
                str += lbbest2.Text + " " + best2 + "개\n";
                total += int.Parse(lbbest2price.Text) * int.Parse(best2);
            }
            if (food1 != "0")
            {
                str += lbfood1.Text + " " + food1 + "개\n";
                total += int.Parse(lbfood1price.Text) * int.Parse(food1);
            }
            if (food2 != "0")
            {
                str += lbfood2.Text + " " + food2 + "개\n";
                total += int.Parse(lbfood2price.Text) * int.Parse(food2);
            }
            if (food3 != "0")
            {
                str += lbfood3.Text + " " + food3 + "개\n";
                total += int.Parse(lbfood3price.Text) * int.Parse(food3);
            }
            if (food4 != "0")
            {
                str += lbfood4.Text + " " + food4 + "개\n";
                total += int.Parse(lbfood4price.Text) * int.Parse(food4);
            }
            if (food5 != "0")
            {
                str += lbfood5.Text + " " + food5 + "개\n";
                total += int.Parse(lbfood5price.Text) * int.Parse(food5);
            }
            if (food6 != "0")
            {
                str += lbfood6.Text + " " + food6 + "개\n";
                total += int.Parse(lbfood6price.Text) * int.Parse(food6);
            }
            if (food7 != "0")
            {
                str += lbfood7.Text + " " + food7 + "개\n";
                total += int.Parse(lbfood7price.Text) * int.Parse(food7);
            }
            if (food8 != "0")
            {
                str += lbfood8.Text + " " + food8 + "개\n";
                total += int.Parse(lbfood8price.Text) * int.Parse(food8);
            }
            if (side != "0")
            {
                str += lbside.Text + " " + side + "개\n";
                total += int.Parse(lbsideprice.Text) * int.Parse(side);
            }
            if (ade != "0")
            {
                str += lbade.Text + " " + ade + "개\n";
                total += int.Parse(lbadeprice.Text) * int.Parse(ade);
            }
            if (wine != "0")
            {
                str += lbwine.Text + " " + wine + "개\n";
                total += int.Parse(lbwineprice.Text) * int.Parse(wine);
            }

            //total = int.Parse(lbbest1price.Text) + int.Parse(lbbest2price.Text) + int.Parse(lbfood1price.Text) + int.Parse(lbfood2price.Text) + int.Parse(lbfood3price.Text) + int.Parse(lbfood4price.Text) + int.Parse(lbfood5price.Text) + int.Parse(lbfood6price.Text) + int.Parse(lbfood7price.Text) + int.Parse(lbfood8price.Text) + int.Parse(lbsideprice.Text) + int.Parse(lbadeprice.Text) + int.Parse(lbwineprice.Text);

            lbresult.Text = str;

            lbtotalprice.Text = "총 가격 " + total;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
