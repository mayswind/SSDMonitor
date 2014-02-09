using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using DotMaysWind.SSDMonitor.Controller;
using DotMaysWind.SSDMonitor.Hardware;
using DotMaysWind.SSDMonitor.Storage;

namespace DotMaysWind.SSDMonitor
{
    public partial class MainForm : Form
    {
        #region 字段
        private ComponentResourceManager ResManager;
        #endregion

        #region 构造方法
        public MainForm()
        {
            this.ResManager = new ComponentResourceManager(typeof(MainForm));
            this.InitializeComponent();

            this.chartThroughput.Series[0].Name = this.ResManager.GetString("ChartTotalRead");
            this.chartThroughput.Series[1].Name = this.ResManager.GetString("ChartTotalWritten");
            this.chartThroughput.Series[2].Name = this.ResManager.GetString("ChartWorkTime");

            this.chartThroughput.Series[0].ToolTip = this.ResManager.GetString("ChartTotalReadToolTip");
            this.chartThroughput.Series[1].ToolTip = this.ResManager.GetString("ChartTotalWrittenToolTip");
            this.chartThroughput.Series[2].ToolTip = this.ResManager.GetString("ChartWorkTimeToolTip");

            this.chartThroughput.Series[0].LabelToolTip = this.ResManager.GetString("ChartTotalReadToolTip");
            this.chartThroughput.Series[1].LabelToolTip = this.ResManager.GetString("ChartTotalWrittenToolTip");
            this.chartThroughput.Series[2].LabelToolTip = this.ResManager.GetString("ChartWorkTimeToolTip");

            this.chartThroughput.ChartAreas[0].AxisY.Title = this.ResManager.GetString("ChartTotalReadAndWritten");
            this.chartThroughput.ChartAreas[0].AxisY2.Title = this.ResManager.GetString("ChartWorkTime");
        }
        #endregion

        #region 窗体事件
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.hddController.Load();
        }

        private void cbHDDNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.hddController.SelectedIndex = this.cbHDDNames.SelectedIndex;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.hddController.Refresh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuShowMarker_Click(object sender, EventArgs e)
        {
            this.chartThroughput.Series[0].ChartType = (this.mnuShowMarker.Checked ? SeriesChartType.Line : SeriesChartType.FastLine);
            this.chartThroughput.Series[1].ChartType = (this.mnuShowMarker.Checked ? SeriesChartType.Line : SeriesChartType.FastLine);
            this.chartThroughput.Series[2].ChartType = (this.mnuShowMarker.Checked ? SeriesChartType.Line : SeriesChartType.FastLine);
        }
        #endregion

        #region 控制器事件
        private void hddController_HDDListChanged(object sender, EventArgs e)
        {
            this.cbHDDNames.Items.Clear();
            this.cbHDDNames.Items.AddRange(this.hddController.HDDModels);

            if (this.cbHDDNames.Items.Count > 0)
            {
                this.cbHDDNames.SelectedIndex = this.hddController.SelectedIndex;
            }
        }

        private void hddController_SelectedHDDChanged(object sender, EventArgs e)
        {
            HDDInfo info = this.hddController.SelectedHDDInfo;
            HDDHistoryStatus hs = this.hddController.SelectedHDDHistoryStatus;

            if (info != null)
            {
                this.ShowHDDInfo(info);
                this.ShowHDDThroughput(info, hs);
                this.ShowHDDSmart(info);
                this.ShowHDDGrapgh(hs);
            }
        }
        #endregion

