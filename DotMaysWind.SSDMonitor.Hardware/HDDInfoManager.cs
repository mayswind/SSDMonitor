using System;
using System.Collections.Generic;
using System.Management;
using System.Security.Principal;

namespace DotMaysWind.SSDMonitor.Hardware
{
    /// <summary>
    /// 硬盘信息控制器
    /// </summary>
    public static class HDDInfoManager
    {
        #region 方法
        /// <summary>
        /// 获取所有硬盘信息
        /// </summary>
        /// <returns>硬盘信息列表</returns>
        public static HDDInfo[] GetHDDInfoList()
        {
            List<HDDInfo> listHDDs = new List<HDDInfo>();

            if (!CheckIsCurrentAdmin())
            {
                return listHDDs.ToArray();
            }

            try
            {
                Int32 index = 0;

                #region HDD Info
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
                foreach (ManagementObject drive in searcher.Get())
                {
                    HDDInfo hddInfo = new HDDInfo(drive);
                    listHDDs.Add(hddInfo);
                }
                #endregion

                #region S.M.A.R.T Basic
                searcher.Scope = new ManagementScope(@"root\wmi");
                searcher.Query = new ObjectQuery("SELECT * FROM MSStorageDriver_FailurePredictData");
                index = 0;
                foreach (ManagementObject obj in searcher.Get())
                {
                    Byte[] data = (Byte[])obj.Properties["VendorSpecific"].Value;

                    for (Int32 offset = 2; offset <= data.Length - 12; offset += 12)
                    {
                        Byte[] buffer = new Byte[12];
                        Buffer.BlockCopy(data, offset, buffer, 0, 12);

                        if (buffer[0] == 0)
                        {
                            break;
                        }

                        SmartInfo smartInfo = new SmartInfo(buffer);
                        listHDDs[index].AddSmartInfo(smartInfo);
                    }

                    index++;
                }
                #endregion

                #region S.M.A.R.T Threshold
                searcher.Query = new ObjectQuery("SELECT * FROM MSStorageDriver_FailurePredictThresholds");
                index = 0;
                foreach (ManagementObject obj in searcher.Get())
                {
                    Byte[] data = (Byte[])obj.Properties["VendorSpecific"].Value;

                    for (Int32 offset = 2; offset <= data.Length - 12; offset += 12)
                    {
                        Byte id = data[offset];
                        SmartInfo smartInfo = listHDDs[index][id];

                        if (id == 0 || smartInfo == null)
                        {
                            continue;
                        }

                        Byte threshold = data[offset + 1];
                        smartInfo.InternalSetThreshold(threshold);
                    }

                    index++;
                }
                #endregion
            }
            catch
            {
                //Do nothing
            }

            return listHDDs.ToArray();
        }
        #endregion

        #region 私有方法
        /// <summary>
        /// 获取当前用户是否是管理员用户
        /// </summary>
        /// <returns>当前用户是否是管理员用户</returns>
        private static Boolean CheckIsCurrentAdmin()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);

            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
        #endregion
    }
}