
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

            dgvData.DataSource = new[] { p };
        }
        private DataGridView dgvData;
        private Label lblName;
        private Label lblBMI;
        private Label lblCondition;

        private void InitializeComponent()
        {
            dgvData = new DataGridView();
            lblName = new Label();
            lblBMI = new Label();
            lblCondition = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new System.Drawing.Point(336, 23);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new System.Drawing.Size(295, 275);
            dgvData.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(132, 58);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(38, 15);
            lblName.TabIndex = 1;
            lblName.Text = "label1";
            // 
            // lblBMI
            // 
            lblBMI.AutoSize = true;
            lblBMI.Location = new System.Drawing.Point(132, 104);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new System.Drawing.Size(38, 15);
            lblBMI.TabIndex = 2;
            lblBMI.Text = "label2";
            // 
            // lblCondition
            // 
            lblCondition.AutoSize = true;
            lblCondition.Location = new System.Drawing.Point(132, 148);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new System.Drawing.Size(38, 15);
            lblCondition.TabIndex = 3;
            lblCondition.Text = "label3";
            // 
            // PatientHome
            // 
            ClientSize = new System.Drawing.Size(643, 363);
            Controls.Add(lblCondition);
            Controls.Add(lblBMI);
            Controls.Add(lblName);
            Controls.Add(dgvData);
            Name = "PatientHome";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
    }
}
