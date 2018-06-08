using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace DB_Project_v5
{
    public partial class Sign_In_Form : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public Sign_In_Form()
        {
            InitializeComponent();
        }
        private void Sign_In_Form_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
        private void Company_signUP_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select password FROM account1 WHERE password = :password";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("password", PasswordTxt.Text);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                MessageBox.Show("Successful Sign in ");
            }
            else
            {
                MessageBox.Show("you have not  account , Please Sign UP first .");
            }
            dr.Close();
            if (radioApplicant.Checked)
            {
                Applicant_Profile app = new Applicant_Profile();
                app.Show();
                
            }
            else if (radioCompany.Checked)
            {
                Company_Profile obj = new Company_Profile();
                obj.Show();
            }
        }

      
    }
}
