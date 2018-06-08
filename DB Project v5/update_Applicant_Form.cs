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
    public partial class update_Applicant_Form : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public update_Applicant_Form()
        {
            InitializeComponent();
        }
        private void update_Applicant_Form_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
        private void ApplicantUpdate_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            int id = int.Parse(IDtextBox.Text);
            int ssn = int.Parse(SSNtextBox.Text);
            int phone = int.Parse(PhonetextBox.Text);
            int pastSSN = int.Parse(RealSSN.Text);

            string sqlStatement;

            sqlStatement = "update member1 set b_ssn=:ssn , contact_number=:phone , email=:email , id=:id , name= :name WHERE b_ssn =:pastSSN";
            UpdateMember(sqlStatement, ssn, phone, id, pastSSN);

            sqlStatement = "update account1 set email=:email , password=:password , name =:name , phone_number =:phone , possition=:position ,m_ssn = :ssn WHERE password = :Realpassword";
            UpdateAccount(sqlStatement, phone ,ssn);

            sqlStatement = "UPDATE cv set experience=:experience , grade=:grade, p_ssn=:ssn ,password_c =: password WHERE p_ssn= :pastSSN";
            updateCV(sqlStatement, ssn, pastSSN);

            sqlStatement = "update applicant2 set g_ssn =:ssn , l_name=:name, comp_name=:comp_name1 , job_title =:job_title1  WHERE g_ssn = :pastSSN";
            UpdateApplicant(sqlStatement, ssn, pastSSN);


        }
        public void UpdateApplicant(string sqlStatement, int ssn, int pastSSN)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = sqlStatement;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("ssn", ssn);
            cmd.Parameters.Add("name", NametextBox.Text);
            cmd.Parameters.Add("comp_name1", Comp_nametxt.Text);
            cmd.Parameters.Add("job_title1", job_titletxt.Text);
            cmd.Parameters.Add("pastSSN", pastSSN);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("applicant is Updated ");
            }
        }
        public void UpdateMember(string sqlStatement, int ssn, int phone, int id, int pastSSN)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = sqlStatement;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("ssn", ssn);
            cmd.Parameters.Add("phone", phone);
            cmd.Parameters.Add("email", EmailtextBox.Text);
            cmd.Parameters.Add("id", id);
            cmd.Parameters.Add("name", NametextBox.Text);
            cmd.Parameters.Add("pastSSN", pastSSN);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("member is Updated ");
            }
        }
        public void UpdateAccount(string sqlStatement, int phone , int ssn)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = sqlStatement;
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("email", EmailtextBox.Text);
            cmd.Parameters.Add("password", PasswordtextBox.Text);
            cmd.Parameters.Add("name", NametextBox.Text);
            cmd.Parameters.Add("phone", phone);
            cmd.Parameters.Add("position", PositiontextBox.Text);
            cmd.Parameters.Add("ssn", ssn);
            cmd.Parameters.Add("Realpassword", RealPassword.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Account is Updated ");
            }
        }
        public void updateCV(string sqlStatement, int ssn, int pastSSN)
        {
            int grade = int.Parse(GradetextBox.Text);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = sqlStatement;
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("experience", ExperiencetextBox.Text);
            cmd.Parameters.Add("grade", grade);
            cmd.Parameters.Add("ssn", ssn);
            cmd.Parameters.Add("password", PasswordtextBox.Text);
            cmd.Parameters.Add("pastSSN", pastSSN);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("CV is Updated ");
            }
        }



    }
}
