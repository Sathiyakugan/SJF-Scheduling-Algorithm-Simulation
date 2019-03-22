using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace WindowsFormsApplication4
{
    public partial class Simulation : Form
    {
        private readonly DataGridView _dgvProcess;          //To Hold The details comng from Get Details 
        private readonly DataGridView _dgvProcesscopy;      //To copy dgv Process
        private decimal _runningTime = 0;                   //To hold the Current Running Time
        private List<int> dgvId;                            //List To Hold the dgv ID
        private readonly List<decimal> _waitingTimes;
        private readonly decimal _totalProcess;
        private  decimal _usedProcess=0;
        private bool _arrivalcheck = true;
        private Boolean _activeProcessing = false;
        private decimal _currentProcessTime = 0;
        private decimal _processStartedTime = 0;
        private decimal _avgTime = 0;
        private Report ReportForm;
        private int _selectedProcessId = 0;
        private int tet = 0;
        private int runningt = 0;
        private int labelxcordinate = 48;
        
        Label[] progressLabel = new Label[10];
        Label[] timeLabels = new Label[10];
        Label[] timeLabelf = new Label[10];
        private int processcounter = 0;
        private int processcountertime=0;
        //private DataGridView dgvextra;

        //Defined Constructor
        public Simulation(DataGridView data)
        {
            InitializeComponent();
            //this.Height = 639;
            //this.Width = 621;
            _dgvProcess = data;
           _dgvProcesscopy = CopyDataGridView(data);
            _runningTime = 0;
            dgvId = new List<int>();
            _waitingTimes = new List<decimal>();
            _totalProcess = _dgvProcess.Rows.Count;
          
        }

        //When the form Loads First
        private void Simulation_Load(object sender, EventArgs e)
        {
            dgvProcessStack.ColumnHeadersDefaultCellStyle.BackColor = Color.NavajoWhite;
            dgvProcessStack.EnableHeadersVisualStyles = false;
            addtimelabelss();
            addtimelabelfs();
            addProgresslabels();
            dgvextra.Visible = false;
            ProcessingEnd();
            trackBar1.Value = 10;
            lblStatus.Text = @"Status : Waiting";
            lblProcess.Text = "";
        }


        //Method to Copy the data and return new DataGridview Copy
        private DataGridView CopyDataGridView(DataGridView dgv_org)
        {
            DataGridView dgv_copy = new DataGridView();
            try
            {
                if (dgv_copy.Columns.Count == 0)
                {
                    foreach (DataGridViewColumn dgvc in dgv_org.Columns)
                    {
                        dgv_copy.Columns.Add(dgvc.Clone() as DataGridViewColumn);
                    }
                }

                DataGridViewRow row = new DataGridViewRow();

                for (int i = 0; i < dgv_org.Rows.Count; i++)
                {
                    row = (DataGridViewRow)dgv_org.Rows[i].Clone();
                    int intColIndex = 0;
                    foreach (DataGridViewCell cell in dgv_org.Rows[i].Cells)
                    {
                        row.Cells[intColIndex].Value = cell.Value;
                        intColIndex++;
                    }
                    dgv_copy.Rows.Add(row);
                }
                dgv_copy.AllowUserToAddRows = false;
                dgv_copy.Refresh();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dgv_copy;
        }


        private void button1_Click(object sender, EventArgs e)
        {   //Check whether there are any process to simmulate
            
            if (_dgvProcess.Rows.Count > 0)
            {
                //Arranging initial Parameters
                StartNewAttempt();
                //Stop pressing the Start Button
                btnStart.Enabled = false;
                //Enabling Report Button
                btnReport.Enabled = true;
                //Enable timer to start The process

                //before starting the process assigning the time to start time
                int min = int.Parse(_dgvProcess.Rows[0].Cells[2].Value.ToString());
                _runningTime = min + _runningTime;
        
                timer1.Enabled = true;
            }
            else
            {
                MessageBox.Show(@"Please insert some process to simulate", @"Empty");
            }
        }


        private void StartNewAttempt()
        {
            _runningTime = 0;                       //Set Running time =0
            dgvId.Clear();                          //Set Datagrid clear list
            _waitingTimes.Clear();                  //Clear waiting list
            _selectedProcessId = 0;                 //Set selected process id =0
            _arrivalcheck = true;                  //Set process is arrived
            _activeProcessing = false;
            _currentProcessTime = 0;               //aT sTART Curent processing time =0
            _processStartedTime = 0;               // Process was started 
            _avgTime = 0;
            lstCommandline.Items.Clear();                 //Clear list box items
        }


        private void timer1_Tick(object sender, EventArgs e)
        {   
            //If threr is no process at the time but still process to come

            //Check data ggrid view column length is greeater to process id
            if (_dgvProcess.Rows.Count >= _selectedProcessId)
            {
                    //if (_runningTime > _processStartedTime + _currentProcessTime)
                    //{
                        if (_usedProcess == _dgvProcess.Rows.Count)
                        {
                            timer1.Enabled = false;
                            ProcessingEnd();
                            CalculateAvgTime();
                            //btnStart.Enabled = true;
                            return;
                        //}
                    }
            }
            
            if (lblRemTime.Visible == true)
            {
                lblRemTime.Text = @"Rem.Time : " +
(_currentProcessTime - (_runningTime - _processStartedTime))
+ @" s";
            } // To get the Remaining time and print it to the Remaining time label 6 - Remainig time

            for (int i = _selectedProcessId; i < _dgvProcess.Rows.Count; i++)  // Iterate through the  number of process( Rows)
            {
                //arriving a process
                if (_arrivalcheck == true)
                {
                    lstCommandline.Items.Add("CHK => Arrival of Process ...");
                    _arrivalcheck = false;
                }

                //check arrival time of the process < running time
                //running time == actual time so
                //actual time should be reater or equal to execute the current process
                //If wil only execute if the process is available on the current time.
                // inside if loop it will add to the stack (dgv)


                if (int.Parse(_dgvProcess.Rows[i].Cells[2].Value.ToString()) <= _runningTime)
                {
                    //Ading to process name data grid view It's like stack 

                    dgvProcessStack.Rows.Add(_dgvProcess.Rows[i].Cells[0].Value.ToString(),
                        _dgvProcess.Rows[i].Cells[1].Value.ToString(),
                        _dgvProcess.Rows[i].Cells[2].Value.ToString());
                    _dgvProcesscopy.Rows.RemoveAt(0);
                    int no=_dgvProcess.Rows.Count;
                    int no1= _dgvProcesscopy.Rows.Count;
                    // Adding list box Process Arrived time  + name
                    
                    lstCommandline.Items.Add("ARR => Process arrived  to Process Stack (Name : " + _dgvProcess.Rows[i].Cells[0].Value.ToString() + ") Arrival Time :" + _runningTime);
                    lstCommandline.Items.Add("\t (Exe.Time : " + _dgvProcess.Rows[i].Cells[1].Value.ToString() + " s,  Arrival Time : " + _dgvProcess.Rows[i].Cells[2].Value.ToString() + " s)");

                    _arrivalcheck = true;

                    // _dgvProcess.Rows.RemoveAt(i);
                    //we don't need o remove the process
                    // just increase the selected Process Id 
                    //If will only execute if the process is added to stack so 
                    //the process already added will not executed
                    _selectedProcessId += 1;
                }
                else {
                    if (_dgvProcesscopy.Rows.Count>0) {

                        //for (i = int.Parse(_dgvProcesscopy.Rows[0].Cells[2].Value.ToString());i>=0;i--) {
                        //    _runningTime += 1;
                        //}
                        if (dgvProcessStack.Rows.Count == 0)
                        {
                            while ((int.Parse(_dgvProcesscopy.Rows[0].Cells[2].Value.ToString()) != _runningTime))
                            {
                                _runningTime += 1;
                            }
                        
                        //Ading to process name data grid view It's like stack 

                        dgvProcessStack.Rows.Add(_dgvProcess.Rows[i].Cells[0].Value.ToString(),
                            _dgvProcess.Rows[i].Cells[1].Value.ToString(),
                            _dgvProcess.Rows[i].Cells[2].Value.ToString());
                        _dgvProcesscopy.Rows.RemoveAt(0);
                        // Adding list box Process Arrived time  + name
                       
                        lstCommandline.Items.Add("ARR => Process arrived  to Process Stack (Name : " + _dgvProcess.Rows[i].Cells[0].Value.ToString() + ") Arrival Time :" + _runningTime);
                        lstCommandline.Items.Add("\t (Exe.Time : " + _dgvProcess.Rows[i].Cells[1].Value.ToString() + " s,  Arrival Time : " + _dgvProcess.Rows[i].Cells[2].Value.ToString() + " s)");

                        _arrivalcheck = true;
                        _selectedProcessId += 1;
                        }

                    }


                }
            }

            //label 1 is current time so setting the current time
            label1.Text = _runningTime.ToString();
            if (dgvProcessStack.Rows.Count > 0)
            {
                
                // Starting the processs
                startProcess();
                
            }

            // If the process Execution is over running time will be increased by 1
  
            _runningTime += 1;
            
        }


        private void startProcess()
        {
            try
            {
                //Check any process is not alive
                if (_activeProcessing == false)
                {

                    //Setting the order
                    dgvProcessStack.Columns[0].DisplayIndex = 0;
                    dgvProcessStack.Columns[1].DisplayIndex = 1;
                    dgvProcessStack.Columns[2].DisplayIndex = 2;
                    //Sort according to the execution time
                    dgvProcessStack.Sort(dgvProcessStack.Columns[1], ListSortDirection.Ascending);
                    //setting process started time to actual time
                    _processStartedTime = _runningTime;

                    // Setting the Process execution tme as _currentProcessTime
                    _currentProcessTime = int.Parse(dgvProcessStack.Rows[0].Cells[1].Value.ToString());
                    // Print that process is sent to Execution
                    lstCommandline.Items.Add("SRT => Process has been sent to Processor(Time : " + _runningTime + ") ...");

                    //Animating ProgressBars
                    visibleLabel(dgvProcessStack.Rows[0].Cells[0].Value.ToString());
                    visibleTimeLabels();

                    //Adding the waiting time to the list of the current process
                    _waitingTimes.Add(_runningTime - Decimal.Parse(dgvProcessStack.Rows[0].Cells[2].Value.ToString()));
                    String waittime = (_runningTime - Decimal.Parse(dgvProcessStack.Rows[0].Cells[2].Value.ToString())).ToString();
                    String tat = (int.Parse(waittime) + int.Parse(dgvProcessStack.Rows[0].Cells[1].Value.ToString())).ToString();
                    dgvextra.Rows.Add(waittime, tat);
                    //Removing the Current process from the Stack

                    //Setting the process is runnig
                    _activeProcessing = true;
                    //make visible the labels
                    ProcessingStart();
                    //Setting the time to process name red
                    lblProcess.Text = dgvProcessStack.Rows[0].Cells[0].Value.ToString();

                    //Setting the Label 7 to Execution time
                    lblExeTime.Text = @"Exe.Time : " + _currentProcessTime + @" s";
                    //Setting the Label 6 to remaining time
                    lblRemTime.Text = @"Rem.Time : " + _currentProcessTime + @" s";
                    // Change the process status to Processing
                    lblStatus.Text = @"Status : Processing";
                }

                //Check any process is alive
                else
                {

                    //Checking whether the process execution finished
                    if (_processStartedTime == _runningTime - _currentProcessTime)
                    {
                        _activeProcessing = false;
                        _usedProcess += 1;
                        lstCommandline.Items.Add("END => Process Finished (Time : " + _runningTime + ")");
                        visibleTimeLabelf();
                        dgvProcessStack.Rows.RemoveAt(0);
                        ProcessingEnd();
                        if (dgvProcessStack.Rows.Count != 0) {
                            startProcess();
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void ProcessingEnd()
        {
            lblExeTime.Visible = false;
            lblRemTime.Visible = false;
            
            timer2.Enabled = false;
            lblStatus.Text = @"STATUS : Finish";
        }
        private void ProcessingStart()
        {
            lblExeTime.Visible = true;
            lblRemTime.Visible = true;
         
            timer2.Enabled = true;
            lblStatus.Text = @"STATUS : Waiting";
        }


        private void CalculateAvgTime()
        {
            try
            {
                lstCommandline.Items.Add("");
                lstCommandline.Items.Add("AVG => Calculations Started ...");
                for (int i = 0; i < _waitingTimes.Count; i++)
                {
                    _avgTime += _waitingTimes[i];
                    lstCommandline.Items.Add("DATA => Waiting Time of Process " + i + " : " + _waitingTimes[i].ToString() + @" s");
                }
                _avgTime = _avgTime / _totalProcess;
                _avgTime = Math.Round(_avgTime, 2);
                lstCommandline.Items.Add("DATA => Total No of Process : " + _totalProcess);
                // MessageBox.Show(@"Average Waiting Time : " + _avgTime.ToString()+@" s");
                lstCommandline.Items.Add("");
                lstCommandline.Items.Add("AVG => AVERAGE WAITING TIME : " + _avgTime.ToString() + @" s");

                ReportForm = new Report(_avgTime, lstCommandline, _dgvProcess, dgvextra);
                ReportForm.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ReportForm = new Report(_avgTime, lstCommandline, _dgvProcess, dgvextra);
            ReportForm.ShowDialog();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar1.Value <= 2)
            {
                trackBar1.Value = 10;
            }
            else
            {
                timer1.Interval = 1000 + 300 * (10 - trackBar1.Value);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape3_Click(object sender, EventArgs e)
        {

        }

        public Label createLabel() {
            Label labelcopy = new System.Windows.Forms.Label();
            labelcopy.AutoSize = false;
            labelcopy.BackColor = Color.Red;
            labelcopy.Visible = false;
            labelcopy.BringToFront();
            labelcopy.Location = new Point(labelxcordinate + 70, 224);
            labelxcordinate = labelxcordinate + 70 + 10;
            labelcopy.Visible = true;
            labelcopy.Text = _runningTime.ToString();
            labelcopy.Size = new System.Drawing.Size(70, 81);
            return labelcopy;

        }

        public void addProgresslabels() {

            progressLabel[0]=this.lbl1;
            lbl1.Visible = false;
            progressLabel[1] = this.lbl2;
            lbl2.Visible = false;
            progressLabel[2] = this.lbl3;
            lbl3.Visible = false;
            progressLabel[3] = this.lbl4;
            lbl4.Visible = false;
            progressLabel[4] = this.lbl5;
            lbl5.Visible = false;
            progressLabel[5] = this.lbl6;
            lbl6.Visible = false;
            progressLabel[6] = this.lbl7;
            lbl7.Visible = false;
            progressLabel[7] = this.lbl8;
            lbl8.Visible = false;
            progressLabel[8] = this.lbl9;
            lbl9.Visible = false;
            progressLabel[9] = this.lbl10;
            lbl10.Visible = false;
        }
        public void addtimelabelfs()
        {
            timeLabelf[0] = lbltf0;
            lbltf0.Visible = false;
            timeLabelf[1] = lbltf1;
            lbltf1.Visible = false;
            timeLabelf[2] = lbltf2;
            lbltf2.Visible = false;
            timeLabelf[3] = lbltf3;
            lbltf3.Visible = false;
            timeLabelf[4] = lbltf4;
            lbltf4.Visible = false;
            timeLabelf[5] = lbltf5;
            lbltf5.Visible = false;
            timeLabelf[6] = lbltf6;
            lbltf6.Visible = false;
            timeLabelf[7] = lbltf7;
            lbltf7.Visible = false;
            timeLabelf[8] = lbltf8;
            lbltf8.Visible = false;
            timeLabelf[9] = lbltf9;
            lbltf9.Visible = false;
           
        }
        public void addtimelabelss()
        {
            timeLabels[0] = lblts0;
            lblts0.Visible = false;
            timeLabels[1] = lblts1;
            lblts1.Visible = false;
            timeLabels[2] = lblts2;
            lblts2.Visible = false;
            timeLabels[3] = lblts3;
            lblts3.Visible = false;
            timeLabels[4] = lblts4;
            lblts4.Visible = false;
            timeLabels[5] = lblts5;
            lblts5.Visible = false;
            timeLabels[6] = lblts6;
            lblts6.Visible = false;
            timeLabels[7] = lblts7;
            lblts7.Visible = false;
            timeLabels[8] = lblts8;
            lblts8.Visible = false;
            timeLabels[9] = lblts9;
            lblts9.Visible = false;
        }

        public void visibleLabel(string processname) {
            progressLabel[processcounter].Visible = true;
            progressLabel[processcounter].Text = processname;
            processcounter += 1;
        }
        public void visibleTimeLabels()
        {
            timeLabels[processcountertime].Visible = true;
            timeLabels[processcountertime].Text = _runningTime.ToString();
            
        }
        public void visibleTimeLabelf()
        {
            timeLabelf[processcountertime].Visible = true;
            timeLabelf[processcountertime].Text = _runningTime.ToString();
            processcountertime += 1;
        }
    }


}

