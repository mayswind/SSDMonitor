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
            this.components = new System.ComponentModel.Container();
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
            this.pnlBlank = new System.Windows.Forms.Panel();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblHDDSize = new System.Windows.Forms.Label();
            this.lblHDDSerial = new System.Windows.Forms.Label();
            this.lblHDDHealth = new System.Windows.Forms.Label();
            this.lblHDDPoweronTimes = new System.Windows.Forms.Label();
            this.lblHDDWorktime = new System.Windows.Forms.Label();
            this.lblHDDModel = new System.Windows.Forms.Label();
            this.tpSmartInfos = new System.Windows.Forms.TabPage();
            this.smartView = new DotMaysWind.SSDMonitor.SmartControl();
            this.tpGraph = new System.Windows.Forms.TabPage();
            this.chartThroughput = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mnuContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuShowMarker = new System.Windows.Forms.ToolStripMenuItem();
            this.hddController = new DotMaysWind.SSDMonitor.Controller.HDDController();
            this.tsMain.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpOverview.SuspendLayout();
            this.grpThroughput.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.tpSmartInfos.SuspendLayout();
            this.tpGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThroughput)).BeginInit();
            this.mnuContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbHDDNames,
            this.sep1,
            this.btnRefresh,
            this.btnExit});
            resources.ApplyResources(this.tsMain, "tsMain");
            this.tsMain.Name = "tsMain";
            // 
            // cbHDDNames
            // 
            this.cbHDDNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHDDNames.Name = "cbHDDNames";
            resources.ApplyResources(this.cbHDDNames, "cbHDDNames");
            this.cbHDDNames.SelectedIndexChanged += new System.EventHandler(this.cbHDDNames_SelectedIndexChanged);
            // 
            // sep1
            // 
            this.sep1.Name = "sep1";
            resources.ApplyResources(this.sep1, "sep1");
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tcMain);
            resources.ApplyResources(this.pnlMain, "pnlMain");
            this.pnlMain.Name = "pnlMain";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpOverview);
            this.tcMain.Controls.Add(this.tpSmartInfos);
            this.tcMain.Controls.Add(this.tpGraph);
            resources.ApplyResources(this.tcMain, "tcMain");
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            // 
            // tpOverview
            // 
            this.tpOverview.Controls.Add(this.grpThroughput);
            this.tpOverview.Controls.Add(this.pnlBlank);
            this.tpOverview.Controls.Add(this.grpInfo);
            resources.ApplyResources(this.tpOverview, "tpOverview");
            this.tpOverview.Name = "tpOverview";
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
            resources.ApplyResources(this.grpThroughput, "grpThroughput");
            this.grpThroughput.Name = "grpThroughput";
            this.grpThroughput.TabStop = false;
            // 
            // lblThroughputDataWritten
            // 
            resources.ApplyResources(this.lblThroughputDataWritten, "lblThroughputDataWritten");
            this.lblThroughputDataWritten.Name = "lblThroughputDataWritten";
            // 
            // lblThroughputTotalWritten
            // 
            resources.ApplyResources(this.lblThroughputTotalWritten, "lblThroughputTotalWritten");
            this.lblThroughputTotalWritten.Name = "lblThroughputTotalWritten";
            // 
            // lblThroughputLast30DaysWritten
            // 
            resources.ApplyResources(this.lblThroughputLast30DaysWritten, "lblThroughputLast30DaysWritten");
            this.lblThroughputLast30DaysWritten.Name = "lblThroughputLast30DaysWritten";
            // 
            // lblThroughputLast7DaysWritten
            // 
            resources.ApplyResources(this.lblThroughputLast7DaysWritten, "lblThroughputLast7DaysWritten");
            this.lblThroughputLast7DaysWritten.Name = "lblThroughputLast7DaysWritten";
            // 
            // lblThroughputYesterdayWritten
            // 
            resources.ApplyResources(this.lblThroughputYesterdayWritten, "lblThroughputYesterdayWritten");
            this.lblThroughputYesterdayWritten.Name = "lblThroughputYesterdayWritten";
            // 
            // lblThroughputTodayWritten
            // 
            resources.ApplyResources(this.lblThroughputTodayWritten, "lblThroughputTodayWritten");
            this.lblThroughputTodayWritten.Name = "lblThroughputTodayWritten";
            // 
            // lblThroughputTotalRead
            // 
            resources.ApplyResources(this.lblThroughputTotalRead, "lblThroughputTotalRead");
            this.lblThroughputTotalRead.Name = "lblThroughputTotalRead";
            // 
            // lblThroughputLast30DaysRead
            // 
            resources.ApplyResources(this.lblThroughputLast30DaysRead, "lblThroughputLast30DaysRead");
            this.lblThroughputLast30DaysRead.Name = "lblThroughputLast30DaysRead";
            // 
            // lblThroughputLast7DaysRead
            // 
            resources.ApplyResources(this.lblThroughputLast7DaysRead, "lblThroughputLast7DaysRead");
            this.lblThroughputLast7DaysRead.Name = "lblThroughputLast7DaysRead";
            // 
            // lblThroughputYesterdayRead
            // 
            resources.ApplyResources(this.lblThroughputYesterdayRead, "lblThroughputYesterdayRead");
            this.lblThroughputYesterdayRead.Name = "lblThroughputYesterdayRead";
            // 
            // lblThroughputTodayRead
            // 
            resources.ApplyResources(this.lblThroughputTodayRead, "lblThroughputTodayRead");
            this.lblThroughputTodayRead.Name = "lblThroughputTodayRead";
            // 
            // lblThroughputTotal
            // 
            resources.ApplyResources(this.lblThroughputTotal, "lblThroughputTotal");
            this.lblThroughputTotal.Name = "lblThroughputTotal";
            // 
            // lblThroughputLast30Days
            // 
            resources.ApplyResources(this.lblThroughputLast30Days, "lblThroughputLast30Days");
            this.lblThroughputLast30Days.Name = "lblThroughputLast30Days";
            // 
            // lblThroughputLast7Days
            // 
            resources.ApplyResources(this.lblThroughputLast7Days, "lblThroughputLast7Days");
            this.lblThroughputLast7Days.Name = "lblThroughputLast7Days";
            // 
            // lblThroughputYesterday
            // 
            resources.ApplyResources(this.lblThroughputYesterday, "lblThroughputYesterday");
            this.lblThroughputYesterday.Name = "lblThroughputYesterday";
            // 
            // lblThroughputToday
            // 
            resources.ApplyResources(this.lblThroughputToday, "lblThroughputToday");
            this.lblThroughputToday.Name = "lblThroughputToday";
            // 
            // lblThroughputDataRead
            // 
            resources.ApplyResources(this.lblThroughputDataRead, "lblThroughputDataRead");
            this.lblThroughputDataRead.Name = "lblThroughputDataRead";
            // 
            // pnlBlank
            // 
            resources.ApplyResources(this.pnlBlank, "pnlBlank");
            this.pnlBlank.Name = "pnlBlank";
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblHDDSize);
            this.grpInfo.Controls.Add(this.lblHDDSerial);
            this.grpInfo.Controls.Add(this.lblHDDHealth);
            this.grpInfo.Controls.Add(this.lblHDDPoweronTimes);
            this.grpInfo.Controls.Add(this.lblHDDWorktime);
            this.grpInfo.Controls.Add(this.lblHDDModel);
            resources.ApplyResources(this.grpInfo, "grpInfo");
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.TabStop = false;
            // 
            // lblHDDSize
            // 
            resources.ApplyResources(this.lblHDDSize, "lblHDDSize");
            this.lblHDDSize.Name = "lblHDDSize";
            this.lblHDDSize.Tag = "";
            // 
            // lblHDDSerial
            // 
            resources.ApplyResources(this.lblHDDSerial, "lblHDDSerial");
            this.lblHDDSerial.Name = "lblHDDSerial";
            this.lblHDDSerial.Tag = "";
            // 
            // lblHDDHealth
            // 
            resources.ApplyResources(this.lblHDDHealth, "lblHDDHealth");
            this.lblHDDHealth.Name = "lblHDDHealth";
            this.lblHDDHealth.Tag = "";
            // 
            // lblHDDPoweronTimes
            // 
            resources.ApplyResources(this.lblHDDPoweronTimes, "lblHDDPoweronTimes");
            this.lblHDDPoweronTimes.Name = "lblHDDPoweronTimes";
            // 
            // lblHDDWorktime
            // 
            resources.ApplyResources(this.lblHDDWorktime, "lblHDDWorktime");
            this.lblHDDWorktime.Name = "lblHDDWorktime";
            this.lblHDDWorktime.Tag = "";
            // 
            // lblHDDModel
            // 
            resources.ApplyResources(this.lblHDDModel, "lblHDDModel");
            this.lblHDDModel.Name = "lblHDDModel";
            this.lblHDDModel.Tag = "";
            // 
            // tpSmartInfos
            // 
            this.tpSmartInfos.Controls.Add(this.smartView);
            resources.ApplyResources(this.tpSmartInfos, "tpSmartInfos");
            this.tpSmartInfos.Name = "tpSmartInfos";
            this.tpSmartInfos.UseVisualStyleBackColor = true;
            // 
            // smartView
            // 
            resources.ApplyResources(this.smartView, "smartView");
            this.smartView.Name = "smartView";
            // 
            // tpGraph
            // 
            this.tpGraph.Controls.Add(this.chartThroughput);
            resources.ApplyResources(this.tpGraph, "tpGraph");
            this.tpGraph.Name = "tpGraph";
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
            chartArea1.AxisY.Title = "Total Read / Written";
            chartArea1.AxisY2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY2.IsStartedFromZero = false;
            chartArea1.AxisY2.LabelAutoFitStyle = System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisY2.Title = "Work Time";
            chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.BorderColor = System.Drawing.Color.Gray;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 90F;
            chartArea1.Position.Width = 100F;
            this.chartThroughput.ChartAreas.Add(chartArea1);
            this.chartThroughput.ContextMenuStrip = this.mnuContext;
            resources.ApplyResources(this.chartThroughput, "chartThroughput");
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend";
            legend1.Position.Auto = false;
            legend1.Position.Height = 8F;
            legend1.Position.Width = 46.14173F;
            legend1.Position.X = 26.92913F;
            legend1.Position.Y = 92F;
            this.chartThroughput.Legends.Add(legend1);
            this.chartThroughput.Name = "chartThroughput";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.LimeGreen;
            series1.LabelToolTip = "Date: #VALX\\nTotalRead: #VAL GB";
            series1.Legend = "Legend";
            series1.MarkerBorderColor = System.Drawing.Color.Black;
            series1.MarkerColor = System.Drawing.Color.LimeGreen;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "TotalRead";
            series1.ToolTip = "Date: #VALX\\nTotalRead: #VAL GB";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.Firebrick;
            series2.LabelToolTip = "Date: #VALX\\nTotalWritten: #VAL GB";
            series2.Legend = "Legend";
            series2.MarkerBorderColor = System.Drawing.Color.Black;
            series2.MarkerColor = System.Drawing.Color.Firebrick;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series2.Name = "TotalWritten";
            series2.ToolTip = "Date: #VALX\\nTotalWritten: #VAL GB";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Color = System.Drawing.Color.Gold;
            series3.LabelToolTip = "Date: #VALX\\nWorkTime: #VAL hours";
            series3.Legend = "Legend";
            series3.MarkerBorderColor = System.Drawing.Color.Black;
            series3.MarkerColor = System.Drawing.Color.Gold;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series3.Name = "WorkTime";
            series3.ToolTip = "Date: #VALX\\nWorkTime: #VAL hours";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series3.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartThroughput.Series.Add(series1);
            this.chartThroughput.Series.Add(series2);
            this.chartThroughput.Series.Add(series3);
            // 
            // mnuContext
            // 
            this.mnuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShowMarker});
            this.mnuContext.Name = "mnuContext";
            resources.ApplyResources(this.mnuContext, "mnuContext");
            // 
            // mnuShowMarker
            // 
            this.mnuShowMarker.CheckOnClick = true;
            this.mnuShowMarker.Name = "mnuShowMarker";
            resources.ApplyResources(this.mnuShowMarker, "mnuShowMarker");
            this.mnuShowMarker.Click += new System.EventHandler(this.mnuShowMarker_Click);
            // 
            // hddController
            // 
            this.hddController.SelectedIndex = 0;
            this.hddController.HDDListChanged += new DotMaysWind.SSDMonitor.Controller.HDDListChangedHandler(this.hddController_HDDListChanged);
            this.hddController.SelectedHDDChanged += new DotMaysWind.SSDMonitor.Controller.SelectedHDDChangedHandler(this.hddController_SelectedHDDChanged);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.tsMain);
            this.Name = "MainForm";
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
            this.mnuContext.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip mnuContext;
        private System.Windows.Forms.ToolStripMenuItem mnuShowMarker;
        private SmartControl smartView;
        private System.Windows.Forms.Panel pnlBlank;
        private System.Windows.Forms.Label lblHDDSize;



    }
}