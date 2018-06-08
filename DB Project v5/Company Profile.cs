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
    public partial class Company_Profile : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        OracleDataAdapter adapter;
        OracleDataAdapter adapter2;
        OracleCommandBuilder builder;
        DataSet ds;
        public Company_Profile()
        {
            InitializeComponent();
        }
        private void Company_Profile_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);

            if (ProfileRadio.Checked)
            {
                Update_Profile obj = new Update_Profile();
                obj.Show();
            }
            if (Appdisplayradio.Checked)
            {

                string sqlStatement = "select name , email , phone_number  from account1 where possition = :pos ";
                adapter = new OracleDataAdapter(sqlStatement, ordb);
                adapter.SelectCommand.Parameters.Add("pos", positiontxt.Text);
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (Update.Checked)
            {
                string sqlStatement = "select * from ADV2";
                adapter2 = new OracleDataAdapter(sqlStatement, ordb);
                ds = new DataSet();
                adapter2.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (Delete.Checked)
            {
                adapter2.Update(ds.Tables[0]);
            }
            
            else if (display.Checked)
            {
                string sqlStatement = "select * from advertisment";
                adapter = new OracleDataAdapter(sqlStatement, ordb);
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                adapter.Update(ds.Tables[0]);
                MessageBox.Show("successful");
            }
        }

        private void display_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
