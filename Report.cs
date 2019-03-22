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
    public partial class Report : Form
    {
        private DataGridView _dgvProcess;
        private DataGridView dgvextra;
        public Report(decimal avgTime, ListBox lbox, DataGridView datagv, DataGridView dgvextra)
        {
            InitializeComponent();
            this._dgvProcess = datagv;
            this.dgvextra = dgvextra;
            label1.Text = avgTime.ToString();
            addItems();


            foreach (var data in lbox.Items)
            {
                listBox1.Items.Add(data);
            }
            lblTAT.Text = calculateTATtime().ToString();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void addItems() {
            for (int i = 0; i < _dgvProcess.Rows.Count; i++)
            {
                dgvCart.Rows.Add(_dgvProcess.Rows[i].Cells[0].Value.ToString(),
                               _dgvProcess.Rows[i].Cells[1].Value.ToString(),
                            _dgvProcess.Rows[i].Cells[2].Value.ToString());
       
            }
            for (int i = 0; i < dgvextra.Rows.Count; i++)
            {
                dataGridView1.Rows.Add(dgvextra.Rows[i].Cells[0].Value.ToString(),
                              dgvextra.Rows[i].Cells[1].Value.ToString()
                           );

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public int calculateTATtime() {
            int time = 0;
            for (int i = 0; i < dgvextra.Rows.Count; i++)
            {
                time = time + int.Parse(dgvextra.Rows[i].Cells[1].Value.ToString());

            }
            return (time / dgvextra.Rows.Count);
        }
    }
}
