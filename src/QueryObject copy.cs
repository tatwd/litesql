using System;
using System.Xml.Serialization;

namespace LiteSql
{
    [Serializable]
    public class QueryObject
    {
        [XmlAttribute]
        public string Key { get; set; }

        [XmlText]
        public string SqlText { get; set; }
    }
}