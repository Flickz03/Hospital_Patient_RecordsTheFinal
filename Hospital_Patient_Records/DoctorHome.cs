
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.MultiSelect = false;

            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPatients
            // 
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Location = new System.Drawing.Point(74, 106);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.RowTemplate.Height = 25;
            dgvPatients.Size = new System.Drawing.Size(777, 256);
            dgvPatients.TabIndex = 0;
            dgvPatients.CellContentClick += dgvPatients_CellContentClick;
            // 
            // txtNote
            // 
            txtNote.Location = new System.Drawing.Point(74, 473);
            txtNote.Name = "txtNote";
            txtNote.Size = new System.Drawing.Size(777, 23);
            txtNote.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(74, 516);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(144, 45);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;   // ✅ REQUIRED
            // 
            // rbFit
            // 
            rbFit.AutoSize = true;
            rbFit.Location = new System.Drawing.Point(6, 22);
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
            rbNotFit.Location = new System.Drawing.Point(122, 22);
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
            rbAccept.Location = new System.Drawing.Point(6, 22);
            rbAccept.Name = "rbAccept";
            rbAccept.Size = new System.Drawing.Size(62, 19);
            rbAccept.TabIndex = 5;
            rbAccept.TabStop = true;
            rbAccept.Text = "Accept";
            rbAccept.UseVisualStyleBackColor = true;
            rbAccept.CheckedChanged += rbAccept_CheckedChanged;
            // 
            // rbRefuse
            // 
            rbRefuse.AutoSize = true;
            rbRefuse.Location = new System.Drawing.Point(134, 22);
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
            label1.Location = new System.Drawing.Point(320, 52);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(325, 42);
            label1.TabIndex = 7;
            label1.Text = "Patient Records";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(74, 455);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(144, 15);
            label2.TabIndex = 8;
            label2.Text = "Note to Patient (Optional)";
            label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbFit);
            groupBox1.Controls.Add(rbNotFit);
            groupBox1.Location = new System.Drawing.Point(531, 381);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(194, 49);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbRefuse);
            groupBox2.Controls.Add(rbAccept);
            groupBox2.Location = new System.Drawing.Point(212, 379);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(200, 51);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // DoctorHome
            // 
            ClientSize = new System.Drawing.Size(916, 573);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtNote);
            Controls.Add(dgvPatients);
            Name = "DoctorHome";
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a patient first");
                return;
            }

            var patient = dgvPatients.SelectedRows[0].DataBoundItem as Patient;

            if (patient == null) return;

            // Save Fit / Not Fit
            if (rbFit.Checked)
                patient.FitStatus = "Fit";
            else if (rbNotFit.Checked)
                patient.FitStatus = "Not Fit";

            // Save Accept / Refuse (append meaning)
            if (rbAccept.Checked)
                patient.FitStatus += "|Accepted";
            else if (rbRefuse.Checked)
                patient.FitStatus += "|Refused";

            patient.DoctorNote = txtNote.Text;

            Database.Conn.Update(patient);
            MessageBox.Show("Updated");
        }

        

        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private DataGridView dgvPatients;
        private TextBox txtNote;
        private RadioButton rbFit;
        private RadioButton rbNotFit;
        private RadioButton rbAccept;
        private RadioButton rbRefuse;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnSave;

        private void rbAccept_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
