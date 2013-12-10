using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using DotMaysWind.SSDMonitor.Controller;
using DotMaysWind.SSDMonitor.Hardware;
using DotMaysWind.SSDMonitor.Storage;

namespace DotMaysWind.SSDMonitor
{
    public partial class MainForm : Form
    {
        #region 构造方法
        public MainForm()
        {
            this.InitializeComponent();
        }
        #endregion

        #region 窗体事件
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.smartInfoController.Load();
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
            this.lblHDDModel.Text = String.Format("{0} (Fw: {1})", info.Model, info.FirmwareRevision);
            this.lblHDDSerial.Text = String.Format("Serial: {0}", info.Serial);
            this.lblHDDWorktime.Text = String.Format("Worktime: {0} hour{1}", info.WorkTime.ToString("F0"), (info.WorkTime > 1 ? "s" : ""));
            this.lblHDDPoweronTimes.Text = String.Format("Powered on: {0} time{1}", info.PoweredOnTimes, (info.PoweredOnTimes > 1 ? "s" : ""));
            this.lblHDDHealth.Text = String.Format("Health: {0}% ({1})", info.HealthPercent.ToString(), info.Status);

            if (info.WorkTime > 24)
            {
                TimeSpan workTime = new TimeSpan(info.WorkTime, 0, 0);

                if (workTime.TotalHours > 30 * 24)
                {
                    Int32 months = (Int32)(workTime.TotalDays / 30);
                    this.lblHDDWorktime.Text += String.Format(" ({0} months {1} days {2} hours)", months.ToString(), (workTime.TotalDays - months * 30).ToString("F0"), workTime.Hours);
                }
                else
                {
                    this.lblHDDWorktime.Text += String.Format(" ({0} days {1} hours)", workTime.TotalDays.ToString("F0"), workTime.Hours);
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
            this.lvSmart.Items.Clear();

            Int32 index = 0;
            foreach (HDDSmart item in info)
            {
                ListViewItem viewItem = new ListViewItem(new String[] { 
                    item.ID.ToString("X2"), //ID
                    this.smartInfoController.GetSmartName(item.ID), //属性名称
                    item.Current.ToString(), //当前值
                    item.Worst.ToString(), //最差值
                    item.Threshold.ToString(), //临界值
                    String.Format("{0} [{1}]", item.RawData.ToString(), item.RawData.ToString("X8")), //原始数据
                    item.IsStatusOK ? "OK" : "BAD" }); //状态

                if ((index++ & 1) == 1)
                {
                    viewItem.BackColor = Color.FromArgb(0xF8, 0xF8, 0xF8);
                }

                if (!item.IsStatusOK)
                {
                    viewItem.BackColor = Color.FromArgb(0xFF, 0xFF, 0x80);
                }

                this.lvSmart.Items.Add(viewItem);
            }
        }
        #endregion

        #region ShowGrapgh
        private void ShowHDDGrapgh(HDDHistoryStatus hs)
        {
            this.chartThroughput.Series["TotalRead"].Points.DataBind(hs.AllTotalRead, "Key", "Value", "");
            this.chartThroughput.Series["TotalWritten"].Points.DataBind(hs.AllTotalWritten, "Key", "Value", "");
            this.chartThroughput.Series["WorkTime"].Points.DataBind(hs.AllWorkTime, "Key", "Value", "");
        }
        #endregion
    }
}