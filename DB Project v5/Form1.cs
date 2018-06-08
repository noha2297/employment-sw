using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DB_Project_v5
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

        

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Applicant_Registration_Form app = new Applicant_Registration_Form();
            app.Show();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sign_In_Form sign = new Sign_In_Form();
            sign.Show();
        }

        private void deleteApplicantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_Applicant appdel = new Delete_Applicant();
            appdel.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ALL_Companies obj = new ALL_Companies();
            obj.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports rt = new Reports();
            rt.Show();
        }

        private void signUpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Company_Registeration_Form obj = new Company_Registeration_Form();
            obj.Show();
        }

        private void logInToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sign_In_Form obj = new Sign_In_Form();
            obj.Show();
        }

        private void deleteCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_Applicant del = new Delete_Applicant();
            del.Show();
        }

        private void report9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report9 r = new Report9();
            r.Show();
        }
    }
}
