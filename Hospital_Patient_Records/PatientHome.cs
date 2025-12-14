
using System;
using System.Linq;
using System.Windows.Forms;

namespace Hospital_Patient_Records
{
    public partial class PatientHome : Form
    {
        int patientId;

        public PatientHome(int id)
        {
            InitializeComponent();
            patientId = id;
            LoadData();
        }

        void LoadData()
        {
            var p = Database.Conn.Table<Patient>().First(x => x.Id == patientId);

            lblName.Text = p.FirstName + " " + p.LastName;

            double bmi = p.Weight / Math.Pow(p.Height / 100, 2);
            lblBMI.Text = bmi.ToString("0.00");

            lblCondition.Text =
                bmi < 18.5 ? "Underweight" :
                bmi < 25 ? "Normal" :
                bmi < 30 ? "Overweight" : "Obese";

            // ---------- NEW LOGIC ----------
            lblFittowork.Text = p.FitStatus != null && p.FitStatus.Contains("Fit")
                && !p.FitStatus.Contains("Not")
                ? "Yes"
                : "No";

            lblExcused.Text = p.FitStatus != null && p.FitStatus.Contains("Accepted")
                ? "Yes"
                : "No";

            lblDoctorNotes.Text = string.IsNullOrWhiteSpace(p.DoctorNote)
                ? "None"
                : p.DoctorNote;

            dgvData.DataSource = new[] { p };
        }


        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private DataGridView dgvData;
        private Label lblName;
        private Label lblBMI;
        private Label lblCondition;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Label;
        private Label lblFittowork;
        private Label label5;
        private Label lblDoctorNotes;
        private Label lblExcused;
        private Label label7;

        private void InitializeComponent()
        {
            dgvData = new DataGridView();
            lblName = new Label();
            lblBMI = new Label();
            lblCondition = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Label = new Label();
            lblFittowork = new Label();
            label5 = new Label();
            lblDoctorNotes = new Label();
            lblExcused = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new System.Drawing.Point(308, 76);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new System.Drawing.Size(620, 404);
            dgvData.TabIndex = 0;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblName.Location = new System.Drawing.Point(125, 87);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(63, 25);
            lblName.TabIndex = 1;
            lblName.Text = "label1";
            // 
            // lblBMI
            // 
            lblBMI.AutoSize = true;
            lblBMI.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblBMI.Location = new System.Drawing.Point(125, 130);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new System.Drawing.Size(63, 25);
            lblBMI.TabIndex = 2;
            lblBMI.Text = "label2";
            // 
            // lblCondition
            // 
            lblCondition.AutoSize = true;
            lblCondition.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCondition.Location = new System.Drawing.Point(125, 176);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new System.Drawing.Size(63, 25);
            lblCondition.TabIndex = 3;
            lblCondition.Text = "label3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(8, 124);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 32);
            label1.TabIndex = 4;
            label1.Text = "BMI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(8, 170);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 32);
            label2.TabIndex = 5;
            label2.Text = "Status:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(8, 80);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(83, 32);
            label3.TabIndex = 6;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(497, 31);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(272, 42);
            label4.TabIndex = 7;
            label4.Text = "Your Records";
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Label.Location = new System.Drawing.Point(8, 289);
            Label.Name = "Label";
            Label.Size = new System.Drawing.Size(132, 32);
            Label.TabIndex = 8;
            Label.Text = "Fit to work:";
            // 
            // lblFittowork
            // 
            lblFittowork.AutoSize = true;
            lblFittowork.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblFittowork.Location = new System.Drawing.Point(146, 295);
            lblFittowork.Name = "lblFittowork";
            lblFittowork.Size = new System.Drawing.Size(63, 25);
            lblFittowork.TabIndex = 9;
            lblFittowork.Text = "label3";
            lblFittowork.Click += lblFittowork_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(12, 409);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(161, 32);
            label5.TabIndex = 10;
            label5.Text = "Doctor Notes:";
            // 
            // lblDoctorNotes
            // 
            lblDoctorNotes.AutoSize = true;
            lblDoctorNotes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDoctorNotes.Location = new System.Drawing.Point(49, 457);
            lblDoctorNotes.Name = "lblDoctorNotes";
            lblDoctorNotes.Size = new System.Drawing.Size(63, 25);
            lblDoctorNotes.TabIndex = 11;
            lblDoctorNotes.Text = "label3";
            // 
            // lblExcused
            // 
            lblExcused.AutoSize = true;
            lblExcused.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblExcused.Location = new System.Drawing.Point(150, 351);
            lblExcused.Name = "lblExcused";
            lblExcused.Size = new System.Drawing.Size(63, 25);
            lblExcused.TabIndex = 13;
            lblExcused.Text = "label3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(12, 345);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(104, 32);
            label7.TabIndex = 12;
            label7.Text = "Excused:";
            // 
            // PatientHome
            // 
            ClientSize = new System.Drawing.Size(976, 492);
            Controls.Add(lblExcused);
            Controls.Add(label7);
            Controls.Add(lblDoctorNotes);
            Controls.Add(label5);
            Controls.Add(lblFittowork);
            Controls.Add(Label);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblCondition);
            Controls.Add(lblBMI);
            Controls.Add(lblName);
            Controls.Add(dgvData);
            Name = "PatientHome";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private void lblFittowork_Click(object sender, EventArgs e)
        {

        }
    }
}
