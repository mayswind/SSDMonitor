using System;
using System.Collections;
using System.Collections.Generic;

using DotMaysWind.SSDMonitor.Hardware;
using DotMaysWind.SSDMonitor.Storage.Helper;

namespace DotMaysWind.SSDMonitor.Storage
{
    /// <summary>
    /// 硬盘历史状态信息
    /// </summary>
    public class HDDHistoryStatus
    {
        #region 常量
        /// <summary>
        /// 最小记录间隔(分钟)
        /// </summary>
        private const Int32 MinLogInterval = 60;
        #endregion

        #region 字段
        private String _serial;
        private Dictionary<DateTime, Int32> _workTimeHistory;
        //private Dictionary<DateTime, Int32> _poweredOnHistory;
        private Dictionary<DateTime, Int32> _totalReadHistory;
        private Dictionary<DateTime, Int32> _totalWrittenHistory;
        private HDDStatus _lastStatus;
        private ThroughputPair _todayThroughput;
        private ThroughputPair _yesterdayThroughput;
        private ThroughputPair _lastSevenDaysThroughput;
        private ThroughputPair _lastThirtyDaysThroughput;
        #endregion

        #region 属性
        /// <summary>
        /// 获取当前硬盘序列号
        /// </summary>
        public String Serial
        {
            get { return this._serial; }
        }

        /// <summary>
        /// 获取硬盘状态信息总数
        /// </summary>
        public Int32 Count
        {
            get { return this._workTimeHistory.Count; }
        }

        /// <summary>
        /// 获取所有硬盘工作时间数据
        /// </summary>
        public Dictionary<DateTime, Int32> AllWorkTime
        {
            get { return this._workTimeHistory; }
        }

        /// <summary>
        /// 获取所有硬盘加电数据
        /// </summary>
        /*public Dictionary<DateTime, Int32> AllPoweredOn
        {
            get { return this._poweredOnHistory; }
        }*/

        /// <summary>
        /// 获取所有硬盘读取数据
        /// </summary>
        public Dictionary<DateTime, Int32> AllTotalRead
        {
            get { return this._totalReadHistory; }
        }

        /// <summary>
        /// 获取所有硬盘写入数据
        /// </summary>
        public Dictionary<DateTime, Int32> AllTotalWritten
        {
            get { return this._totalWrittenHistory; }
        }

        /// <summary>
        /// 获取当日使用量对
        /// </summary>
        public ThroughputPair TodayThroughput
        {
            get { return this._todayThroughput; }
        }

        /// <summary>
        /// 获取前日使用量对
        /// </summary>
        public ThroughputPair YesterdayThroughput
        {
            get { return this._yesterdayThroughput; }
        }

        /// <summary>
        /// 获取最近七天使用量对
        /// </summary>
        public ThroughputPair LastSevenDaysThroughput
        {
            get { return this._lastSevenDaysThroughput; }
        }

        /// <summary>
        /// 获取最近三十天使用量对
        /// </summary>
        public ThroughputPair LastThirtyDaysThroughput
        {
            get { return this._lastThirtyDaysThroughput; }
        }
        #endregion

        #region 构造方法
        /// <summary>
        /// 初始化空的硬盘历史状态信息
        /// </summary>
        /// <param name="serial">硬盘序列号</param>
        private HDDHistoryStatus(String serial)
        {
            this._serial = serial;
            this._workTimeHistory = new Dictionary<DateTime, Int32>();
            //this._poweredOnHistory = new Dictionary<DateTime, Int32>();
            this._totalReadHistory = new Dictionary<DateTime, Int32>();
            this._totalWrittenHistory = new Dictionary<DateTime, Int32>();
        }
        #endregion

