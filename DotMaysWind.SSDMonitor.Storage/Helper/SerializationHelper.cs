using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace DotMaysWind.SSDMonitor.Storage.Helper
{
    /// <summary>
    /// 序列化辅助类
    /// </summary>
    internal static class SerializationHelper
    {
        /// <summary>
        /// 从文件中读取指定类型的问题
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="filePath">文件路径</param>
        /// <returns>实体内容</returns>
        internal static T LoadFromFile<T>(String filePath) where T : class
        {
            FileStream fs = null;
            XmlSerializer xs = null;
            T obj = null;

            if (!File.Exists(filePath))
            {
                return obj;
            }

            try
            {
                fs = new FileStream(filePath, FileMode.Open);
                xs = new XmlSerializer(typeof(T));

                using (XmlReader reader = XmlReader.Create(fs))
                {
                    obj = xs.Deserialize(reader) as T;
                }
            }
            catch { }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }

            return obj;
        }

        /// <summary>
        /// 存储到文件
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <param name="obj">实体内容</param>
        internal static void SaveToFile(String filePath, Object obj)
        {
            FileStream fs = null;
            XmlSerializer xs = null;

            try
            {
                fs = new FileStream(filePath, FileMode.Create);
                xs = new XmlSerializer(obj.GetType());

                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Encoding = Encoding.UTF8;
                settings.OmitXmlDeclaration = true;
                settings.NewLineChars = "\r\n";
                settings.Indent = true;
                settings.IndentChars = "  ";

                XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
                namespaces.Add(String.Empty, String.Empty);

                using (XmlWriter writer = XmlWriter.Create(fs, settings))
                {
                    xs.Serialize(writer, obj, namespaces);
                    writer.Close();
                }
            }
            catch { }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}