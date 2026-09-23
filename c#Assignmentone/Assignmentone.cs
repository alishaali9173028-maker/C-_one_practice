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

namespace Assignmentone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbldepartment_Click(object sender, EventArgs e)
        {

        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void lblstudentId_Click(object sender, EventArgs e)
        {

        }

        private void textsemester_TextChanged(object sender, EventArgs e)
        {

        }

        private void textdepartement_TextChanged(object sender, EventArgs e)
        {

        }

        private void textstudentId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textname_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttoshowinfo_Click(object sender, EventArgs e)
        {
            //creating a variables
            string name, studentId, departemen, semester,full_deta;
            name = textname.Text;
            studentId = textstudentId.Text;
            departemen = textdepartement.Text;
            semester = textsemester.Text;
            
            //process concatination of full data

            full_deta = name + " , " + studentId + " , " + departemen + " , " + semester;
           // the output using label
            lbloutput.Text = full_deta;

        }

        private void bttoexit_Click(object sender, EventArgs e)
        {
            //from close using keyword and close function

            this.Close();
        }

        private void bttoclear_Click(object sender, EventArgs e)
        {
            //clearning lable
            lbloutput.Text=" ";
        }
    }
}
