using System;

namespace DotMaysWind.SSDMonitor.Hardware
{
    /// <summary>
    /// 硬盘S.M.A.R.T信息状态
    /// </summary>
    public enum SmartStatus : byte
    {
        /// <summary>
        /// 正常
        /// </summary>
        OK = 0,

        /// <summary>
        /// 警告
        /// </summary>
        Bad = 1
    }
}