        #region 私有方法
        private void AppendStatus(HDDStatus newStatus)
        {
            TimeSpan ts = (this._lastStatus != null ? new TimeSpan(newStatus.RecordTime - this._lastStatus.RecordTime) : TimeSpan.MaxValue);

            if (ts.TotalMinutes > MinLogInterval || (this._lastStatus != null && (newStatus.TotalWritten > this._lastStatus.TotalWritten || newStatus.TotalRead > this._lastStatus.TotalRead)))
            {
                this.AddStatus(newStatus);
                UserDataHelper.AppendHDDHistoryStatus(this._serial, newStatus.GetLogInformation());
            }
        }

        private void AddStatus(HDDStatus newStatus)
        {
            DateTime dt = new DateTime(newStatus.RecordTime);

            this._workTimeHistory[dt] = newStatus.WorkTime;
            //this._poweredOnHistory[dt] = newStatus.PoweredTimes;
            this._totalReadHistory[dt] = newStatus.TotalRead;
            this._totalWrittenHistory[dt] = newStatus.TotalWritten;

            this._lastStatus = newStatus;
        }
        #endregion

        #region 静态方法
        /// <summary>
        /// 根据硬盘序列号读取硬盘历史状态信息
        /// </summary>
        /// <param name="info">硬盘信息</param>
        /// <returns>硬盘历史状态信息</returns>
        public static HDDHistoryStatus ReadFromFile(HDDInfo info)
        {
            HDDHistoryStatus hs = new HDDHistoryStatus(info.Serial);
            String[] log = UserDataHelper.ReadHDDHistoryStatus(info.Serial);
            
            if (log == null || log.Length <= 0)
            {
                return hs;
            }

            Int64 todayFirstTicks = DateTime.Today.Ticks;
            Int64 yesterdayFirstTicks = DateTime.Today.AddDays(-1).Ticks;
            Int64 lastSevenDaysFirstTicks = DateTime.Today.AddDays(-7).Ticks;
            Int64 lastThirtyDaysFirstTicks = DateTime.Today.AddDays(-30).Ticks;

            HDDStatus todayFirstStatus = null;
            HDDStatus yesterdayFirstStatus = null;
            HDDStatus lastSevenDaysFirstStatus = null;
            HDDStatus lastThirtyDaysFirstStatus = null;
            
            for (Int32 i = 0 ; i < log.Length; i++)
            {
                HDDStatus status = HDDStatus.ReadFromLogInformation(log[i]);

                if (status != null)
                {
                    hs.AddStatus(status);

                    if (lastThirtyDaysFirstStatus == null && status.RecordTime >= lastThirtyDaysFirstTicks)
                    {
                        lastThirtyDaysFirstStatus = status;
                    }

                    if (lastSevenDaysFirstStatus == null && status.RecordTime >= lastSevenDaysFirstTicks)
                    {
                        lastSevenDaysFirstStatus = status;
                    }

                    if (yesterdayFirstStatus == null && status.RecordTime >= yesterdayFirstTicks && status.RecordTime < todayFirstTicks)
                    {
                        yesterdayFirstStatus = status;
                    }

                    if (todayFirstStatus == null && status.RecordTime >= todayFirstTicks)
                    {
                        todayFirstStatus = status;
                    }
                }
            }

            HDDStatus newStatus = HDDStatus.CreateNewStatus(info);
            hs._todayThroughput = new ThroughputPair(newStatus, (todayFirstStatus != null ? todayFirstStatus : newStatus));
            
            if (yesterdayFirstStatus != null)
            {
                hs._yesterdayThroughput = new ThroughputPair((todayFirstStatus != null ? todayFirstStatus : newStatus), yesterdayFirstStatus);
            }

            if (lastSevenDaysFirstStatus != null)
            {
                hs._lastSevenDaysThroughput = new ThroughputPair(newStatus, lastSevenDaysFirstStatus);
            }

            if (lastThirtyDaysFirstStatus != null)
            {
                hs._lastThirtyDaysThroughput = new ThroughputPair(newStatus, lastThirtyDaysFirstStatus);
            }

            hs.AppendStatus(newStatus);

            return hs;
        }
        #endregion
    }
}