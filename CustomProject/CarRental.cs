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
    public partial class CarRental : Form
    {
        public static string fromDestination, toDestination, fullName, documentName, documentExpiryDate, car;
        public static string fromStartDate, toEndDate;


        DataTable dt_car = new DataTable();

        private void CarsData()
        {
            dt_car.Columns.Add("Car Name");

            dt_car.Rows.Add("Ford Mustang");
            dt_car.Rows.Add("Suziki Baleon");
            dt_car.Rows.Add("Swift Dzire");
            dt_car.Rows.Add("Audi A3");
            dt_car.Rows.Add("BMW 420d");
            dt_car.Rows.Add("Maruti 800");
            dt_car.Rows.Add("Lexus");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            car = dt_car.Rows[comboBox1.SelectedIndex]["Car Name"].ToString();
        }

        public CarRental()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CarRental_Load(object sender, EventArgs e)
        {
            CarsData();

            comboBox1.DataSource = dt_car;
            comboBox1.DisplayMember = "Car Name";

           
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            fromStartDate = monthCalendar1.SelectionStart.ToShortDateString();
            toEndDate = monthCalendar1.SelectionEnd.ToShortDateString();
            fullName = txtFirstName.Text.ToString() + txtLastName.Text.ToString();
            fromDestination = txtFromDest.Text.ToString();
            toDestination = txtToDest.Text.ToString();
            documentName = txtDocumentName.Text.ToString();
            documentExpiryDate = dateTimePicker1.Value.ToString();

            this.Hide();


            CarRentalConfimartionForm cs_form = new CarRentalConfimartionForm();
            cs_form.Show();
        }
    }
}
