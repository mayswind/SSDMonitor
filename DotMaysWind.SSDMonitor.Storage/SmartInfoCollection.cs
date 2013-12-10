using System;
using System.Collections.Generic;
using System.Xml.Serialization;

using DotMaysWind.SSDMonitor.Storage.Helper;

namespace DotMaysWind.SSDMonitor.Storage
{
    /// <summary>
    /// 硬盘S.M.A.R.T信息项说明集合
    /// </summary>
    [Serializable]
    [XmlRoot("SSDMonitor")]
    public class SmartInfoCollection
    {
        #region 字段
        private List<SmartInfo> _smartInfos;
        #endregion

        #region 属性
        /// <summary>
        /// 获取或设置所有硬盘S.M.A.R.T信息项说明
        /// </summary>
        [XmlArray("SmartInfos")]
        [XmlArrayItem("SmartInfo")]
        public List<SmartInfo> AllSmartInfos
        {
            get { return this._smartInfos; }
            set { this._smartInfos = value; }
        }
        #endregion

        #region 索引器
        /// <summary>
        /// 获取指定ID的硬盘S.M.A.R.T信息项说明
        /// </summary>
        /// <param name="id">S.M.A.R.T索引</param>
        /// <returns>S.M.A.R.T信息项说明</returns>
        public SmartInfo this[Int32 id]
        {
            get
            {
                for (Int32 i = 0; i < this._smartInfos.Count; i++)
                {
                    if (this._smartInfos[i].ID == id)
                    {
                        return this._smartInfos[i];
                    }
                }

                return null;
            }
        }
        #endregion

        #region 构造方法
        /// <summary>
        /// 初始化新的SSDMonitor配置文件
        /// </summary>
        public SmartInfoCollection()
        {
            this._smartInfos = new List<SmartInfo>();
        }
        #endregion

        #region 静态方法
        /// <summary>
        /// 从文件中读取SSDMonitor配置文件
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <returns>SSDMonitor配置文件</returns>
        public static SmartInfoCollection LoadFromFile(String filePath)
        {
            return SerializationHelper.LoadFromFile<SmartInfoCollection>(filePath);
        }
        #endregion
    }
}