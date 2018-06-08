using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace DB_Project_v5
{
    public partial class Report9 : Form
    {
       CrystalReport8 cr8;
        CrystalReport6 cr6;
        public Report9()
        {
            InitializeComponent();
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            //CrystalReport8 cr8;
            cr8 = new CrystalReport8();
            foreach (ParameterDiscreteValue v8 in cr8.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v8.Value);

          /*  cr6 = new CrystalReport6();
            foreach (ParameterDiscreteValue v6 in cr6.ParameterFields[0].DefaultValues)
                comboBox2.Items.Add(v6.Value);
*/
        }
        private void button3_Click(object sender, EventArgs e)
        {
            cr8.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = cr8;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr6.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = cr6;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
