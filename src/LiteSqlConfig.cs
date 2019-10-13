using System;
using System.Linq;
using System.Xml.Serialization;

namespace LiteSql
{
    [Serializable]
    public class LiteSqlConfig
    {
        [XmlElement("QueryObjectGroup", typeof(QueryObjectGroup))]
        public QueryObjectGroup[] QueryObjectGroups { get; set; }

        public QueryObjectGroup GetQueryObjectGroup(string key) =>
            QueryObjectGroups.FirstOrDefault(i=> i.Key == key);
    }
}