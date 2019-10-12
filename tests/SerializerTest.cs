using System;
using Xunit;
using LiteSql;

namespace LiteSql.Tests
{
    public class SerializerTest
    {
        [Fact]
        public void Serialize_LiteSqlConfig_Ok()
        {
            Serializer serializer = new Serializer();
            LiteSqlConfig config = serializer.FromXml<LiteSqlConfig>("./litesql.xml");
            Assert.NotNull(config);
        }

        [Fact]
        public void GetQueryObject_Ok()
        {
            Serializer serializer = new Serializer();
            LiteSqlConfig config = serializer.FromXml<LiteSqlConfig>("./litesql.xml");
            QueryObject queryObject = config.GetQueryObject("TestSql");
            Assert.NotNull(queryObject);
        }
    }
}
