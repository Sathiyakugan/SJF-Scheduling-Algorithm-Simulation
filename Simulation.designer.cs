namespace WindowsFormsApplication4
{
    partial class Simulation
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProcessStack = new System.Windows.Forms.DataGridView();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstCommandline = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblProcessName = new System.Windows.Forms.Label();
            this.lblProcess = new System.Windows.Forms.Label();
            this.lblExeTime = new System.Windows.Forms.Label();
            this.lblRemTime = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.lblts0 = new System.Windows.Forms.Label();
            this.dgvextra = new System.Windows.Forms.DataGridView();
            this.waittime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbltf0 = new System.Windows.Forms.Label();
            this.lbltf1 = new System.Windows.Forms.Label();
            this.lbltf2 = new System.Windows.Forms.Label();
            this.lbltf3 = new System.Windows.Forms.Label();
            this.lbltf4 = new System.Windows.Forms.Label();
            this.lbltf5 = new System.Windows.Forms.Label();
            this.lbltf6 = new System.Windows.Forms.Label();
            this.lbltf7 = new System.Windows.Forms.Label();
            this.lbltf9 = new System.Windows.Forms.Label();
            this.lbltf8 = new System.Windows.Forms.Label();
            this.lblts1 = new System.Windows.Forms.Label();
            this.lblts2 = new System.Windows.Forms.Label();
            this.lblts3 = new System.Windows.Forms.Label();
            this.lblts4 = new System.Windows.Forms.Label();
            this.lblts5 = new System.Windows.Forms.Label();
            this.lblts6 = new System.Windows.Forms.Label();
            this.lblts8 = new System.Windows.Forms.Label();
            this.lblts7 = new System.Windows.Forms.Label();
            this.lblts9 = new System.Windows.Forms.Label();
            this.rectangleShape4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessStack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvextra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProcessStack
            // 
            this.dgvProcessStack.AllowUserToAddRows = false;
            this.dgvProcessStack.AllowUserToDeleteRows = false;
            this.dgvProcessStack.AllowUserToResizeColumns = false;
            this.dgvProcessStack.AllowUserToResizeRows = false;
            this.dgvProcessStack.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dgvProcessStack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProcessStack.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProcessStack.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProcessStack.ColumnHeadersHeight = 35;
            this.dgvProcessStack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProcessStack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.description,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProcessStack.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProcessStack.Location = new System.Drawing.Point(273, 25);
            this.dgvProcessStack.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProcessStack.MultiSelect = false;
            this.dgvProcessStack.Name = "dgvProcessStack";
            this.dgvProcessStack.ReadOnly = true;
            this.dgvProcessStack.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProcessStack.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProcessStack.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProcessStack.RowTemplate.Height = 40;
            this.dgvProcessStack.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProcessStack.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcessStack.ShowCellErrors = false;
            this.dgvProcessStack.ShowCellToolTips = false;
            this.dgvProcessStack.ShowEditingIcon = false;
            this.dgvProcessStack.ShowRowErrors = false;
            this.dgvProcessStack.Size = new System.Drawing.Size(134, 172);
            this.dgvProcessStack.TabIndex = 58;
            this.dgvProcessStack.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellContentClick);
            // 
            // description
            // 
            this.description.HeaderText = "Process Stack";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 175;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "exe";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "arr";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // lstCommandline
            // 
            this.lstCommandline.BackColor = System.Drawing.Color.Black;
            this.lstCommandline.Font = new System.Drawing.Font("Windows Command Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCommandline.ForeColor = System.Drawing.Color.White;
            this.lstCommandline.FormattingEnabled = true;
            this.lstCommandline.ItemHeight = 14;
            this.lstCommandline.Location = new System.Drawing.Point(20, 318);
            this.lstCommandline.Margin = new System.Windows.Forms.Padding(2);
            this.lstCommandline.Name = "lstCommandline";
            this.lstCommandline.Size = new System.Drawing.Size(806, 256);
            this.lstCommandline.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Digital-7", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 104);
            this.label1.TabIndex = 66;
            this.label1.Text = "00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblProcessName
            // 
            this.lblProcessName.AutoSize = true;
            this.lblProcessName.BackColor = System.Drawing.Color.Transparent;
            this.lblProcessName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProcessName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessName.ForeColor = System.Drawing.Color.Black;
            this.lblProcessName.Location = new System.Drawing.Point(14, 31);
            this.lblProcessName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProcessName.Name = "lblProcessName";
            this.lblProcessName.Size = new System.Drawing.Size(118, 21);
            this.lblProcessName.TabIndex = 67;
            this.lblProcessName.Text = "No .Of Process";
            this.lblProcessName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProcess
            // 
            this.lblProcess.BackColor = System.Drawing.Color.Transparent;
            this.lblProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProcess.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcess.ForeColor = System.Drawing.Color.Red;
            this.lblProcess.Location = new System.Drawing.Point(14, 52);
            this.lblProcess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(105, 19);
            this.lblProcess.TabIndex = 68;
            this.lblProcess.Text = "Process Name ";
            this.lblProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblExeTime
            // 
            this.lblExeTime.AutoSize = true;
            this.lblExeTime.BackColor = System.Drawing.Color.Transparent;
            this.lblExeTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblExeTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExeTime.ForeColor = System.Drawing.Color.Black;
            this.lblExeTime.Location = new System.Drawing.Point(14, 79);
            this.lblExeTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExeTime.Name = "lblExeTime";
            this.lblExeTime.Size = new System.Drawing.Size(113, 21);
            this.lblExeTime.TabIndex = 69;
            this.lblExeTime.Text = "Exe. Time : 0 S";
            this.lblExeTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRemTime
            // 
            this.lblRemTime.AutoSize = true;
            this.lblRemTime.BackColor = System.Drawing.Color.Transparent;
            this.lblRemTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRemTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemTime.ForeColor = System.Drawing.Color.Black;
            this.lblRemTime.Location = new System.Drawing.Point(14, 103);
            this.lblRemTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemTime.Name = "lblRemTime";
            this.lblRemTime.Size = new System.Drawing.Size(121, 21);
            this.lblRemTime.TabIndex = 70;
            this.lblRemTime.Text = "Rem. Time : 0 S";
            this.lblRemTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRemTime.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(14, 126);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(78, 21);
            this.lblStatus.TabIndex = 71;
            this.lblStatus.Text = "STATUS : ";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer2
            // 
            this.timer2.Interval = 300;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(37, 128);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(161, 45);
            this.trackBar1.TabIndex = 74;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape4,
            this.rectangleShape3,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(848, 661);
            this.shapeContainer1.TabIndex = 76;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape3.FillColor = System.Drawing.Color.DodgerBlue;
            this.rectangleShape3.FillGradientColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape3.Location = new System.Drawing.Point(20, 16);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(805, 285);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.lblProcessName);
            this.groupBox1.Controls.Add(this.lblRemTime);
            this.groupBox1.Controls.Add(this.lblProcess);
            this.groupBox1.Controls.Add(this.lblExeTime);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 172);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process Details";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Digital-7", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(412, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 172);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TimeStamp";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 79;
            // 
            // lblts0
            // 
            this.lblts0.AutoSize = true;
            this.lblts0.Location = new System.Drawing.Point(41, 286);
            this.lblts0.Name = "lblts0";
            this.lblts0.Size = new System.Drawing.Size(13, 13);
            this.lblts0.TabIndex = 80;
            this.lblts0.Text = "0";
            this.lblts0.Click += new System.EventHandler(this.label10_Click);
            // 
            // dgvextra
            // 
            this.dgvextra.AllowUserToAddRows = false;
            this.dgvextra.AllowUserToDeleteRows = false;
            this.dgvextra.AllowUserToResizeColumns = false;
            this.dgvextra.AllowUserToResizeRows = false;
            this.dgvextra.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvextra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvextra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvextra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvextra.ColumnHeadersHeight = 35;
            this.dgvextra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvextra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.waittime,
            this.TAT});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvextra.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvextra.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvextra.Location = new System.Drawing.Point(218, 331);
            this.dgvextra.Margin = new System.Windows.Forms.Padding(2);
            this.dgvextra.MultiSelect = false;
            this.dgvextra.Name = "dgvextra";
            this.dgvextra.ReadOnly = true;
            this.dgvextra.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvextra.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvextra.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvextra.RowTemplate.Height = 40;
            this.dgvextra.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvextra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvextra.ShowCellErrors = false;
            this.dgvextra.ShowCellToolTips = false;
            this.dgvextra.ShowEditingIcon = false;
            this.dgvextra.ShowRowErrors = false;
            this.dgvextra.Size = new System.Drawing.Size(282, 240);
            this.dgvextra.TabIndex = 84;
            // 
            // waittime
            // 
            this.waittime.HeaderText = "Wait.Time";
            this.waittime.Name = "waittime";
            this.waittime.ReadOnly = true;
            this.waittime.Width = 150;
            // 
            // TAT
            // 
            this.TAT.HeaderText = "TAT";
            this.TAT.Name = "TAT";
            this.TAT.ReadOnly = true;
            this.TAT.Width = 145;
            // 
            // lbl1
            // 
            this.lbl1.Location = new System.Drawing.Point(44, 222);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(60, 46);
            this.lbl1.TabIndex = 85;
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.LightGray;
            this.lbl2.Location = new System.Drawing.Point(120, 222);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(60, 46);
            this.lbl2.TabIndex = 86;
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.LightCoral;
            this.lbl3.Location = new System.Drawing.Point(195, 222);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(60, 46);
            this.lbl3.TabIndex = 87;
            // 
            // lbl4
            // 
            this.lbl4.BackColor = System.Drawing.Color.RosyBrown;
            this.lbl4.Location = new System.Drawing.Point(274, 222);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(60, 46);
            this.lbl4.TabIndex = 88;
            // 
            // lbl5
            // 
            this.lbl5.BackColor = System.Drawing.Color.Peru;
            this.lbl5.Location = new System.Drawing.Point(350, 222);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(60, 46);
            this.lbl5.TabIndex = 89;
            // 
            // lbl6
            // 
            this.lbl6.BackColor = System.Drawing.Color.LightSalmon;
            this.lbl6.Location = new System.Drawing.Point(431, 222);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(60, 46);
            this.lbl6.TabIndex = 90;
            // 
            // lbl7
            // 
            this.lbl7.BackColor = System.Drawing.Color.Khaki;
            this.lbl7.Location = new System.Drawing.Point(511, 222);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(60, 46);
            this.lbl7.TabIndex = 91;
            // 
            // lbl8
            // 
            this.lbl8.BackColor = System.Drawing.Color.Khaki;
            this.lbl8.Location = new System.Drawing.Point(588, 222);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(60, 46);
            this.lbl8.TabIndex = 92;
            // 
            // lbl9
            // 
            this.lbl9.BackColor = System.Drawing.Color.Tan;
            this.lbl9.Location = new System.Drawing.Point(668, 222);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(60, 46);
            this.lbl9.TabIndex = 93;
            // 
            // lbl10
            // 
            this.lbl10.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl10.Location = new System.Drawing.Point(748, 222);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(60, 46);
            this.lbl10.TabIndex = 94;
            // 
            // lbltf0
            // 
            this.lbltf0.AutoSize = true;
            this.lbltf0.Location = new System.Drawing.Point(91, 286);
            this.lbltf0.Name = "lbltf0";
            this.lbltf0.Size = new System.Drawing.Size(13, 13);
            this.lbltf0.TabIndex = 95;
            this.lbltf0.Text = "0";
            // 
            // lbltf1
            // 
            this.lbltf1.AutoSize = true;
            this.lbltf1.Location = new System.Drawing.Point(167, 286);
            this.lbltf1.Name = "lbltf1";
            this.lbltf1.Size = new System.Drawing.Size(13, 13);
            this.lbltf1.TabIndex = 96;
            this.lbltf1.Text = "0";
            // 
            // lbltf2
            // 
            this.lbltf2.AutoSize = true;
            this.lbltf2.Location = new System.Drawing.Point(242, 286);
            this.lbltf2.Name = "lbltf2";
            this.lbltf2.Size = new System.Drawing.Size(13, 13);
            this.lbltf2.TabIndex = 97;
            this.lbltf2.Text = "0";
            // 
            // lbltf3
            // 
            this.lbltf3.AutoSize = true;
            this.lbltf3.Location = new System.Drawing.Point(321, 286);
            this.lbltf3.Name = "lbltf3";
            this.lbltf3.Size = new System.Drawing.Size(13, 13);
            this.lbltf3.TabIndex = 98;
            this.lbltf3.Text = "0";
            // 
            // lbltf4
            // 
            this.lbltf4.AutoSize = true;
            this.lbltf4.Location = new System.Drawing.Point(397, 286);
            this.lbltf4.Name = "lbltf4";
            this.lbltf4.Size = new System.Drawing.Size(13, 13);
            this.lbltf4.TabIndex = 99;
            this.lbltf4.Text = "0";
            // 
            // lbltf5
            // 
            this.lbltf5.AutoSize = true;
            this.lbltf5.Location = new System.Drawing.Point(478, 286);
            this.lbltf5.Name = "lbltf5";
            this.lbltf5.Size = new System.Drawing.Size(13, 13);
            this.lbltf5.TabIndex = 100;
            this.lbltf5.Text = "0";
            // 
            // lbltf6
            // 
            this.lbltf6.AutoSize = true;
            this.lbltf6.Location = new System.Drawing.Point(558, 286);
            this.lbltf6.Name = "lbltf6";
            this.lbltf6.Size = new System.Drawing.Size(13, 13);
            this.lbltf6.TabIndex = 101;
            this.lbltf6.Text = "0";
            // 
            // lbltf7
            // 
            this.lbltf7.AutoSize = true;
            this.lbltf7.Location = new System.Drawing.Point(635, 286);
            this.lbltf7.Name = "lbltf7";
            this.lbltf7.Size = new System.Drawing.Size(13, 13);
            this.lbltf7.TabIndex = 102;
            this.lbltf7.Text = "0";
            // 
            // lbltf9
            // 
            this.lbltf9.AutoSize = true;
            this.lbltf9.Location = new System.Drawing.Point(795, 286);
            this.lbltf9.Name = "lbltf9";
            this.lbltf9.Size = new System.Drawing.Size(13, 13);
            this.lbltf9.TabIndex = 103;
            this.lbltf9.Text = "0";
            // 
            // lbltf8
            // 
            this.lbltf8.AutoSize = true;
            this.lbltf8.Location = new System.Drawing.Point(715, 286);
            this.lbltf8.Name = "lbltf8";
            this.lbltf8.Size = new System.Drawing.Size(13, 13);
            this.lbltf8.TabIndex = 104;
            this.lbltf8.Text = "0";
            // 
            // lblts1
            // 
            this.lblts1.AutoSize = true;
            this.lblts1.Location = new System.Drawing.Point(120, 286);
            this.lblts1.Name = "lblts1";
            this.lblts1.Size = new System.Drawing.Size(13, 13);
            this.lblts1.TabIndex = 105;
            this.lblts1.Text = "0";
            // 
            // lblts2
            // 
            this.lblts2.AutoSize = true;
            this.lblts2.Location = new System.Drawing.Point(195, 286);
            this.lblts2.Name = "lblts2";
            this.lblts2.Size = new System.Drawing.Size(13, 13);
            this.lblts2.TabIndex = 106;
            this.lblts2.Text = "0";
            // 
            // lblts3
            // 
            this.lblts3.AutoSize = true;
            this.lblts3.Location = new System.Drawing.Point(274, 286);
            this.lblts3.Name = "lblts3";
            this.lblts3.Size = new System.Drawing.Size(13, 13);
            this.lblts3.TabIndex = 107;
            this.lblts3.Text = "0";
            // 
            // lblts4
            // 
            this.lblts4.AutoSize = true;
            this.lblts4.Location = new System.Drawing.Point(350, 286);
            this.lblts4.Name = "lblts4";
            this.lblts4.Size = new System.Drawing.Size(13, 13);
            this.lblts4.TabIndex = 108;
            this.lblts4.Text = "0";
            // 
            // lblts5
            // 
            this.lblts5.AutoSize = true;
            this.lblts5.Location = new System.Drawing.Point(431, 286);
            this.lblts5.Name = "lblts5";
            this.lblts5.Size = new System.Drawing.Size(13, 13);
            this.lblts5.TabIndex = 109;
            this.lblts5.Text = "0";
            // 
            // lblts6
            // 
            this.lblts6.AutoSize = true;
            this.lblts6.Location = new System.Drawing.Point(511, 286);
            this.lblts6.Name = "lblts6";
            this.lblts6.Size = new System.Drawing.Size(13, 13);
            this.lblts6.TabIndex = 110;
            this.lblts6.Text = "0";
            // 
            // lblts8
            // 
            this.lblts8.AutoSize = true;
            this.lblts8.Location = new System.Drawing.Point(668, 286);
            this.lblts8.Name = "lblts8";
            this.lblts8.Size = new System.Drawing.Size(13, 13);
            this.lblts8.TabIndex = 111;
            this.lblts8.Text = "0";
            // 
            // lblts7
            // 
            this.lblts7.AutoSize = true;
            this.lblts7.Location = new System.Drawing.Point(588, 286);
            this.lblts7.Name = "lblts7";
            this.lblts7.Size = new System.Drawing.Size(13, 13);
            this.lblts7.TabIndex = 112;
            this.lblts7.Text = "0";
            // 
            // lblts9
            // 
            this.lblts9.AutoSize = true;
            this.lblts9.Location = new System.Drawing.Point(748, 286);
            this.lblts9.Name = "lblts9";
            this.lblts9.Size = new System.Drawing.Size(13, 13);
            this.lblts9.TabIndex = 113;
            this.lblts9.Text = "0";
            // 
            // rectangleShape4
            // 
            this.rectangleShape4.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.rectangleShape4.BorderWidth = 4;
            this.rectangleShape4.CornerRadius = 9;
            this.rectangleShape4.Location = new System.Drawing.Point(36, 211);
            this.rectangleShape4.Name = "rectangleShape4";
            this.rectangleShape4.Size = new System.Drawing.Size(779, 68);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::WindowsFormsApplication4.Properties.Resources._1492519089_Close;
            this.btnClose.Location = new System.Drawing.Point(705, 593);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 44);
            this.btnClose.TabIndex = 78;
            this.btnClose.Text = "CLOSE";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Image = global::WindowsFormsApplication4.Properties.Resources._1492531628_Ago_arrow_arrow_left_back_previous_direction_left;
            this.btnBack.Location = new System.Drawing.Point(19, 593);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 44);
            this.btnBack.TabIndex = 75;
            this.btnBack.Text = "BACK";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReport.Enabled = false;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.Black;
            this.btnReport.Image = global::WindowsFormsApplication4.Properties.Resources._1492532290_Cloud_graph_graph_graph_report_online_graph_pie_graph;
            this.btnReport.Location = new System.Drawing.Point(691, 92);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(117, 45);
            this.btnReport.TabIndex = 73;
            this.btnReport.Text = "REPORT";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Image = global::WindowsFormsApplication4.Properties.Resources._1492532215_311Arrow_film_movie_play_player_start_video;
            this.btnStart.Location = new System.Drawing.Point(691, 25);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(117, 45);
            this.btnStart.TabIndex = 64;
            this.btnStart.Text = "START";
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.White;
            this.rectangleShape1.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.hdfhg_copy1;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.CornerRadius = 10;
            this.rectangleShape1.FillColor = System.Drawing.Color.SteelBlue;
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.SteelBlue;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(5, 6);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(834, 649);
            this.rectangleShape1.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(848, 661);
            this.Controls.Add(this.lblts9);
            this.Controls.Add(this.lblts7);
            this.Controls.Add(this.lblts8);
            this.Controls.Add(this.lblts6);
            this.Controls.Add(this.lblts5);
            this.Controls.Add(this.lblts4);
            this.Controls.Add(this.lblts3);
            this.Controls.Add(this.lblts2);
            this.Controls.Add(this.lblts1);
            this.Controls.Add(this.lbltf8);
            this.Controls.Add(this.lbltf9);
            this.Controls.Add(this.lbltf7);
            this.Controls.Add(this.lbltf6);
            this.Controls.Add(this.lbltf5);
            this.Controls.Add(this.lbltf4);
            this.Controls.Add(this.lbltf3);
            this.Controls.Add(this.lbltf2);
            this.Controls.Add(this.lbltf1);
            this.Controls.Add(this.lbltf0);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblts0);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dgvProcessStack);
            this.Controls.Add(this.lstCommandline);
            this.Controls.Add(this.dgvextra);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Simulation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulation";
            this.Load += new System.EventHandler(this.Simulation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessStack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvextra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProcessStack;
        private System.Windows.Forms.ListBox lstCommandline;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblProcessName;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label lblExeTime;
        private System.Windows.Forms.Label lblRemTime;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnBack;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblts0;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView dgvextra;
        private System.Windows.Forms.DataGridViewTextBoxColumn waittime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAT;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbltf0;
        private System.Windows.Forms.Label lbltf1;
        private System.Windows.Forms.Label lbltf2;
        private System.Windows.Forms.Label lbltf3;
        private System.Windows.Forms.Label lbltf4;
        private System.Windows.Forms.Label lbltf5;
        private System.Windows.Forms.Label lbltf6;
        private System.Windows.Forms.Label lbltf7;
        private System.Windows.Forms.Label lbltf9;
        private System.Windows.Forms.Label lbltf8;
        private System.Windows.Forms.Label lblts1;
        private System.Windows.Forms.Label lblts2;
        private System.Windows.Forms.Label lblts3;
        private System.Windows.Forms.Label lblts4;
        private System.Windows.Forms.Label lblts5;
        private System.Windows.Forms.Label lblts6;
        private System.Windows.Forms.Label lblts8;
        private System.Windows.Forms.Label lblts7;
        private System.Windows.Forms.Label lblts9;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape4;
    }
}