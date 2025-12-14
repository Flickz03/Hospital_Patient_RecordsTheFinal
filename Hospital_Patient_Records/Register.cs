
using System;
using System.Windows.Forms;

namespace Hospital_Patient_Records
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtRePassword.Text)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            Database.Conn.Insert(new Patient
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                FirstName = txtFirstName.Text,
                MiddleName = txtMiddleName.Text,
                LastName = txtLastName.Text,
                MedicalHistory = txtMedicalHistory.Text,
                Height = (double)numHeight.Value,
                Weight = (double)numWeight.Value,
                Birthday = dtpBirthday.Value.ToShortDateString()
            });

            MessageBox.Show("Account created successfully");
            new Form1().Show();
            this.Hide();
        }

        private void InitializeComponent()
        {
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnSignup = new Button();
            dtpBirthday = new DateTimePicker();
            txtRePassword = new TextBox();
            txtMedicalHistory = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            numHeight = new NumericUpDown();
            numWeight = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWeight).BeginInit();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new System.Drawing.Point(140, 36);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new System.Drawing.Size(490, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new System.Drawing.Point(140, 72);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new System.Drawing.Size(490, 23);
            txtMiddleName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new System.Drawing.Point(140, 113);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new System.Drawing.Size(490, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(140, 253);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(490, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(140, 293);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(490, 23);
            txtPassword.TabIndex = 4;
            // 
            // btnSignup
            // 
            btnSignup.Location = new System.Drawing.Point(258, 486);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new System.Drawing.Size(244, 64);
            btnSignup.TabIndex = 7;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = true;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new System.Drawing.Point(140, 154);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new System.Drawing.Size(490, 23);
            dtpBirthday.TabIndex = 8;
            // 
            // txtRePassword
            // 
            txtRePassword.Location = new System.Drawing.Point(140, 335);
            txtRePassword.Name = "txtRePassword";
            txtRePassword.Size = new System.Drawing.Size(490, 23);
            txtRePassword.TabIndex = 9;
            // 
            // txtMedicalHistory
            // 
            txtMedicalHistory.Location = new System.Drawing.Point(20, 434);
            txtMedicalHistory.Name = "txtMedicalHistory";
            txtMedicalHistory.Size = new System.Drawing.Size(682, 23);
            txtMedicalHistory.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(27, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 15);
            label1.TabIndex = 11;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(27, 80);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(82, 15);
            label2.TabIndex = 12;
            label2.Text = "Middle Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(27, 121);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(66, 15);
            label3.TabIndex = 13;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(27, 261);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(39, 15);
            label4.TabIndex = 14;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(27, 301);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 15);
            label5.TabIndex = 15;
            label5.Text = "Password:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(20, 343);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(108, 15);
            label6.TabIndex = 16;
            label6.Text = "Re-Enter Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(152, 209);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(46, 15);
            label7.TabIndex = 17;
            label7.Text = "Height:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(391, 209);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(48, 15);
            label8.TabIndex = 18;
            label8.Text = "Weight:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(39, 160);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(54, 15);
            label9.TabIndex = 19;
            label9.Text = "Birthday:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(20, 416);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(209, 15);
            label10.TabIndex = 20;
            label10.Text = "Medical Records (Leave Blank If None)";
            // 
            // numHeight
            // 
            numHeight.DecimalPlaces = 2;
            numHeight.Location = new System.Drawing.Point(210, 206);
            numHeight.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numHeight.Name = "numHeight";
            numHeight.Size = new System.Drawing.Size(120, 23);
            numHeight.TabIndex = 21;
            numHeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numWeight
            // 
            numWeight.DecimalPlaces = 2;
            numWeight.Location = new System.Drawing.Point(445, 206);
            numWeight.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numWeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numWeight.Name = "numWeight";
            numWeight.Size = new System.Drawing.Size(120, 23);
            numWeight.TabIndex = 22;
            numWeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Register
            // 
            ClientSize = new System.Drawing.Size(706, 553);
            Controls.Add(numWeight);
            Controls.Add(numHeight);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMedicalHistory);
            Controls.Add(txtRePassword);
            Controls.Add(dtpBirthday);
            Controls.Add(btnSignup);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Name = "Register";
            ((System.ComponentModel.ISupportInitialize)numHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnSignup;
        private DateTimePicker dtpBirthday;
        private TextBox txtRePassword;
        private TextBox txtMedicalHistory;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private NumericUpDown numHeight;
        private NumericUpDown numWeight;
        private Label label10;
    }
}
