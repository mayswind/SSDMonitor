using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

using DotMaysWind.SSDMonitor.Hardware;

namespace DotMaysWind.SSDMonitor
{
    public partial class SmartControl : UserControl
    {
        #region 字段
        private ComponentResourceManager ResManager;
        #endregion

        #region 构造方法
        public SmartControl()
        {
            this.ResManager = new ComponentResourceManager(typeof(SmartControl));
            this.InitializeComponent();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 添加新的硬盘S.M.A.R.T项
        /// </summary>
        /// <param name="item">硬盘S.M.A.R.T项</param>
        /// <param name="index">索引</param>
        public void Add(SmartInfo item, Int32 index)
        {
            String smartName = this.ResManager.GetString(item.ID.ToString("X2"));

            if (String.IsNullOrWhiteSpace(smartName))
            {
                smartName = this.ResManager.GetString(item.ID.ToString("X2"), CultureInfo.GetCultureInfo("en"));
            }

            if (String.IsNullOrWhiteSpace(smartName))
            {
                smartName = this.ResManager.GetString("Unknown");
            }

            ListViewItem viewItem = new ListViewItem(new String[] { 
                    item.ID.ToString("X2"), //ID
                    smartName, //属性名称
                    item.Current.ToString(), //当前值
                    item.Worst.ToString(), //最差值
                    item.Threshold.ToString(), //临界值
                    String.Format("{0} [{1}]", item.RawData.ToString(), item.RawData.ToString("X8")), //原始数据
                    this.ResManager.GetString(item.Status == SmartStatus.OK ? "OK" : "Bad") }); //状态

            if ((index & 1) == 1)
            {
                viewItem.BackColor = Color.FromArgb(0xF8, 0xF8, 0xF8);
            }

            if (item.Status != SmartStatus.OK)
            {
                viewItem.BackColor = Color.FromArgb(0xFF, 0xFF, 0x80);
            }

            this.lvSmart.Items.Add(viewItem);
        }

        /// <summary>
        /// 清空所有硬盘S.M.A.R.T项
        /// </summary>
        public void Clear()
        {
            this.lvSmart.Items.Clear();
        }
        #endregion
    }
}