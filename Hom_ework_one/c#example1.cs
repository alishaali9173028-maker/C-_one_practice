using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeassignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttoshow_Click(object sender, EventArgs e)
        {
            //stage one output
            //creating a variables
            string dayof_theweek, name_of_month, full_date;
            int   numeric_day; 
            int    year ;

                //intial values to variable
                dayof_theweek = textdayofweak.Text;
            name_of_month = textmounth.Text;
            numeric_day =int.parse (textnumeric.Text);
            year =int,parse (textyear.Text);


            //stage 2 =process concatination of full data

            full_date = dayof_theweek + ",   " + name_of_month + " , " + numeric_day + " , " + year;

            //stage 3 = the output using label
            lbloutput.Text = full_date;

        }

        private void bttoclear_Click(object sender, EventArgs e)
        {
            //create textbox and lable
            textdayofweak.Clear();
            textmounth.Clear();
            textnumeric.Clear();
            textyear.Clear();

            //clearning lable
            lbloutput.Text = " ";
        }

        private void bttoclose_Click(object sender, EventArgs e)
        {
            //from close using keyword and close function
            this.Close();
        }
    }
}
