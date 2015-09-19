using System;

using DotMaysWind.SSDMonitor.Hardware;

namespace DotMaysWind.SSDMonitor.Storage
{
    /// <summary>
    /// 硬盘状态类
    /// </summary>
    public class HDDStatus
    {
        #region 字段
        private Int64 _recordTime;
        private Int32 _workTime;
        private Int32 _poweredTimes;
        private Int32 _totalRead;
        private Int32 _totalWritten;
        #endregion

        #region 属性
        /// <summary>
        /// 获取记录时间
        /// </summary>
        public Int64 RecordTime
        {
            get { return this._recordTime; }
        }

        /// <summary>
        /// 获取硬盘工作时间
        /// </summary>
        public Int32 WorkTime
        {
            get { return this._workTime; }
        }

        /// <summary>
        /// 获取硬盘通电次数
        /// </summary>
        public Int32 PoweredTimes
        {
            get { return this._poweredTimes; }
        }

        /// <summary>
        /// 获取固态硬盘总读取GB数
        /// </summary>
        public Int32 TotalRead
        {
            get { return this._totalRead; }
        }

        /// <summary>
        /// 获取固态硬盘总写入GB数
        /// </summary>
        public Int32 TotalWritten
        {
            get { return this._totalWritten; }
        }
        #endregion

        #region 构造方法
        /// <summary>
        /// 初始化新的硬盘状态类
        /// </summary>
        /// <param name="recordTime">当前时间</param>
        /// <param name="workTime">硬盘工作时间</param>
        /// <param name="poweredTimes">硬盘加电次数</param>
        /// <param name="totalRead">硬盘总共读取GB数</param>
        /// <param name="totalWritten">硬盘总共写入GB数</param>
        private HDDStatus(Int64 recordTime, Int32 workTime, Int32 poweredTimes, Int32 totalRead, Int32 totalWritten)
        {
            this._recordTime = recordTime;
            this._workTime = workTime;
            this._poweredTimes = poweredTimes;
            this._totalRead = totalRead;
            this._totalWritten = totalWritten;
        }
        #endregion

        #region 内部方法
        /// <summary>
        /// 获取硬盘状态信息日志
        /// </summary>
        /// <returns>硬盘状态信息日志</returns>
        internal String GetLogInformation()
        {
            return String.Format("{0}\t{1}\t{2}\t{3}\t{4}",
                this._recordTime.ToString(),
                this._workTime.ToString(),
                this._poweredTimes.ToString(),
                this._totalRead.ToString(),
                this._totalWritten.ToString());
        }
        #endregion

        #region 静态方法
        /// <summary>
        /// 创建新的硬盘状态信息
        /// </summary>
        /// <param name="workTime">硬盘工作时间</param>
        /// <param name="poweredTimes">硬盘加电次数</param>
        /// <param name="totalRead">硬盘总共读取GB数</param>
        /// <param name="totalWritten">硬盘总共写入GB数</param>
        /// <returns>硬盘状态信息类</returns>
        public static HDDStatus CreateNewStatus(Int32 workTime, Int32 poweredTimes, Int32 totalRead, Int32 totalWritten)
        {
            return new HDDStatus(DateTime.Now.Ticks, workTime, poweredTimes, totalRead, totalWritten);
        }

        /// <summary>
        /// 创建新的硬盘状态信息
        /// </summary>
        /// <param name="info">硬盘信息实体</param>
        /// <returns>硬盘状态信息类</returns>
        public static HDDStatus CreateNewStatus(HDDInfo info)
        {
            return new HDDStatus(DateTime.Now.Ticks, info.WorkTime, info.PoweredOnTimes, info.TotalRead, info.TotalWritten);
        }

        /// <summary>
        /// 从日志中读取硬盘状态信息
        /// </summary>
        /// <param name="text">日志信息</param>
        /// <returns>硬盘状态信息类</returns>
        internal static HDDStatus ReadFromLogInformation(String text)
        {
            HDDStatus status = null;

            if (String.IsNullOrWhiteSpace(text))
            {
                return status;
            }

            String[] items = text.Split('\t');
            if (items.Length != 5)
            {
                return status;
            }

            try
            {
                status = new HDDStatus(Convert.ToInt64(items[0]), Convert.ToInt32(items[1]), Convert.ToInt32(items[2]), Convert.ToInt32(items[3]), Convert.ToInt32(items[4]));
            }
            catch
            {
                //Do nothing
            }

            return status;
        }
        #endregion
    }
}