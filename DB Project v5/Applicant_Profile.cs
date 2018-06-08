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
    public partial class Applicant_Profile : Form
    {

        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public Applicant_Profile()
        {
            InitializeComponent();
        }

        private void Applicant_Profile_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (UpdateProfileRadio.Checked)
            {
                update_Applicant_Form obj = new update_Applicant_Form();
                obj.Show();
            }
            else if (CompanyRadio.Checked)
            {
                displayCompanyData();
            }
            else if (AdvertismentRadio.Checked)
            {
                displayAdverisments();
            }
            
        }
        public void displayCompanyData ()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "display_company_data";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("comp_name3", ComNametxt.Text);
            cmd.Parameters.Add("phone3", OracleDbType.Int32, ParameterDirection.Output);
           // cmd.Parameters.Add("mail3", OracleDbType.Varchar2, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            companyPhonetxt.Text = cmd.Parameters["phone3"].Value.ToString();
           // companyMailtxt.Text = cmd.Parameters["mail3"].Value.ToString();
            //MessageBox.Show("Company is added ");

        }
        public void displayAdverisments()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "display_Advertiments";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("field", fieldtxt.Text);
            cmd.Parameters.Add("advs", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                 dataGridView1.Rows.Add(dr[0], dr[1]);
                //dataGridView1.DataSource = dr[0];
                //companyPhonetxt.Text = (dr[0].ToString());
            }
            //MessageBox.Show("Company is added ");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
