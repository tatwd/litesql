using System;
using System.Linq;
using System.Xml.Serialization;

namespace LiteSql
{
    [Serializable]
    public class LiteSqlConfig
    {
        public QueryObject[] QueryObjectGroup { get; set; }

        public QueryObject GetQueryObject(string key) =>
            QueryObjectGroup.FirstOrDefault(i=> i.Key == key);
    }
}