using TestXSIS.Data;

namespace TestXSIS.nUnits
{
    public class Tests
    {
        private TestXSIS.Controllers.MovieController _TestXsis { get; set; } = null!;
        private TestXSIS.Data.MysqlDBContext _MysqlDBContext { get; set; } = null!;
        [SetUp]
        public void Setup()
        {
            _TestXsis = new TestXSIS.Controllers.MovieController();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}