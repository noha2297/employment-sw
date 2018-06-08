namespace DB_Project_v5
{
    partial class ALL_Companies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Companies = new System.Windows.Forms.RadioButton();
            this.Applicants = new System.Windows.Forms.RadioButton();
            this.condition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.JobsRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(584, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 43);
            this.button3.TabIndex = 39;
            this.button3.Text = "Display";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 38);
            this.label4.TabIndex = 97;
            this.label4.Text = "Leader Profile";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(93, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(577, 262);
            this.dataGridView1.TabIndex = 99;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Companies
            // 
            this.Companies.AutoSize = true;
            this.Companies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Companies.Location = new System.Drawing.Point(27, 362);
            this.Companies.Name = "Companies";
            this.Companies.Size = new System.Drawing.Size(147, 22);
            this.Companies.TabIndex = 100;
            this.Companies.TabStop = true;
            this.Companies.Text = "ALL Companies";
            this.Companies.UseVisualStyleBackColor = true;
            this.Companies.CheckedChanged += new System.EventHandler(this.Companies_CheckedChanged);
            // 
            // Applicants
            // 
            this.Applicants.AutoSize = true;
            this.Applicants.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Applicants.Location = new System.Drawing.Point(264, 362);
            this.Applicants.Name = "Applicants";
            this.Applicants.Size = new System.Drawing.Size(106, 22);
            this.Applicants.TabIndex = 102;
            this.Applicants.TabStop = true;
            this.Applicants.Text = "Applicants";
            this.Applicants.UseVisualStyleBackColor = true;
            // 
            // condition
            // 
            this.condition.Location = new System.Drawing.Point(330, 402);
            this.condition.Multiline = true;
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(100, 22);
            this.condition.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 104;
            this.label1.Text = "Position";
            // 
            // JobsRadio
            // 
            this.JobsRadio.AutoSize = true;
            this.JobsRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobsRadio.Location = new System.Drawing.Point(476, 362);
            this.JobsRadio.Name = "JobsRadio";
            this.JobsRadio.Size = new System.Drawing.Size(66, 22);
            this.JobsRadio.TabIndex = 106;
            this.JobsRadio.TabStop = true;
            this.JobsRadio.Text = "Jobs";
            this.JobsRadio.UseVisualStyleBackColor = true;
            this.JobsRadio.CheckedChanged += new System.EventHandler(this.JobsRadio_CheckedChanged);
            // 
            // ALL_Companies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 449);
            this.Controls.Add(this.JobsRadio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.condition);
            this.Controls.Add(this.Applicants);
            this.Controls.Add(this.Companies);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Name = "ALL_Companies";
            this.Text = "co";
            this.Load += new System.EventHandler(this.ALL_Companies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton Companies;
        private System.Windows.Forms.RadioButton Applicants;
        private System.Windows.Forms.TextBox condition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton JobsRadio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}