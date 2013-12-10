using System;

namespace DotMaysWind.SSDMonitor.Storage
{
    /// <summary>
    /// 使用量对
    /// </summary>
    public class ThroughputPair
    {
        #region 字段
        private Int32 _readCount;
        private Int32 _writtenCount;
        #endregion

        #region 属性
        /// <summary>
        /// 获取读取数量
        /// </summary>
        public Int32 ReadCount
        {
            get { return this._readCount; }
        }

        /// <summary>
        /// 获取写入数量
        /// </summary>
        public Int32 WrittenCount
        {
            get { return this._writtenCount; }
        }
        #endregion

        #region 构造方法
        /// <summary>
        /// 初始化新的使用量对
        /// </summary>
        /// <param name="readCount">读取数量</param>
        /// <param name="writtenCount">写入数量</param>
        internal ThroughputPair(Int32 readCount, Int32 writtenCount)
        {
            this._readCount = readCount;
            this._writtenCount = writtenCount;
        }

        /// <summary>
        /// 初始化新的使用量对
        /// </summary>
        /// <param name="currentStatus">当前硬盘状态</param>
        /// <param name="prevStatus">上一次硬盘状态</param>
        internal ThroughputPair(HDDStatus currentStatus, HDDStatus prevStatus)
        {
            this._readCount = currentStatus.TotalRead - prevStatus.TotalRead;
            this._writtenCount = currentStatus.TotalWritten - prevStatus.TotalWritten;
        }
        #endregion
    }
}