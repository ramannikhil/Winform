
namespace CustomProject
{
    partial class DoctorAppointment
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHospitalId = new System.Windows.Forms.Label();
            this.lblHospitalName = new System.Windows.Forms.Label();
            this.lblHospitalRating = new System.Windows.Forms.Label();
            this.lblHospitalContact = new System.Windows.Forms.Label();
            this.lblDoctorContact = new System.Windows.Forms.Label();
            this.lblDoctorSpeciality = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(121, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(760, 164);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(255, 28);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to Doctor Appointment App";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hospital Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(792, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Doctor Name";
            // 
            // lblHospitalId
            // 
            this.lblHospitalId.AutoSize = true;
            this.lblHospitalId.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHospitalId.Location = new System.Drawing.Point(121, 248);
            this.lblHospitalId.Name = "lblHospitalId";
            this.lblHospitalId.Size = new System.Drawing.Size(103, 23);
            this.lblHospitalId.TabIndex = 5;
            this.lblHospitalId.Text = "Hospital Id";
            // 
            // lblHospitalName
            // 
            this.lblHospitalName.AutoSize = true;
            this.lblHospitalName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHospitalName.Location = new System.Drawing.Point(121, 319);
            this.lblHospitalName.Name = "lblHospitalName";
            this.lblHospitalName.Size = new System.Drawing.Size(137, 23);
            this.lblHospitalName.TabIndex = 6;
            this.lblHospitalName.Text = "Hospital Name";
            // 
            // lblHospitalRating
            // 
            this.lblHospitalRating.AutoSize = true;
            this.lblHospitalRating.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHospitalRating.Location = new System.Drawing.Point(121, 391);
            this.lblHospitalRating.Name = "lblHospitalRating";
            this.lblHospitalRating.Size = new System.Drawing.Size(142, 23);
            this.lblHospitalRating.TabIndex = 7;
            this.lblHospitalRating.Text = "Hospital Rating";
            // 
            // lblHospitalContact
            // 
            this.lblHospitalContact.AutoSize = true;
            this.lblHospitalContact.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHospitalContact.Location = new System.Drawing.Point(121, 463);
            this.lblHospitalContact.Name = "lblHospitalContact";
            this.lblHospitalContact.Size = new System.Drawing.Size(193, 23);
            this.lblHospitalContact.TabIndex = 8;
            this.lblHospitalContact.Text = "Hospital Contact Info";
            // 
            // lblDoctorContact
            // 
            this.lblDoctorContact.AutoSize = true;
            this.lblDoctorContact.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorContact.Location = new System.Drawing.Point(755, 391);
            this.lblDoctorContact.Name = "lblDoctorContact";
            this.lblDoctorContact.Size = new System.Drawing.Size(143, 23);
            this.lblDoctorContact.TabIndex = 11;
            this.lblDoctorContact.Text = "Doctor Contact";
            // 
            // lblDoctorSpeciality
            // 
            this.lblDoctorSpeciality.AutoSize = true;
            this.lblDoctorSpeciality.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorSpeciality.Location = new System.Drawing.Point(755, 319);
            this.lblDoctorSpeciality.Name = "lblDoctorSpeciality";
            this.lblDoctorSpeciality.Size = new System.Drawing.Size(159, 23);
            this.lblDoctorSpeciality.TabIndex = 10;
            this.lblDoctorSpeciality.Text = "Doctor Speciality";
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.Location = new System.Drawing.Point(755, 248);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(126, 23);
            this.lblDoctorName.TabIndex = 9;
            this.lblDoctorName.Text = "Doctor Name";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(759, 576);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(199, 51);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // DoctorAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 681);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDoctorContact);
            this.Controls.Add(this.lblDoctorSpeciality);
            this.Controls.Add(this.lblDoctorName);
            this.Controls.Add(this.lblHospitalContact);
            this.Controls.Add(this.lblHospitalRating);
            this.Controls.Add(this.lblHospitalName);
            this.Controls.Add(this.lblHospitalId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "DoctorAppointment";
            this.Text = "DoctorAppointment";
            this.Load += new System.EventHandler(this.DoctorAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHospitalId;
        private System.Windows.Forms.Label lblHospitalName;
        private System.Windows.Forms.Label lblHospitalRating;
        private System.Windows.Forms.Label lblHospitalContact;
        private System.Windows.Forms.Label lblDoctorContact;
        private System.Windows.Forms.Label lblDoctorSpeciality;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.Button btnSubmit;
    }
}