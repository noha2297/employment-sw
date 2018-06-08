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
    public partial class Delete_Applicant : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public Delete_Applicant()
        {
            InitializeComponent();
        }

        private void Delete_Applicant_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void Company_signUP_Click(object sender, EventArgs e)
        {
            if (radioApplicant.Checked)
            {
                int ssn = int.Parse(SSNTxt.Text);
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                string sqlStatement;

                sqlStatement = "delete from cv where p_ssn = :ssn";
                DeleteCV(sqlStatement, ssn);

                sqlStatement = "delete from applicant2 where g_ssn = :ssn";
                DeleteApplicant(sqlStatement, ssn);

                sqlStatement = "delete from account1 where password = :password";
                DeleteAccount(sqlStatement);

                sqlStatement = "delete from member1 where b_ssn = :ssn ";
                DeleteMember(sqlStatement, ssn);
            }
            else if (radioCompany.Checked)
            {
                DeleteCompAccount();
                DeleteCompany();
            }
            


        }
        public void DeleteApplicant(string sqlStatement, int ssn)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = sqlStatement;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("ssn", ssn);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("applicant is Deleted ");
            }
        }
        public void DeleteMember(string sqlStatement, int ssn)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = sqlStatement;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("ssn", ssn);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("member is Deleted ");
            }
        }
        public void DeleteAccount(string sqlStatement)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = sqlStatement;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("password", PasswordTxt.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Account is Deleted ");
            }
        }
        public void DeleteCV(string sqlStatement, int ssn)
        {

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = sqlStatement;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("ssn", ssn);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("CV is Deleted ");
            }
        }

        public void DeleteCompAccount()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "delete_Account";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("password1", PasswordTxt.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Account is Deleted ");
            
        }
        public void DeleteCompany()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "delete_Company";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("comp_name1", CompNametxt.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Company is Deleted ");
            
        }



    }
}
