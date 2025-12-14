using System;
using System.Linq;
using System.Windows.Forms;

namespace Hospital_Patient_Records
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cmbRole.Text == "Doctor")
            {
                if (txtEmail.Text == "RoySamanegro" && txtPassword.Text == "SBAPN")
                {
                    new DoctorHome().Show();
                    this.Hide();
                }
                else MessageBox.Show("Invalid doctor credentials");
                return;
            }

            var patient = Database.Conn.Table<Patient>()
                .FirstOrDefault(p => p.Email == txtEmail.Text && p.Password == txtPassword.Text);

            if (patient != null)
            {
                new PatientHome(patient.Id).Show();
                this.Hide();
            }
            else MessageBox.Show("Invalid patient login");
        }

        private void InitializeComponent()
        {
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            cmbRole = new ComboBox();
            btnLogin = new Button();
            btnRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(172, 74);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(293, 23);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(172, 121);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(293, 23);
            txtPassword.TabIndex = 1;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Patient", "Doctor" });
            cmbRole.Location = new System.Drawing.Point(172, 161);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new System.Drawing.Size(293, 23);
            cmbRole.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(187, 201);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(278, 55);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new System.Drawing.Point(240, 273);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(174, 36);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(85, 82);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(85, 129);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 6;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(85, 169);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(33, 15);
            label3.TabIndex = 7;
            label3.Text = "Role:";
            // 
            // Form1
            // 
            ClientSize = new System.Drawing.Size(572, 351);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(cmbRole);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
        }


        internal TextBox txtEmail;
        internal TextBox txtPassword;
        private ComboBox cmbRole;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnRegister;

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
