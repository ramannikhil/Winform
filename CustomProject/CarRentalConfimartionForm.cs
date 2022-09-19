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
    public partial class CarRentalConfimartionForm : Form
    {
        public CarRentalConfimartionForm()
        {
            InitializeComponent();
        }

        private void CarRentalConfimartionForm_Load(object sender, EventArgs e)
        {
            lblFullName.Text = CarRental.fullName;
            lblDocumentName.Text = CarRental.documentName;
            lblDocumentExpiryDate.Text = CarRental.documentExpiryDate;
            lblFromDest.Text = CarRental.fromDestination;
            lblToDest.Text = CarRental.toDestination;
            lblCar.Text = CarRental.car;
            lblFromStartDate.Text = CarRental.fromStartDate;
            lblEndDate.Text = CarRental.toEndDate;
        }

       
    }
}
