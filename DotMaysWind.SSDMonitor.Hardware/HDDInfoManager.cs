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

            if (!IsCurrentAdmin())
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
                searcher.Scope = new ManagementScope(@"\root\wmi");
                searcher.Query = new ObjectQuery("Select * from MSStorageDriver_FailurePredictData");
                index = 0;
                foreach (ManagementObject data in searcher.Get())
                {
                    Byte[] bytes = (Byte[])data.Properties["VendorSpecific"].Value;

                    for (Int32 i = 0; i < bytes.Length / 12; i++)
                    {
                        try
                        {
                            Int32 id = bytes[i * 12 + 2];

                            if (id == 0)
                            {
                                break;
                            }

                            Int32 flags = bytes[i * 12 + 4];
                            Byte status = (Byte)(flags & 0x1);

                            Int32 current = bytes[i * 12 + 5];
                            Int32 worst = bytes[i * 12 + 6];
                            Int32 rawdata = BitConverter.ToInt32(bytes, i * 12 + 7);

                            SmartInfo smartInfo = new SmartInfo(id, current, worst, rawdata, status);
                            listHDDs[index].AddSmartInfo(smartInfo);
                        }
                        catch
                        {
                            //Do nothing
                        }
                    }
                    index++;
                }
                #endregion

                #region S.M.A.R.T Threshold
                searcher.Query = new ObjectQuery("Select * from MSStorageDriver_FailurePredictThresholds");
                index = 0;
                foreach (ManagementObject data in searcher.Get())
                {
                    Byte[] bytes = (Byte[])data.Properties["VendorSpecific"].Value;

                    for (Int32 i = 0; i < 30; i++)
                    {
                        try
                        {
                            Int32 id = bytes[i * 12 + 2];
                            SmartInfo smartInfo = listHDDs[index][id];
                            
                            if (id == 0 || smartInfo == null)
                            {
                                continue;
                            }

                            Int32 threshold = bytes[i * 12 + 3];
                            smartInfo.InternalSetThreshold(threshold);
                        }
                        catch
                        {
                            //Do nothing
                        }
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
        private static Boolean IsCurrentAdmin()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);

            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
        #endregion
    }
}