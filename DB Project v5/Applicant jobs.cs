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
    public partial class Applicant_jobs : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public Applicant_jobs()
        {
            InitializeComponent();
        }

        private void Applicant_jobs_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            OracleDataAdapter Adapter1 = new OracleDataAdapter("Select * from JJOB", ordb);
            Adapter1.Fill(ds, "job");
            OracleDataAdapter Adapter2 = new OracleDataAdapter("Select * from APPLICANT2", ordb);
            Adapter2.Fill(ds ,"app");
            DataRelation R = new DataRelation("R", ds.Tables[0].Columns["TITLE"], ds.Tables[1].Columns["JOB_TITLE"]);
            ds.Relations.Add(R);

            BindingSource bs_master = new BindingSource(ds, "job");
            BindingSource bs_child = new BindingSource(bs_master, "R");
            dataGridView1.DataSource = bs_child;
            //condition.Text += ds.Tables[0];
            dataGridView2.DataSource = bs_master;
        }
    }
}