        #region ShowHDDInfo
        private void ShowHDDInfo(HDDInfo info)
        {
            this.Text = String.Format("SSDMonitor - {0}", info.Model);
            this.lblHDDModel.Text = String.Format(this.ResManager.GetString("HDDModelNameFormat"), info.Model, info.FirmwareRevision);
            this.lblHDDSerial.Text = String.Format(this.ResManager.GetString("HDDSerialFormat"), info.Serial);
            this.lblHDDSize.Text = String.Format(this.ResManager.GetString("HDDSizeFormat"), (info.Size / 1024.0 / 1024.0 / 1024.0).ToString("F2"));
            this.lblHDDWorktime.Text = String.Format(this.ResManager.GetString("HDDWorktimeHoursFormat"), info.WorkTime.ToString("F0"));
            this.lblHDDPoweronTimes.Text = String.Format(this.ResManager.GetString("HDDPoweredonFormat"), info.PoweredOnTimes);
            this.lblHDDHealth.Text = String.Format(this.ResManager.GetString("HDDHealthFormat"), info.HealthPercent.ToString(), info.Status);

            if (info.WorkTime > 24)
            {
                TimeSpan workTime = new TimeSpan(info.WorkTime, 0, 0);

                if (workTime.TotalHours > 30 * 24)
                {
                    Int32 months = (Int32)(workTime.TotalDays / 30);
                    this.lblHDDWorktime.Text += String.Format(this.ResManager.GetString("HDDWorktimeDateFormat(>30*24)"), months.ToString(), (workTime.TotalDays - months * 30).ToString("F0"), workTime.Hours);
                }
                else
                {
                    this.lblHDDWorktime.Text += String.Format(this.ResManager.GetString("HDDWorktimeDateFormat(>24,<=30*24)"), workTime.TotalDays.ToString("F0"), workTime.Hours);
                }
            }
        }
        #endregion

        #region ShowHDDThroughput
        private void ShowHDDThroughput(HDDInfo info, HDDHistoryStatus hs)
        {
            this.lblThroughputTotalRead.Text = this.GetThroughputString(info.TotalRead);
            this.lblThroughputTotalWritten.Text = this.GetThroughputString(info.TotalWritten);

            if (hs != null && hs.TodayThroughput != null)
            {
                this.lblThroughputTodayRead.Text = this.GetThroughputString(hs.TodayThroughput.ReadCount);
                this.lblThroughputTodayWritten.Text = this.GetThroughputString(hs.TodayThroughput.WrittenCount);
            }
            else
            {
                this.lblThroughputTodayRead.Text = "-";
                this.lblThroughputTodayWritten.Text = "-";
            }

            if (hs != null && hs.YesterdayThroughput != null)
            {
                this.lblThroughputYesterdayRead.Text = this.GetThroughputString(hs.YesterdayThroughput.ReadCount);
                this.lblThroughputYesterdayWritten.Text = this.GetThroughputString(hs.YesterdayThroughput.WrittenCount);
            }
            else
            {
                this.lblThroughputYesterdayRead.Text = "-";
                this.lblThroughputYesterdayWritten.Text = "-";
            }

            if (hs != null && hs.LastSevenDaysThroughput != null)
            {
                this.lblThroughputLast7DaysRead.Text = this.GetThroughputString(hs.LastSevenDaysThroughput.ReadCount);
                this.lblThroughputLast7DaysWritten.Text = this.GetThroughputString(hs.LastSevenDaysThroughput.WrittenCount);
            }
            else
            {
                this.lblThroughputLast7DaysRead.Text = "-";
                this.lblThroughputLast7DaysWritten.Text = "-";
            }

            if (hs != null && hs.LastThirtyDaysThroughput != null)
            {
                this.lblThroughputLast30DaysRead.Text = this.GetThroughputString(hs.LastThirtyDaysThroughput.ReadCount);
                this.lblThroughputLast30DaysWritten.Text = this.GetThroughputString(hs.LastThirtyDaysThroughput.WrittenCount);
            }
            else
            {
                this.lblThroughputLast30DaysRead.Text = "-";
                this.lblThroughputLast30DaysWritten.Text = "-";
            }
        }

        private String GetThroughputString(Int32 count)
        {
            return String.Format("{0}.0", count.ToString());
        }
        #endregion

        #region ShowHDDSmart
        private void ShowHDDSmart(HDDInfo info)
        {
            this.smartView.Clear();

            Int32 index = 0;
            foreach (SmartInfo item in info)
            {
                this.smartView.Add(item, index++);
            }
        }
        #endregion

        #region ShowGrapgh
        private void ShowHDDGrapgh(HDDHistoryStatus hs)
        {
            if (hs != null)
            {
                this.chartThroughput.Series[0].Points.DataBind(hs.AllTotalRead, "Key", "Value", "");
                this.chartThroughput.Series[1].Points.DataBind(hs.AllTotalWritten, "Key", "Value", "");
                this.chartThroughput.Series[2].Points.DataBind(hs.AllWorkTime, "Key", "Value", "");
            }
        }
        #endregion
    }
}