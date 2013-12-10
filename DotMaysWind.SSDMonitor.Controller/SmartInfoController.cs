using System;
using System.Collections.Generic;
using System.ComponentModel;

using DotMaysWind.SSDMonitor.Storage;

namespace DotMaysWind.SSDMonitor.Controller
{
    /// <summary>
    /// 硬盘S.M.A.R.T信息控制器
    /// </summary>
    public class SmartInfoController : Component
    {
        #region 字段
        private SmartInfoCollection _smartCollection;
        private Dictionary<Int32, SmartInfo> _smartDictionary;
        #endregion

        #region 构造方法
        public SmartInfoController()
        {
            this._smartCollection = null;
            this._smartDictionary = new Dictionary<Int32, SmartInfo>();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 加载S.M.A.R.T信息
        /// </summary>
        public void Load()
        {
            this._smartCollection = SmartInfoCollection.LoadFromFile(@"DotMaysWind.SSDMonitor.SmartInfos.xml");
            this._smartDictionary = new Dictionary<Int32, SmartInfo>();

            if (this._smartCollection != null && this._smartCollection.AllSmartInfos != null)
            {
                for (Int32 i = 0; i < this._smartCollection.AllSmartInfos.Count; i++)
                {
                    this._smartDictionary[this._smartCollection.AllSmartInfos[i].ID] = this._smartCollection.AllSmartInfos[i];
                }
            }
        }

        /// <summary>
        /// 获取指定索引的S.M.A.R.T名称
        /// </summary>
        /// <param name="id">S.M.A.R.T索引</param>
        /// <returns>S.M.A.R.T名称</returns>
        public String GetSmartName(Int32 id)
        {
            SmartInfo value = null;
            return (this._smartDictionary.TryGetValue(id, out value) ? value.Name : "Unknown");
        }
        #endregion
    }
}