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
    public partial class Applicant_Registration_Form : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public Applicant_Registration_Form()
        {
            InitializeComponent();
        }
        private void Applicant_Registration_Form_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
        private void Company_signUP_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            int id = int.Parse(IDtextBox.Text);
            int ssn = int.Parse(SSNtextBox.Text);
            int phone = int.Parse(PhonetextBox.Text);

            string sqlStatement;

            sqlStatement = "insert into member1 (b_ssn , contact_number , email , id , name) values (:ssn ,:phone ,:email ,:id , :name) ";
            insertMember(sqlStatement, ssn, phone, id);

            sqlStatement = "insert INTO account1(email , password , name , phone_number , possition , m_ssn ) values (:email , :password , :name , :phone , :position ,:ssn )";
            insertAccount(sqlStatement, phone ,ssn);

            sqlStatement = "insert INTO cv(experience , grade   , p_ssn , password_c ) values (:experience , :grade , :ssn ,:password )";
            insertCV(sqlStatement, ssn);

            sqlStatement = "insert INTO applicant2( g_ssn , l_name, comp_name , job_title) values ( :ssn , :name , :comp_name ,:job_title)";
            insertApplicant(sqlStatement, ssn);

        }
        public void insertApplicant(string sqlStatement, int ssn)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = sqlStatement;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("ssn", ssn);
            cmd.Parameters.Add("name", NametextBox.Text);
            cmd.Parameters.Add("comp_name", Comp_nametxt.Text);
            cmd.Parameters.Add("job_title",job_titletxt.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("applicant is added ");
            }
        }
        public void insertMember(string sqlStatement, int ssn, int phone, int id)
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
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("member is added ");
            }
        }
        public void insertAccount(string sqlStatement, int phone , int ssn)
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
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Account is added ");
            }
        }
        public void insertCV(string sqlStatement, int ssn)
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
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("CV is added ");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
