using System;
using System.Xml.Serialization;

namespace DotMaysWind.SSDMonitor.Storage
{
    /// <summary>
    /// 硬盘S.M.A.R.T信息项说明
    /// </summary>
    [Serializable]
    [XmlRoot("SmartInfo")]
    public class SmartInfo
    {
        #region 属性
        /// <summary>
        /// 获取或设置硬盘S.M.A.R.T信息ID
        /// </summary>
        [XmlElement("ID")]
        public Int32 ID { get; set; }

        /// <summary>
        /// 获取或设置硬盘S.M.A.R.T信息名称
        /// </summary>
        [XmlElement("Name")]
        public String Name { get; set; }

        /// <summary>
        /// 获取或设置硬盘S.M.A.R.T信息更好者类型
        /// </summary>
        [XmlElement("Better")]
        public String Better { get; set; }

        /// <summary>
        /// 获取或设置硬盘S.M.A.R.T信息描述信息
        /// </summary>
        [XmlElement("Description")]
        public String Description { get; set; }
        #endregion
    }
}