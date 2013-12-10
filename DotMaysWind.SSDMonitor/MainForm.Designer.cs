namespace DotMaysWind.SSDMonitor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.cbHDDNames = new System.Windows.Forms.ToolStripComboBox();
            this.sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpOverview = new System.Windows.Forms.TabPage();
            this.grpThroughput = new System.Windows.Forms.GroupBox();
            this.lblThroughputDataWritten = new System.Windows.Forms.Label();
            this.lblThroughputTotalWritten = new System.Windows.Forms.Label();
            this.lblThroughputLast30DaysWritten = new System.Windows.Forms.Label();
            this.lblThroughputLast7DaysWritten = new System.Windows.Forms.Label();
            this.lblThroughputYesterdayWritten = new System.Windows.Forms.Label();
            this.lblThroughputTodayWritten = new System.Windows.Forms.Label();
            this.lblThroughputTotalRead = new System.Windows.Forms.Label();
            this.lblThroughputLast30DaysRead = new System.Windows.Forms.Label();
            this.lblThroughputLast7DaysRead = new System.Windows.Forms.Label();
            this.lblThroughputYesterdayRead = new System.Windows.Forms.Label();
            this.lblThroughputTodayRead = new System.Windows.Forms.Label();
            this.lblThroughputTotal = new System.Windows.Forms.Label();
            this.lblThroughputLast30Days = new System.Windows.Forms.Label();
            this.lblThroughputLast7Days = new System.Windows.Forms.Label();
            this.lblThroughputYesterday = new System.Windows.Forms.Label();
            this.lblThroughputToday = new System.Windows.Forms.Label();
            this.lblThroughputDataRead = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblHDDSerial = new System.Windows.Forms.Label();
            this.lblHDDHealth = new System.Windows.Forms.Label();
            this.lblHDDPoweronTimes = new System.Windows.Forms.Label();
            this.lblHDDWorktime = new System.Windows.Forms.Label();
            this.lblHDDModel = new System.Windows.Forms.Label();
            this.tpSmartInfos = new System.Windows.Forms.TabPage();
            this.lvSmart = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCurrent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWorst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chThreshold = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRawData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpGraph = new System.Windows.Forms.TabPage();
            this.chartThroughput = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.hddController = new DotMaysWind.SSDMonitor.Controller.HDDController();
            this.smartInfoController = new DotMaysWind.SSDMonitor.Controller.SmartInfoController();
            this.tsMain.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpOverview.SuspendLayout();
            this.grpThroughput.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.tpSmartInfos.SuspendLayout();
            this.tpGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThroughput)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbHDDNames,
            this.sep1,
            this.btnRefresh,
            this.btnExit});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(684, 25);
            this.tsMain.TabIndex = 0;
            this.tsMain.Text = "toolStrip1";
            // 
            // cbHDDNames
            // 
            this.cbHDDNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHDDNames.Name = "cbHDDNames";
            this.cbHDDNames.Size = new System.Drawing.Size(200, 25);
            this.cbHDDNames.SelectedIndexChanged += new System.EventHandler(this.cbHDDNames_SelectedIndexChanged);
            // 
            // sep1
            // 
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(72, 22);
            this.btnRefresh.Text = "Refresh(&R)";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 22);
            this.btnExit.Text = "Exit(&X)";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tcMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 25);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMain.Size = new System.Drawing.Size(684, 356);
            this.pnlMain.TabIndex = 1;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpOverview);
            this.tcMain.Controls.Add(this.tpSmartInfos);
            this.tcMain.Controls.Add(this.tpGraph);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(10, 10);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(664, 336);
            this.tcMain.TabIndex = 3;
            // 
            // tpOverview
            // 
            this.tpOverview.Controls.Add(this.grpThroughput);
            this.tpOverview.Controls.Add(this.grpInfo);
            this.tpOverview.Location = new System.Drawing.Point(4, 22);
            this.tpOverview.Name = "tpOverview";
            this.tpOverview.Padding = new System.Windows.Forms.Padding(10);
            this.tpOverview.Size = new System.Drawing.Size(656, 310);
            this.tpOverview.TabIndex = 0;
            this.tpOverview.Text = "Overview";
            this.tpOverview.UseVisualStyleBackColor = true;
            // 
            // grpThroughput
            // 
            this.grpThroughput.Controls.Add(this.lblThroughputDataWritten);
            this.grpThroughput.Controls.Add(this.lblThroughputTotalWritten);
            this.grpThroughput.Controls.Add(this.lblThroughputLast30DaysWritten);
            this.grpThroughput.Controls.Add(this.lblThroughputLast7DaysWritten);
            this.grpThroughput.Controls.Add(this.lblThroughputYesterdayWritten);
            this.grpThroughput.Controls.Add(this.lblThroughputTodayWritten);
            this.grpThroughput.Controls.Add(this.lblThroughputTotalRead);
            this.grpThroughput.Controls.Add(this.lblThroughputLast30DaysRead);
            this.grpThroughput.Controls.Add(this.lblThroughputLast7DaysRead);
            this.grpThroughput.Controls.Add(this.lblThroughputYesterdayRead);
            this.grpThroughput.Controls.Add(this.lblThroughputTodayRead);
            this.grpThroughput.Controls.Add(this.lblThroughputTotal);
            this.grpThroughput.Controls.Add(this.lblThroughputLast30Days);
            this.grpThroughput.Controls.Add(this.lblThroughputLast7Days);
            this.grpThroughput.Controls.Add(this.lblThroughputYesterday);
            this.grpThroughput.Controls.Add(this.lblThroughputToday);
            this.grpThroughput.Controls.Add(this.lblThroughputDataRead);
            this.grpThroughput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpThroughput.Location = new System.Drawing.Point(10, 162);
            this.grpThroughput.Name = "grpThroughput";
            this.grpThroughput.Size = new System.Drawing.Size(636, 138);
            this.grpThroughput.TabIndex = 1;
            this.grpThroughput.TabStop = false;
            this.grpThroughput.Text = "Throughput";
            // 
            // lblThroughputDataWritten
            // 
            this.lblThroughputDataWritten.AutoSize = true;
            this.lblThroughputDataWritten.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblThroughputDataWritten.Location = new System.Drawing.Point(15, 100);
            this.lblThroughputDataWritten.Name = "lblThroughputDataWritten";
            this.lblThroughputDataWritten.Size = new System.Drawing.Size(124, 12);
            this.lblThroughputDataWritten.TabIndex = 5;
            this.lblThroughputDataWritten.Text = "Data written (GB)";
            this.lblThroughputDataWritten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThroughputTotalWritten
            // 
            this.lblThroughputTotalWritten.Location = new System.Drawing.Point(564, 100);
            this.lblThroughputTotalWritten.Name = "lblThroughputTotalWritten";
            this.lblThroughputTotalWritten.Size = new System.Drawing.Size(64, 12);
            this.lblThroughputTotalWritten.TabIndex = 3;
            this.lblThroughputTotalWritten.Text = "-";
            this.lblThroughputTotalWritten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThroughputLast30DaysWritten
            // 
            this.lblThroughputLast30DaysWritten.Location = new System.Drawing.Point(460, 100);
            this.lblThroughputLast30DaysWritten.Name = "lblThroughputLast30DaysWritten";
            this.lblThroughputLast30DaysWritten.Size = new System.Drawing.Size(89, 12);
            this.lblThroughputLast30DaysWritten.TabIndex = 3;
            this.lblThroughputLast30DaysWritten.Text = "-";
            this.lblThroughputLast30DaysWritten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThroughputLast7DaysWritten
            // 
            this.lblThroughputLast7DaysWritten.Location = new System.Drawing.Point(350, 100);
            this.lblThroughputLast7DaysWritten.Name = "lblThroughputLast7DaysWritten";
            this.lblThroughputLast7DaysWritten.Size = new System.Drawing.Size(82, 12);
            this.lblThroughputLast7DaysWritten.TabIndex = 3;
            this.lblThroughputLast7DaysWritten.Text = "-";
            this.lblThroughputLast7DaysWritten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThroughputYesterdayWritten
            // 
            this.lblThroughputYesterdayWritten.Location = new System.Drawing.Point(255, 100);
            this.lblThroughputYesterdayWritten.Name = "lblThroughputYesterdayWritten";
            this.lblThroughputYesterdayWritten.Size = new System.Drawing.Size(68, 12);
            this.lblThroughputYesterdayWritten.TabIndex = 3;
            this.lblThroughputYesterdayWritten.Text = "-";
            this.lblThroughputYesterdayWritten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThroughputTodayWritten
            // 
            this.lblThroughputTodayWritten.Location = new System.Drawing.Point(173, 100);
            this.lblThroughputTodayWritten.Name = "lblThroughputTodayWritten";
            this.lblThroughputTodayWritten.Size = new System.Drawing.Size(64, 12);
            this.lblThroughputTodayWritten.TabIndex = 3;
            this.lblThroughputTodayWritten.Text = "-";
            this.lblThroughputTodayWritten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThroughputTotalRead
            // 
            this.lblThroughputTotalRead.Location = new System.Drawing.Point(564, 65);
            this.lblThroughputTotalRead.Name = "lblThroughputTotalRead";
            this.lblThroughputTotalRead.Size = new System.Drawing.Size(64, 12);
            this.lblThroughputTotalRead.TabIndex = 3;
            this.lblThroughputTotalRead.Text = "-";
            this.lblThroughputTotalRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThroughputLast30DaysRead
            // 
            this.lblThroughputLast30DaysRead.Location = new System.Drawing.Point(460, 65);
            this.lblThroughputLast30DaysRead.Name = "lblThroughputLast30DaysRead";
            this.lblThroughputLast30DaysRead.Size = new System.Drawing.Size(89, 12);
            this.lblThroughputLast30DaysRead.TabIndex = 3;
            this.lblThroughputLast30DaysRead.Text = "-";
            this.lblThroughputLast30DaysRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThroughputLast7DaysRead
            // 
            this.lblThroughputLast7DaysRead.Location = new System.Drawing.Point(350, 65);
            this.lblThroughputLast7DaysRead.Name = "lblThroughputLast7DaysRead";
            this.lblThroughputLast7DaysRead.Size = new System.Drawing.Size(82, 12);
            this.lblThroughputLast7DaysRead.TabIndex = 3;
            this.lblThroughputLast7DaysRead.Text = "-";
            this.lblThroughputLast7DaysRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThroughputYesterdayRead
            // 
            this.lblThroughputYesterdayRead.Location = new System.Drawing.Point(255, 65);
            this.lblThroughputYesterdayRead.Name = "lblThroughputYesterdayRead";
            this.lblThroughputYesterdayRead.Size = new System.Drawing.Size(68, 12);
            this.lblThroughputYesterdayRead.TabIndex = 3;
            this.lblThroughputYesterdayRead.Text = "-";
            this.lblThroughputYesterdayRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThroughputTodayRead
            // 
            this.lblThroughputTodayRead.Location = new System.Drawing.Point(173, 65);
            this.lblThroughputTodayRead.Name = "lblThroughputTodayRead";
            this.lblThroughputTodayRead.Size = new System.Drawing.Size(64, 12);
            this.lblThroughputTodayRead.TabIndex = 3;
            this.lblThroughputTodayRead.Text = "-";
            this.lblThroughputTodayRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThroughputTotal
            // 
            this.lblThroughputTotal.AutoSize = true;
            this.lblThroughputTotal.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblThroughputTotal.Location = new System.Drawing.Point(575, 25);
            this.lblThroughputTotal.Name = "lblThroughputTotal";
            this.lblThroughputTotal.Size = new System.Drawing.Size(40, 12);
            this.lblThroughputTotal.TabIndex = 5;
            this.lblThroughputTotal.Text = "Total";
            this.lblThroughputTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThroughputLast30Days
            // 
            this.lblThroughputLast30Days.AutoSize = true;
            this.lblThroughputLast30Days.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblThroughputLast30Days.Location = new System.Drawing.Point(460, 25);
            this.lblThroughputLast30Days.Name = "lblThroughputLast30Days";
            this.lblThroughputLast30Days.Size = new System.Drawing.Size(89, 12);
            this.lblThroughputLast30Days.TabIndex = 5;
            this.lblThroughputLast30Days.Text = "Last 30 days";
            this.lblThroughputLast30Days.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThroughputLast7Days
            // 
            this.lblThroughputLast7Days.AutoSize = true;
            this.lblThroughputLast7Days.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblThroughputLast7Days.Location = new System.Drawing.Point(350, 25);
            this.lblThroughputLast7Days.Name = "lblThroughputLast7Days";
            this.lblThroughputLast7Days.Size = new System.Drawing.Size(82, 12);
            this.lblThroughputLast7Days.TabIndex = 5;
            this.lblThroughputLast7Days.Text = "Last 7 days";
            this.lblThroughputLast7Days.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThroughputYesterday
            // 
            this.lblThroughputYesterday.AutoSize = true;
            this.lblThroughputYesterday.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblThroughputYesterday.Location = new System.Drawing.Point(255, 25);
            this.lblThroughputYesterday.Name = "lblThroughputYesterday";
            this.lblThroughputYesterday.Size = new System.Drawing.Size(68, 12);
            this.lblThroughputYesterday.TabIndex = 5;
            this.lblThroughputYesterday.Text = "Yesterday";
            this.lblThroughputYesterday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThroughputToday
            // 
            this.lblThroughputToday.AutoSize = true;
            this.lblThroughputToday.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblThroughputToday.Location = new System.Drawing.Point(185, 25);
            this.lblThroughputToday.Name = "lblThroughputToday";
            this.lblThroughputToday.Size = new System.Drawing.Size(40, 12);
            this.lblThroughputToday.TabIndex = 5;
            this.lblThroughputToday.Text = "Today";
            this.lblThroughputToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThroughputDataRead
            // 
            this.lblThroughputDataRead.AutoSize = true;
            this.lblThroughputDataRead.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblThroughputDataRead.Location = new System.Drawing.Point(15, 65);
            this.lblThroughputDataRead.Name = "lblThroughputDataRead";
            this.lblThroughputDataRead.Size = new System.Drawing.Size(103, 12);
            this.lblThroughputDataRead.TabIndex = 5;
            this.lblThroughputDataRead.Text = "Data read (GB)";
            this.lblThroughputDataRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblHDDSerial);
            this.grpInfo.Controls.Add(this.lblHDDHealth);
            this.grpInfo.Controls.Add(this.lblHDDPoweronTimes);
            this.grpInfo.Controls.Add(this.lblHDDWorktime);
            this.grpInfo.Controls.Add(this.lblHDDModel);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInfo.Location = new System.Drawing.Point(10, 10);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(636, 152);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Info";
            // 
            // lblHDDSerial
            // 
            this.lblHDDSerial.AutoSize = true;
            this.lblHDDSerial.Location = new System.Drawing.Point(15, 45);
            this.lblHDDSerial.Name = "lblHDDSerial";
            this.lblHDDSerial.Size = new System.Drawing.Size(65, 12);
            this.lblHDDSerial.TabIndex = 4;
            this.lblHDDSerial.Text = "HDD Serial";
            // 
            // lblHDDHealth
            // 
            this.lblHDDHealth.AutoSize = true;
            this.lblHDDHealth.Location = new System.Drawing.Point(15, 125);
            this.lblHDDHealth.Name = "lblHDDHealth";
            this.lblHDDHealth.Size = new System.Drawing.Size(77, 12);
            this.lblHDDHealth.TabIndex = 3;
            this.lblHDDHealth.Text = "Health: 100%";
            // 
            // lblHDDPoweronTimes
            // 
            this.lblHDDPoweronTimes.AutoSize = true;
            this.lblHDDPoweronTimes.Location = new System.Drawing.Point(15, 105);
            this.lblHDDPoweronTimes.Name = "lblHDDPoweronTimes";
            this.lblHDDPoweronTimes.Size = new System.Drawing.Size(113, 12);
            this.lblHDDPoweronTimes.TabIndex = 2;
            this.lblHDDPoweronTimes.Text = "Powered on: 0 time";
            // 
            // lblHDDWorktime
            // 
            this.lblHDDWorktime.AutoSize = true;
            this.lblHDDWorktime.Location = new System.Drawing.Point(15, 85);
            this.lblHDDWorktime.Name = "lblHDDWorktime";
            this.lblHDDWorktime.Size = new System.Drawing.Size(107, 12);
            this.lblHDDWorktime.TabIndex = 1;
            this.lblHDDWorktime.Text = "Work time: 0 hour";
            // 
            // lblHDDModel
            // 
            this.lblHDDModel.AutoSize = true;
            this.lblHDDModel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHDDModel.Location = new System.Drawing.Point(15, 25);
            this.lblHDDModel.Name = "lblHDDModel";
            this.lblHDDModel.Size = new System.Drawing.Size(103, 12);
            this.lblHDDModel.TabIndex = 0;
            this.lblHDDModel.Text = "HDD Model Name";
            // 
            // tpSmartInfos
            // 
            this.tpSmartInfos.Controls.Add(this.lvSmart);
            this.tpSmartInfos.Location = new System.Drawing.Point(4, 22);
            this.tpSmartInfos.Name = "tpSmartInfos";
            this.tpSmartInfos.Padding = new System.Windows.Forms.Padding(10);
            this.tpSmartInfos.Size = new System.Drawing.Size(656, 310);
            this.tpSmartInfos.TabIndex = 1;
            this.tpSmartInfos.Text = "S.M.A.R.T";
            this.tpSmartInfos.UseVisualStyleBackColor = true;
            // 
            // lvSmart
            // 
            this.lvSmart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chCurrent,
            this.chWorst,
            this.chThreshold,
            this.chRawData,
            this.chStatus});
            this.lvSmart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSmart.FullRowSelect = true;
            this.lvSmart.GridLines = true;
            this.lvSmart.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSmart.Location = new System.Drawing.Point(10, 10);
            this.lvSmart.MultiSelect = false;
            this.lvSmart.Name = "lvSmart";
            this.lvSmart.Size = new System.Drawing.Size(636, 290);
            this.lvSmart.TabIndex = 1;
            this.lvSmart.UseCompatibleStateImageBehavior = false;
            this.lvSmart.View = System.Windows.Forms.View.Details;
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 30;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 230;
            // 
            // chCurrent
            // 
            this.chCurrent.Text = "Current";
            this.chCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chWorst
            // 
            this.chWorst.Text = "Worst";
            this.chWorst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chThreshold
            // 
            this.chThreshold.Text = "Threshold";
            this.chThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chRawData
            // 
            this.chRawData.Text = "Raw";
            this.chRawData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chRawData.Width = 130;
            // 
            // chStatus
            // 
            this.chStatus.Text = "Status";
            this.chStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chStatus.Width = 40;
            // 
            // tpGraph
            // 
            this.tpGraph.Controls.Add(this.chartThroughput);
            this.tpGraph.Location = new System.Drawing.Point(4, 22);
            this.tpGraph.Name = "tpGraph";
            this.tpGraph.Padding = new System.Windows.Forms.Padding(10);
            this.tpGraph.Size = new System.Drawing.Size(656, 310);
            this.tpGraph.TabIndex = 2;
            this.tpGraph.Text = "Graph";
            this.tpGraph.UseVisualStyleBackColor = true;
            // 
            // chartThroughput
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LabelAutoFitStyle = System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45;
            chartArea1.AxisX.LabelStyle.Format = "yyyy-MM-dd";
            chartArea1.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45 | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY2.IsStartedFromZero = false;
            chartArea1.AxisY2.LabelAutoFitStyle = System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.BorderColor = System.Drawing.Color.Gray;
            chartArea1.Name = "ChartArea";
            this.chartThroughput.ChartAreas.Add(chartArea1);
            this.chartThroughput.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend";
            this.chartThroughput.Legends.Add(legend1);
            this.chartThroughput.Location = new System.Drawing.Point(10, 10);
            this.chartThroughput.Margin = new System.Windows.Forms.Padding(0);
            this.chartThroughput.Name = "chartThroughput";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.LimeGreen;
            series1.Legend = "Legend";
            series1.Name = "TotalRead";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.Firebrick;
            series2.Legend = "Legend";
            series2.Name = "TotalWritten";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Color = System.Drawing.Color.Gold;
            series3.Legend = "Legend";
            series3.Name = "WorkTime";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series3.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartThroughput.Series.Add(series1);
            this.chartThroughput.Series.Add(series2);
            this.chartThroughput.Series.Add(series3);
            this.chartThroughput.Size = new System.Drawing.Size(636, 290);
            this.chartThroughput.TabIndex = 0;
            // 
            // hddController
            // 
            this.hddController.SelectedIndex = 0;
            this.hddController.HDDListChanged += new DotMaysWind.SSDMonitor.Controller.HDDListChangedHandler(this.hddController_HDDListChanged);
            this.hddController.SelectedHDDChanged += new DotMaysWind.SSDMonitor.Controller.SelectedHDDChangedHandler(this.hddController_SelectedHDDChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 381);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.tsMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSDMonitor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tpOverview.ResumeLayout(false);
            this.grpThroughput.ResumeLayout(false);
            this.grpThroughput.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.tpSmartInfos.ResumeLayout(false);
            this.tpGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartThroughput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpOverview;
        private System.Windows.Forms.GroupBox grpThroughput;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblHDDSerial;
        private System.Windows.Forms.Label lblHDDHealth;
        private System.Windows.Forms.Label lblHDDPoweronTimes;
        private System.Windows.Forms.Label lblHDDWorktime;
        private System.Windows.Forms.Label lblHDDModel;
        private System.Windows.Forms.TabPage tpSmartInfos;
        private System.Windows.Forms.ListView lvSmart;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chCurrent;
        private System.Windows.Forms.ColumnHeader chWorst;
        private System.Windows.Forms.ColumnHeader chThreshold;
        private System.Windows.Forms.ColumnHeader chRawData;
        private System.Windows.Forms.ColumnHeader chStatus;
        private System.Windows.Forms.TabPage tpGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThroughput;
        private System.Windows.Forms.ToolStripComboBox cbHDDNames;
        private System.Windows.Forms.ToolStripSeparator sep1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.Label lblThroughputDataWritten;
        private System.Windows.Forms.Label lblThroughputDataRead;
        private System.Windows.Forms.Label lblThroughputToday;
        private System.Windows.Forms.Label lblThroughputLast30Days;
        private System.Windows.Forms.Label lblThroughputLast7Days;
        private System.Windows.Forms.Label lblThroughputYesterday;
        private System.Windows.Forms.Label lblThroughputTotal;
        private System.Windows.Forms.Label lblThroughputTodayRead;
        private System.Windows.Forms.Label lblThroughputTodayWritten;
        private System.Windows.Forms.Label lblThroughputTotalWritten;
        private System.Windows.Forms.Label lblThroughputLast30DaysWritten;
        private System.Windows.Forms.Label lblThroughputLast7DaysWritten;
        private System.Windows.Forms.Label lblThroughputYesterdayWritten;
        private System.Windows.Forms.Label lblThroughputTotalRead;
        private System.Windows.Forms.Label lblThroughputLast30DaysRead;
        private System.Windows.Forms.Label lblThroughputLast7DaysRead;
        private System.Windows.Forms.Label lblThroughputYesterdayRead;
        private Controller.HDDController hddController;
        private Controller.SmartInfoController smartInfoController;



    }
}