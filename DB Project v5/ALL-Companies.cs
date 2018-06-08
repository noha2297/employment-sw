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
    public partial class ALL_Companies : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public ALL_Companies()
        {
            InitializeComponent();
        }
        private void ALL_Companies_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string sqlcommand ="";
            if (Companies.Checked)
            {
                sqlcommand = "select * from company";
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlcommand;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                while (dr.Read())
                {
                    //dt.Rows.Add(dr[0], dr[1]);
                    dataGridView1.Rows.Add(dr[0], dr[1]);
                }
                dr.Close();
            }
            else if (Applicants.Checked)
            {
                string pos = condition.Text;
                sqlcommand = "select * from account1 where possition = :pos ";
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlcommand;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("pos", pos);
                OracleDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                while (dr.Read())
                {
                    //dt.Rows.Add(dr[0], dr[1]);
                    dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
                }
                dr.Close();
            }
            else if (JobsRadio.Checked)
            {
                Applicant_jobs obj = new Applicant_jobs();
                obj.Show();
            }




        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void JobsRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Companies_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
