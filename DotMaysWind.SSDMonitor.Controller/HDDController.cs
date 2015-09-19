using System;
using System.ComponentModel;

using DotMaysWind.SSDMonitor.Hardware;
using DotMaysWind.SSDMonitor.Storage;

namespace DotMaysWind.SSDMonitor.Controller
{
    /// <summary>
    /// 硬盘信息控制器
    /// </summary>
    public class HDDController : Component
    {
        #region 字段
        private HDDInfo[] _hddInfos;
        private HDDHistoryStatus[] _hddHistorys;
        private String[] _hddModels;
        private Int32 _currentIndex;
        #endregion

        #region 事件
        public event HDDListChangedHandler HDDListChanged;
        public event SelectedHDDChangedHandler SelectedHDDChanged;
        #endregion

        #region 属性
        /// <summary>
        /// 获取所有硬盘型号
        /// </summary>
        [Browsable(false)]
        public String[] HDDModels
        {
            get
            {
                return this._hddModels;
            }
        }

        /// <summary>
        /// 获取或设置当前选择的索引
        /// </summary>
        [Browsable(false)]
        public Int32 SelectedIndex
        {
            get { return this._currentIndex; }
            set
            {
                if (this._hddInfos.Length > 0 && this._currentIndex != value && value >= 0 && value < this._hddInfos.Length)
                {
                    this._currentIndex = value;

                    if (SelectedHDDChanged != null)
                    {
                        this.SelectedHDDChanged(this, new EventArgs());
                    }
                }
            }
        }

        /// <summary>
        /// 获取当前选择的硬盘信息
        /// </summary>
        [Browsable(false)]
        public HDDInfo SelectedHDDInfo
        {
            get
            {
                return (this._hddInfos.Length > 0 ? this._hddInfos[this._currentIndex] : null);
            }
        }

        /// <summary>
        /// 获取当前选择的硬盘状态信息
        /// </summary>
        [Browsable(false)]
        public HDDHistoryStatus SelectedHDDHistoryStatus
        {
            get
            {
                return (this._hddHistorys.Length > 0 ? this._hddHistorys[this._currentIndex] : null);
            }
        }
        #endregion

        #region 构造方法
        /// <summary>
        /// 初始化新的硬盘信息控制器
        /// </summary>
        public HDDController()
        {
            this._hddInfos = new HDDInfo[0];
            this._hddHistorys = new HDDHistoryStatus[0];
            this._hddModels = new String[0];
        }
        #endregion

        #region 方法
        /// <summary>
        /// 初始化硬件信息
        /// </summary>
        public void Load()
        {
            this.LoadHardwareInformation(true);
        }

        /// <summary>
        /// 刷新硬件信息
        /// </summary>
        public void Refresh()
        {
            this.LoadHardwareInformation(false);
        }
        #endregion

        #region 私有方法
        private void LoadHardwareInformation(Boolean firstInit)
        {
            this._hddInfos = HDDInfoManager.GetHDDInfoList();
            this._hddHistorys = new HDDHistoryStatus[this._hddInfos.Length];
            this._hddModels = new String[this._hddInfos.Length];

            if (firstInit || this._currentIndex < 0 || this._currentIndex >= this._hddInfos.Length)
            {
                this._currentIndex = 0;
            }

            for (Int32 i = 0; i < this._hddInfos.Length; i++)
            {
                HDDInfo info = this._hddInfos[i];

                this._hddHistorys[i] = (info.Count >= 0 ? HDDHistoryStatus.ReadFromFile(info) : null);
                this._hddModels[i] = info.Model;
            }

            if (this.HDDListChanged != null)
            {
                this.HDDListChanged(this, new EventArgs());
            }

            if (this.SelectedHDDChanged != null)
            {
                this.SelectedHDDChanged(this, new EventArgs());
            }
        }
        #endregion
    }
}