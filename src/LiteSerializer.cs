using System;
using System.IO;
using System.Xml.Serialization;

namespace LiteSql
{
    public class LiteSerializer
    {
        public T FromXml<T>(string xmlFilePath)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (var fs = new FileStream(xmlFilePath, FileMode.Open, FileAccess.Read))
                {
                    return (T)serializer.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}