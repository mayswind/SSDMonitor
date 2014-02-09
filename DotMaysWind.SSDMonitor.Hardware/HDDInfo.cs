using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace DotMaysWind.SSDMonitor.Hardware
{
    /// <summary>
    /// 硬盘信息实体
    /// </summary>
    public class HDDInfo : IEnumerable<SmartInfo>, ICollection<SmartInfo>
    {
        #region 字段
        private readonly String _model;
        private readonly String _type;
        private readonly String _serial;
        private readonly String _firmwareRevision;
        private readonly UInt64 _size;
        private readonly String _status;
        private Dictionary<Int32, SmartInfo> _smartInfos;
        #endregion

        #region 属性
        /// <summary>
        /// 获取硬盘型号
        /// </summary>
        public String Model
        {
            get { return this._model; }
        }

        /// <summary>
        /// 获取硬盘类型
        /// </summary>
        public String Type
        {
            get { return this._type; }
        }

        /// <summary>
        /// 获取硬盘序列号
        /// </summary>
        public String Serial
        {
            get { return this._serial; }
        }

        /// <summary>
        /// 获取硬盘固件版本
        /// </summary>
        public String FirmwareRevision
        {
            get { return this._firmwareRevision; }
        }

        /// <summary>
        /// 获取硬盘大小
        /// </summary>
        public UInt64 Size
        {
            get { return this._size; }
        }

        /// <summary>
        /// 获取硬盘状态
        /// </summary>
        public String Status
        {
            get { return this._status; }
        }

        /// <summary>
        /// 获取硬盘工作时间
        /// </summary>
        public Int32 WorkTime
        {
            get { return this.GetSmartRawData(0x09); }
        }

        /// <summary>
        /// 获取硬盘加电次数
        /// </summary>
        public Int32 PoweredOnTimes
        {
            get { return this.GetSmartRawData(0x0C); }
        }

        /// <summary>
        /// 获取健康百分比
        /// </summary>
        public Int32 HealthPercent
        {
            get { return this.GetSmartRawData(0xE6); }
        }

        /// <summary>
        /// 获取硬盘总读取GB数
        /// </summary>
        public Int32 TotalRead
        {
            get { return this.GetSmartRawData(0xF2); }
        }

        /// <summary>
        /// 获取硬盘总写入GB数
        /// </summary>
        public Int32 TotalWritten
        {
            get { return this.GetSmartRawData(0xF1); }
        }
        #endregion

        #region 索引器
        /// <summary>
        /// 获取指定ID的硬盘S.M.A.R.T信息项
        /// </summary>
        /// <param name="id">S.M.A.R.T ID</param>
        /// <returns>硬盘S.M.A.R.T信息项</returns>
        public SmartInfo this[Int32 id]
        {
            get { return this._smartInfos.ContainsKey(id) ? this._smartInfos[id] : null; }
        }
        #endregion

        #region 构造方法
        /// <summary>
        /// 初始化新的硬盘信息实体
        /// </summary>
        /// <param name="drive">ManagementObject</param>
        public HDDInfo(ManagementObject drive)
        {
            this._model = this.GetInformation(drive["Model"]);
            this._type = this.GetInformation(drive["InterfaceType"]);
            this._serial = this.GetInformation(drive["SerialNumber"]);
            this._firmwareRevision = this.GetInformation(drive["FirmwareRevision"]);
            this._size = this.GetInformation<UInt64>(drive["Size"]); ;

            this._status = this.GetInformation(drive["Status"]);
            this._smartInfos = new Dictionary<Int32, SmartInfo>();
        }
        #endregion

        #region 内部方法
        /// <summary>
        /// 添加硬盘S.M.A.R.T信息
        /// </summary>
        /// <param name="item">S.M.A.R.T信息项</param>
        internal void AddSmartInfo(SmartInfo item)
        {
            if (item == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                this._smartInfos[item.ID] = item;
            }
        }
        #endregion

        #region 方法
        /// <summary>
        /// 获取当前类名称及硬盘型号信息
        /// </summary>
        /// <returns>当前类名称及硬盘型号信息</returns>
        public override String ToString()
        {
            return String.Format("DotMaysWind.SSDMonitor.Hardware.HDDInfo, {0}", this._model);
        }
        #endregion

        #region 接口方法
        #region IEnumerable
        IEnumerator<SmartInfo> IEnumerable<SmartInfo>.GetEnumerator()
        {
            return this._smartInfos.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this._smartInfos.Values.GetEnumerator();
        }
        #endregion

        #region ICollection
        public Int32 Count
        {
            get { return this._smartInfos.Count; }
        }

        Boolean ICollection<SmartInfo>.IsReadOnly
        {
            get { return false; }
        }

        void ICollection<SmartInfo>.Add(SmartInfo item)
        {
            if (item == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                this._smartInfos[item.ID] = item;
            }
        }

        void ICollection<SmartInfo>.Clear()
        {
            this._smartInfos.Clear();
        }

        Boolean ICollection<SmartInfo>.Contains(SmartInfo item)
        {
            return this._smartInfos.ContainsValue(item);
        }

        void ICollection<SmartInfo>.CopyTo(SmartInfo[] array, Int32 arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if ((array != null) && (array.Rank != 1))
            {
                throw new ArgumentException();
            }

            Int32 index = arrayIndex;
            foreach (KeyValuePair<Int32, SmartInfo> pair in this._smartInfos)
            {
                array[index++] = pair.Value;
            }
        }

        Boolean ICollection<SmartInfo>.Remove(SmartInfo item)
        {
            if (item == null)
            {
                return false;   
            }
            else
            {
                return this._smartInfos.Remove(item.ID);
            }
        }
        #endregion
        #endregion

        #region 私有方法
        private T GetInformation<T>(Object info)
        {
            return (info == null ? default(T) : (T)info);
        }

        private String GetInformation(Object info)
        {
            String result = info as String;

            return (String.IsNullOrEmpty(result) ? "Unknown" : result.Trim());
        }

        private Int32 GetSmartRawData(Int32 smartID)
        {
            SmartInfo smartInfo = this[smartID];
            return (smartInfo == null ? 0 : smartInfo.RawData);
        }
        #endregion
    }
}