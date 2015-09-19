using System;

namespace DotMaysWind.SSDMonitor.Controller
{
    /// <summary>
    /// 硬盘列表变化事件
    /// </summary>
    public delegate void HDDListChangedHandler(Object sender, EventArgs e);

    /// <summary>
    /// 硬盘选择变化事件
    /// </summary>
    public delegate void SelectedHDDChangedHandler(Object sender, EventArgs e);
}