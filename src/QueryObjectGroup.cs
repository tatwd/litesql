using System;
using System.Linq;
using System.Xml.Serialization;

namespace LiteSql
{
    [Serializable]
    public class QueryObjectGroup
    {
        [XmlAttribute]
        public string Key { get; set; }

        [XmlElement("QueryObject", typeof(QueryObject))]
        public QueryObject[] QueryObjects { get; set; }

        public QueryObject GetQueryObject(string key) =>
            QueryObjects.FirstOrDefault(i => i.Key == key);
    }
}