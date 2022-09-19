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
    public partial class GroceryApp : Form
    {
        DataTable dt_checklist = new DataTable();
        DataTable dt_cart = new DataTable();
        public GroceryApp()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // FillCheckList();
        }

        private void FillCheckList()
        {
            dt_checklist.Columns.Add("ItemID", typeof(int));
            dt_checklist.Columns.Add("ItemName");
            dt_checklist.Columns.Add("ItemPrice", typeof(int));

            dt_checklist.Rows.Add(1, "Bread", 10);
            dt_checklist.Rows.Add(2, "Meat", 400);
            dt_checklist.Rows.Add(3, "Rice", 50);
            dt_checklist.Rows.Add(4, "Oats", 190);
            dt_checklist.Rows.Add(5, "Dairy", 70);
            dt_checklist.Rows.Add(6, "Oils", 130);
            dt_checklist.Rows.Add(7, "Drinks", 100);
            dt_checklist.Rows.Add(8, "Seeds", 150);
            dt_checklist.Rows.Add(9, "Veggies", 220);
            dt_checklist.Rows.Add(10, "Whey", 900);
        }

        private void FillCart()
        {
            dt_cart.Columns.Add("ItemID", typeof(int));
            dt_cart.Columns.Add("ItemName");
            dt_cart.Columns.Add("ItemPrice", typeof(int));
        }

        private void GroceryApp_Load(object sender, EventArgs e)
        {
            FillCheckList();
            FillCart();

            listBox1.DataSource = dt_checklist;
            listBox1.DisplayMember = "ItemName";

            listBox2.DataSource = dt_cart;
            listBox2.DisplayMember = "ItemName";
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count>0)
            {
                dt_cart.ImportRow(dt_checklist.Rows[listBox1.SelectedIndex]);
                dt_checklist.Rows[listBox1.SelectedIndex].Delete();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count>0)
            {
                dt_checklist.ImportRow(dt_cart.Rows[listBox2.SelectedIndex]);
                dt_cart.Rows[listBox2.SelectedIndex].Delete();
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count>0)
            {
                int count = dt_checklist.Rows.Count;

                for (int i = 0; i < count; i++)
                {
                    dt_cart.ImportRow(dt_checklist.Rows[listBox1.SelectedIndex]);
                    dt_checklist.Rows[listBox1.SelectedIndex].Delete();
                }
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count>0)
            {
                int count = dt_cart.Rows.Count;

                for (int i = 0; i < count; i++)
                {
                    dt_checklist.ImportRow(dt_cart.Rows[listBox2.SelectedIndex]);
                    dt_cart.Rows[listBox2.SelectedIndex].Delete();
                }

            }
        }

        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Confirm purchase", "Order confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(dr == DialogResult.Yes)
            {
                dataGridView1.DataSource = dt_cart;
                dataGridView1.ReadOnly = true;
            }
        }
    }
}
