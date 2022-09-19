
namespace CustomProject
{
    partial class ApplicationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.rdGrocery = new System.Windows.Forms.RadioButton();
            this.rdCarRental = new System.Windows.Forms.RadioButton();
            this.rdDoctorAppointment = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Neu App";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(838, 46);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(178, 40);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // rdGrocery
            // 
            this.rdGrocery.AutoSize = true;
            this.rdGrocery.Location = new System.Drawing.Point(124, 240);
            this.rdGrocery.Name = "rdGrocery";
            this.rdGrocery.Size = new System.Drawing.Size(136, 24);
            this.rdGrocery.TabIndex = 3;
            this.rdGrocery.TabStop = true;
            this.rdGrocery.Text = "Groceries App";
            this.rdGrocery.UseVisualStyleBackColor = true;
            // 
            // rdCarRental
            // 
            this.rdCarRental.AutoSize = true;
            this.rdCarRental.Location = new System.Drawing.Point(124, 315);
            this.rdCarRental.Name = "rdCarRental";
            this.rdCarRental.Size = new System.Drawing.Size(110, 24);
            this.rdCarRental.TabIndex = 4;
            this.rdCarRental.TabStop = true;
            this.rdCarRental.Text = "Car Rental";
            this.rdCarRental.UseVisualStyleBackColor = true;
            this.rdCarRental.CheckedChanged += new System.EventHandler(this.rdCarRental_CheckedChanged);
            // 
            // rdDoctorAppointment
            // 
            this.rdDoctorAppointment.AutoSize = true;
            this.rdDoctorAppointment.Location = new System.Drawing.Point(124, 390);
            this.rdDoctorAppointment.Name = "rdDoctorAppointment";
            this.rdDoctorAppointment.Size = new System.Drawing.Size(177, 24);
            this.rdDoctorAppointment.TabIndex = 5;
            this.rdDoctorAppointment.TabStop = true;
            this.rdDoctorAppointment.Text = "Doctor Appointment";
            this.rdDoctorAppointment.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose from Below options";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(170, 483);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(131, 40);
            this.btnGo.TabIndex = 7;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 593);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdDoctorAppointment);
            this.Controls.Add(this.rdCarRental);
            this.Controls.Add(this.rdGrocery);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.label1);
            this.Name = "ApplicationForm";
            this.Text = "Application Form";
            this.Load += new System.EventHandler(this.AppInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.RadioButton rdGrocery;
        private System.Windows.Forms.RadioButton rdCarRental;
        private System.Windows.Forms.RadioButton rdDoctorAppointment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGo;
    }
}