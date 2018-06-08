namespace DB_Project_v5
{
    partial class Sign_In_Form
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
            this.radioCompany = new System.Windows.Forms.RadioButton();
            this.radioApplicant = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.Company_signUP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioCompany
            // 
            this.radioCompany.AutoSize = true;
            this.radioCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCompany.Location = new System.Drawing.Point(425, 216);
            this.radioCompany.Name = "radioCompany";
            this.radioCompany.Size = new System.Drawing.Size(100, 22);
            this.radioCompany.TabIndex = 88;
            this.radioCompany.TabStop = true;
            this.radioCompany.Text = "Company";
            this.radioCompany.UseVisualStyleBackColor = true;
            // 
            // radioApplicant
            // 
            this.radioApplicant.AutoSize = true;
            this.radioApplicant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioApplicant.Location = new System.Drawing.Point(425, 156);
            this.radioApplicant.Name = "radioApplicant";
            this.radioApplicant.Size = new System.Drawing.Size(97, 22);
            this.radioApplicant.TabIndex = 87;
            this.radioApplicant.TabStop = true;
            this.radioApplicant.Text = "Applicant\r\n";
            this.radioApplicant.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(363, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 24);
            this.label11.TabIndex = 86;
            this.label11.Text = "Company or Applicant";
            // 
            // Company_signUP
            // 
            this.Company_signUP.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Company_signUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Company_signUP.Location = new System.Drawing.Point(229, 264);
            this.Company_signUP.Name = "Company_signUP";
            this.Company_signUP.Size = new System.Drawing.Size(141, 59);
            this.Company_signUP.TabIndex = 85;
            this.Company_signUP.Text = "Sign_In";
            this.Company_signUP.UseVisualStyleBackColor = false;
            this.Company_signUP.Click += new System.EventHandler(this.Company_signUP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 38);
            this.label4.TabIndex = 84;
            this.label4.Text = "Sign In Form";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 83;
            this.label3.Text = "Password";
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(130, 151);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(124, 22);
            this.emailTxt.TabIndex = 82;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(130, 216);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(124, 22);
            this.PasswordTxt.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 89;
            this.label1.Text = "E-mail";
            // 
            // Sign_In_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioCompany);
            this.Controls.Add(this.radioApplicant);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Company_signUP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.PasswordTxt);
            this.Name = "Sign_In_Form";
            this.Text = "Sign_In_Form";
            this.Load += new System.EventHandler(this.Sign_In_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioCompany;
        private System.Windows.Forms.RadioButton radioApplicant;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Company_signUP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label label1;
    }
}