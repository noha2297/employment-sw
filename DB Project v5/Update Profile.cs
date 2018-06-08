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
    public partial class Update_Profile : Form
    {

        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public Update_Profile()
        {
            InitializeComponent();
        }

        private void Update_Profile_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void Company_signUP_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            //int id = int.Parse(IDtextBox.Text);
            //int ssn = int.Parse(SSNtextBox.Text);
            int phone = int.Parse(PhonetextBox.Text);
            int company_id = int.Parse(CompanyIDtxt.Text);
            Updatecompany(company_id);
            //insertMember(ssn, phone, id);

            UpdateAccount(phone);

        }
        public void Updatecompany(int company_id)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "Update_Company";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("id1", company_id);
            cmd.Parameters.Add("comp_name1", NametextBox.Text);
            cmd.Parameters.Add("comp_name2", lastNametxt.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Company is Updated ");

        }
        public void insertMember(int ssn, int phone, int id)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "insert_Member";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ssn1", ssn);
            cmd.Parameters.Add("phone1", phone);
            cmd.Parameters.Add("mail1", EmailtextBox.Text);
            cmd.Parameters.Add("id1", id);
            cmd.Parameters.Add("name1", NametextBox.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Company member data is added ");
            }
        }
        public void UpdateAccount(int phone)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "Update_ComAccount";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("mail1", EmailtextBox.Text);
            cmd.Parameters.Add("password1", PasswordtextBox.Text);
            cmd.Parameters.Add("name1", NametextBox.Text);
            cmd.Parameters.Add("phone1", phone);
            cmd.Parameters.Add("position1", PositiontextBox.Text);
            cmd.Parameters.Add("Realpassword1", LastPasswordtxt.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Company Account is Updated ");

        }


    }
}
