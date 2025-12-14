
using System;
using System.Linq;
using System.Windows.Forms;

namespace Hospital_Patient_Records
{
    public partial class DoctorHome : Form
    {
        public DoctorHome()
        {
            InitializeComponent();
            LoadPatients();
        }

        void LoadPatients()
        {
            dgvPatients.DataSource = Database.Conn.Table<Patient>().ToList();
        }

        private void InitializeComponent()
        {
            dgvPatients = new DataGridView();
            txtNote = new TextBox();
            btnSave = new Button();
            rbFit = new RadioButton();
            rbNotFit = new RadioButton();
            rbAccept = new RadioButton();
            rbRefuse = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            SuspendLayout();
            // 
            // dgvPatients
            // 
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Location = new System.Drawing.Point(74, 106);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.RowTemplate.Height = 25;
            dgvPatients.Size = new System.Drawing.Size(487, 256);
            dgvPatients.TabIndex = 0;
            // 
            // txtNote
            // 
            txtNote.Location = new System.Drawing.Point(55, 473);
            txtNote.Name = "txtNote";
            txtNote.Size = new System.Drawing.Size(552, 23);
            txtNote.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(55, 517);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(111, 33);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // rbFit
            // 
            rbFit.AutoSize = true;
            rbFit.Location = new System.Drawing.Point(141, 377);
            rbFit.Name = "rbFit";
            rbFit.Size = new System.Drawing.Size(38, 19);
            rbFit.TabIndex = 3;
            rbFit.TabStop = true;
            rbFit.Text = "Fit";
            rbFit.UseVisualStyleBackColor = true;
            // 
            // rbNotFit
            // 
            rbNotFit.AutoSize = true;
            rbNotFit.Location = new System.Drawing.Point(446, 377);
            rbNotFit.Name = "rbNotFit";
            rbNotFit.Size = new System.Drawing.Size(61, 19);
            rbNotFit.TabIndex = 4;
            rbNotFit.TabStop = true;
            rbNotFit.Text = "Not Fit";
            rbNotFit.UseVisualStyleBackColor = true;
            // 
            // rbAccept
            // 
            rbAccept.AutoSize = true;
            rbAccept.Location = new System.Drawing.Point(141, 418);
            rbAccept.Name = "rbAccept";
            rbAccept.Size = new System.Drawing.Size(62, 19);
            rbAccept.TabIndex = 5;
            rbAccept.TabStop = true;
            rbAccept.Text = "Accept";
            rbAccept.UseVisualStyleBackColor = true;
            // 
            // rbRefuse
            // 
            rbRefuse.AutoSize = true;
            rbRefuse.Location = new System.Drawing.Point(446, 418);
            rbRefuse.Name = "rbRefuse";
            rbRefuse.Size = new System.Drawing.Size(60, 19);
            rbRefuse.TabIndex = 6;
            rbRefuse.TabStop = true;
            rbRefuse.Text = "Refuse";
            rbRefuse.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(171, 61);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(325, 42);
            label1.TabIndex = 7;
            label1.Text = "Patient Records";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(55, 455);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(144, 15);
            label2.TabIndex = 8;
            label2.Text = "Note to Patient (Optional)";
            label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DoctorHome
            // 
            ClientSize = new System.Drawing.Size(629, 562);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rbRefuse);
            Controls.Add(rbAccept);
            Controls.Add(rbNotFit);
            Controls.Add(rbFit);
            Controls.Add(btnSave);
            Controls.Add(txtNote);
            Controls.Add(dgvPatients);
            Name = "DoctorHome";
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 0) return;

            var patient = dgvPatients.SelectedRows[0].DataBoundItem as Patient;

            patient.DoctorNote = txtNote.Text;
            patient.FitStatus =
                rbFit.Checked ? "Fit to Work" :
                rbNotFit.Checked ? "Not Fit to Work" :
                rbAccept.Checked ? "Accepted" : "Refused";

            Database.Conn.Update(patient);
            MessageBox.Show("Updated");
        }
        private DataGridView dgvPatients;
        private TextBox txtNote;
        private RadioButton rbFit;
        private RadioButton rbNotFit;
        private RadioButton rbAccept;
        private RadioButton rbRefuse;
        private Label label1;
        private Label label2;
        private Button btnSave;
    }
}
