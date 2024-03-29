using System;
using Xunit;

namespace LiteSql.Tests
{
    public class SerializerTest
    {
        [Fact]
        public void Serialize_LiteSqlConfig_FromXml_Ok()
        {
            LiteSerializer serializer = new LiteSerializer();
            LiteSqlConfig config = serializer.FromXml<LiteSqlConfig>("./litesql.xml");
            Assert.NotNull(config);
        }

        [Fact]
        public void GetQueryObjectGroup_Ok()
        {
            LiteSerializer serializer = new LiteSerializer();
            LiteSqlConfig config = serializer.FromXml<LiteSqlConfig>("./litesql.xml");
            QueryObjectGroup queryObjectGroup = config.GetQueryObjectGroup("group1");
            Assert.NotNull(queryObjectGroup);
        }

        [Fact]
        public void GetQueryObject_Ok()
        {
            LiteSerializer serializer = new LiteSerializer();
            LiteSqlConfig config = serializer.FromXml<LiteSqlConfig>("./litesql.xml");
            QueryObject queryObject = config.GetQueryObjectGroup("group2")
                                            .GetQueryObject("sql3");
            Assert.NotNull(queryObject);
        }

        [Fact]
        public void GetQueryObject_For_Chinese_Ok()
        {
            LiteSerializer serializer = new LiteSerializer();
            LiteSqlConfig config = serializer.FromXml<LiteSqlConfig>("./litesql.xml");
            QueryObject queryObject = config.GetQueryObjectGroup("分组3")
                                            .GetQueryObject("查询4");
            Assert.NotNull(queryObject);
        }
    }
}
