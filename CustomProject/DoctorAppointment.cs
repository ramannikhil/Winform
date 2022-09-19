using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomProject
{
    public partial class DoctorAppointment : Form
    {
        string hospital_Name, doctor_Name;

        DataTable dt_Hospital = new DataTable();
        DataTable dt_Doctor = new DataTable();
        DataTable dt_Specific_Hospital_doctor = new DataTable();

        public DoctorAppointment()
        {
            InitializeComponent();
        }

        private void HospitalsData()
        {
            dt_Hospital.Columns.Add("HospitalId");
            dt_Hospital.Columns.Add("Hospital Name");
            dt_Hospital.Columns.Add("Hospital Contact");
            dt_Hospital.Columns.Add("Hospital Rating", typeof(decimal));

            dt_Hospital.Rows.Add(101, "KIMS", "87923333", 4.5);
            dt_Hospital.Rows.Add(102, "Yasodha", "12332899", 4.1);
            dt_Hospital.Rows.Add(103, "Reddys", "46388388", 3.7);
            dt_Hospital.Rows.Add(104, "Apollo", "29288299", 4.8);
        }

        private void DoctorData()
        {
            dt_Doctor.Columns.Add("HospitalId");
            dt_Doctor.Columns.Add("Doctor Name");
            dt_Doctor.Columns.Add("Contact Info");
            dt_Doctor.Columns.Add("Speciality");

            dt_Doctor.Rows.Add(101, "Dr A", "1234", "Heart");
            dt_Doctor.Rows.Add(101, "Dr B", "1234", "Kidney");
            dt_Doctor.Rows.Add(101, "Dr C", "1234", "Brain");

            dt_Doctor.Rows.Add(102, "Dr D", "1234", "Dental");
            dt_Doctor.Rows.Add(102, "Dr E", "1234", "Lung");

            dt_Doctor.Rows.Add(103, "Dr F", "1234", "Surgeon");
            dt_Doctor.Rows.Add(103, "Dr G", "1234", "Heart");

            dt_Doctor.Rows.Add(104, "Dr H", "1234", "Dermitology");
            dt_Doctor.Rows.Add(104, "Dr I", "1234", "Skin");

        }

        private void DoctorAppointment_Load(object sender, EventArgs e)
        {
            HospitalsData();
            DoctorData();

            comboBox1.DataSource = dt_Hospital;
            comboBox1.DisplayMember = "Hospital Name";        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblHospitalId.Text = dt_Hospital.Rows[comboBox1.SelectedIndex]["HospitalId"].ToString();
            lblHospitalName.Text = dt_Hospital.Rows[comboBox1.SelectedIndex]["Hospital Name"].ToString();
            lblHospitalContact.Text = dt_Hospital.Rows[comboBox1.SelectedIndex]["Hospital Contact"].ToString();
            lblHospitalRating.Text = dt_Hospital.Rows[comboBox1.SelectedIndex]["Hospital Rating"].ToString();

            dt_Specific_Hospital_doctor = dt_Doctor.Select("HospitalId = " + dt_Hospital.Rows[comboBox1.SelectedIndex]["HospitalId"]).CopyToDataTable();

            comboBox2.DataSource = dt_Specific_Hospital_doctor;
            comboBox2.DisplayMember = "Doctor Name";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDoctorName.Text = dt_Specific_Hospital_doctor.Rows[comboBox2.SelectedIndex]["Doctor Name"].ToString();
            lblDoctorContact.Text = dt_Specific_Hospital_doctor.Rows[comboBox2.SelectedIndex]["Contact Info"].ToString();
            lblDoctorSpeciality.Text = dt_Specific_Hospital_doctor.Rows[comboBox2.SelectedIndex]["Speciality"].ToString();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            hospital_Name = lblHospitalName.Text;
            doctor_Name = lblDoctorName.Text;

            MessageBox.Show($"Booking Successfull.\n Doctor Name : {doctor_Name} \n Hospital Name:  {hospital_Name}", "Booking Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
