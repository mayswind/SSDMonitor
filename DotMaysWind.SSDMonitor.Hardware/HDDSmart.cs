﻿using System;

namespace DotMaysWind.SSDMonitor.Hardware
{
    /// <summary>
    /// 硬盘S.M.A.R.T信息项实体
    /// </summary>
    public class HDDSmart
    {
        #region 字段
        private readonly Int32 _id;
        private readonly Int32 _current;
        private readonly Int32 _worst;
        private readonly Int32 _rawData;
        private readonly Boolean _status;
        private Int32 _threshold;
        #endregion

        #region 属性
        /// <summary>
        /// 获取硬盘S.M.A.R.T信息项ID
        /// </summary>
        public Int32 ID
        {
            get { return this._id; }
        }

        /// <summary>
        /// 获取硬盘S.M.A.R.T信息当前值
        /// </summary>
        public Int32 Current
        {
            get { return this._current; }
        }

        /// <summary>
        /// 获取硬盘S.M.A.R.T信息最差值
        /// </summary>
        public Int32 Worst
        {
            get { return this._worst; }
        }

        /// <summary>
        /// 获取硬盘S.M.A.R.T信息临界值
        /// </summary>
        public Int32 Threshold
        {
            get { return this._threshold; }
        }

        /// <summary>
        /// 获取硬盘S.M.A.R.T信息原始数据 
        /// </summary>
        public Int32 RawData
        {
            get { return this._rawData; }
        }

        /// <summary>
        /// 获取硬盘S.M.A.R.T信息状态是否正常
        /// </summary>
        public Boolean IsStatusOK
        {
            get { return this._status; }
        }

        /// <summary>
        /// 获取是否硬盘S.M.A.R.T信息包含数据
        /// </summary>
        public Boolean HasData
        {
            get { return (this._current != 0 || this._worst != 0 || this._threshold != 0 || this._rawData != 0); }
        }
        #endregion

        #region 构造方法
        /// <summary>
        /// 初始化新的硬盘S.M.A.R.T信息项
        /// </summary>
        /// <param name="id">S.M.A.R.T ID</param>
        /// <param name="current">S.M.A.R.T 当前值</param>
        /// <param name="worst">S.M.A.R.T 最差值</param>
        /// <param name="threshold">S.M.A.R.T 临界值</param>
        /// <param name="rawData">S.M.A.R.T 原始数据</param>
        /// <param name="status">S.M.A.R.T 是否正常</param>
        public HDDSmart(Int32 id, Int32 current, Int32 worst, Int32 rawData, Boolean status)
        {
            this._id = id;
            this._current = current;
            this._worst = worst;
            this._rawData = rawData;
            this._status = status;
        }
        #endregion

        #region 内部方法
        /// <summary>
        /// 设置硬盘S.M.A.R.T信息临界值
        /// </summary>
        /// <param name="threshold">硬盘S.M.A.R.T信息临界值</param>
        internal void InternalSetThreshold(Int32 threshold)
        {
            this._threshold = threshold;
        }
        #endregion
    }
}