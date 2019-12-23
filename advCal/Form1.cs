using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace advCal
{
    public partial class Form1 : Form
    {
        double n1;
        double n2;
        double result;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(lb_res.Text == "0")
            {
                lb_res.Text = "";
                lb_res.Text = lb_res.Text + btn.Text;
            }
            else
            {
                lb_res.Text = lb_res.Text + btn.Text;
            }

            //if (lb_cal.Text == "0")
            //{
            //    //lb_res.Text = "";
            //}

                if (lb_cal.Text != "")
            {
                //lb_cal.Text = "";
                lb_cal.Text = lb_cal.Text + btn.Text;
            }
            else
            {
                lb_cal.Text = lb_res.Text;
            }
        }

        private void op_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            n1 = double.Parse(lb_res.Text);
            op = btn.Text;
            if(lb_cal.Text != "")
            {
                lb_cal.Text = lb_cal.Text + op;
            }
            else
            {
                lb_cal.Text = lb_res.Text + op;
            }
            
            lb_res.Text = "";

        }

        private void roundedButton7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lb_cal.Text = "";
            lb_res.Text = "";
        }
    }
}
