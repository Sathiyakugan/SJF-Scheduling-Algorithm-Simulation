using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class frmProcessDeatails : Form
    {
        public frmProcessDeatails()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtProcessNumber_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(txtProcessNumber.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Please enter only numbers.");
            //    txtProcessNumber.Text = txtProcessNumber.Text.Remove(txtProcessNumber.Text.Length - 1);
            //}
        }

       

        private void txtArrivalTime_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtArrivalTime.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtArrivalTime.Text = txtArrivalTime.Text.Remove(txtArrivalTime.Text.Length - 1);
            }
        }

        private void txtExecutionTime_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtExecutionTime.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtExecutionTime.Text = txtExecutionTime.Text.Remove(txtExecutionTime.Text.Length - 1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        


        private void btnAdd_Click(object sender, EventArgs e)
        {
            addItems();
        }
        private void addItems()
        {
            try
            {
               
                    if (!(string.IsNullOrWhiteSpace(txtProcessNumber.Text)) && !(string.IsNullOrWhiteSpace(txtArrivalTime.Text)) &&
                        !(string.IsNullOrWhiteSpace(txtExecutionTime.Text)))
                    {
                        if (int.Parse(txtArrivalTime.Text.Trim()) < 10 && int.Parse(txtExecutionTime.Text.Trim()) < 10)
                        {
                            dgvCart.Rows.Add(txtProcessNumber.Text.Trim(), txtArrivalTime.Text.Trim(), txtExecutionTime.Text.Trim());
                            txtProcessNumber.Clear();
                            txtArrivalTime.Clear();
                            txtExecutionTime.Clear();
                            txtProcessNumber.Focus();
                        }
                        else
                        {
                            MessageBox.Show(@"Please Enter process execution time or arrival time less than 9 s", @"Long Time Interval", MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation);
                        }
                }
                
                    else
                    {
                    MessageBox.Show(@"Please Enter process name or execution time or arrival time", @"Empty Detail", MessageBoxButtons.OK,
MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count > 0)
            {
                //dgvCart.Columns[2].SortMode = DataGridViewColumnSortMode.Automatic;
                dgvCart.Columns[0].DisplayIndex = 0;
                dgvCart.Columns[1].DisplayIndex = 1;
                dgvCart.Columns[2].DisplayIndex = 2;
                dgvCart.Sort(dgvCart.Columns[2], ListSortDirection.Ascending);
                Simulation Simultion = new Simulation(dgvCart);
                this.Hide();
                Simultion.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show(@"Please insert some process to simulate", @"Empty");
            }
        }

        private void dgvCart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow row in dgvCart.SelectedRows)
                {
                    dgvCart.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void txtExecutionTime_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    addItems();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

      
       
    }
}
