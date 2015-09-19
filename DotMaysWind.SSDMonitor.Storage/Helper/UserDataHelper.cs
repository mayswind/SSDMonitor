using System;
using System.IO;
using System.Text;

namespace DotMaysWind.SSDMonitor.Storage.Helper
{
    /// <summary>
    /// 用户数据辅助类
    /// </summary>
    internal static class UserDataHelper
    {
        #region 常量
        private static readonly Encoding DefaultEncoding = Encoding.UTF8;
        #endregion

        #region 内部方法
        /// <summary>
        /// 添加指定内容到硬盘历史状态文件
        /// </summary>
        /// <param name="serial">硬盘序列号</param>
        /// <param name="text">需要记录的内容</param>
        internal static void AppendHDDHistoryStatus(String serial, String text)
        {
            String filePath = GetHDDHistoryFilePath(serial);

            File.AppendAllText(filePath, text + Environment.NewLine, DefaultEncoding);
        }

        /// <summary>
        /// 获取指定硬盘历史状态文件内容
        /// </summary>
        /// <param name="serial">硬盘序列号</param>
        /// <returns>硬盘历史状态文件内容</returns>
        internal static String[] ReadHDDHistoryStatus(String serial)
        {
            String filePath = GetHDDHistoryFilePath(serial);
            
            if (!File.Exists(filePath))
            {
                return null;
            }

            return File.ReadAllLines(filePath);
        }
        #endregion

        #region 私有方法
        /// <summary>
        /// 获取用户数据根目录
        /// </summary>
        /// <returns>用户数据根目录路径</returns>
        private static String GetUserDataRootPath()
        {
            String rootPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DotMaysWind.SSDMonitor");

            if (!Directory.Exists(rootPath))
            {
                Directory.CreateDirectory(rootPath);
            }

            return rootPath;
        }

        /// <summary>
        /// 获取硬盘历史记录文件名
        /// </summary>
        /// <param name="serial">硬盘序列号</param>
        /// <returns>硬盘历史记录文件名</returns>
        private static String GetHDDHistoryFilePath(String serial)
        {
            String fileName = String.Format("{0}.log", serial);

            return Path.Combine(GetUserDataRootPath(), fileName);
        }
        #endregion
    }
}