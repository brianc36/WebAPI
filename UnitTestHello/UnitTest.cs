using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloData;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer;

namespace UnitTestHello
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestHelloValue()
        {
            var valueContext = new HelloValue();
            Assert.AreEqual(valueContext.GetMessage(), "Hello World");

        }

        [TestMethod]
        public void TestHelloContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<HelloContext>();
            optionsBuilder.UseSqlServer("Server = localhost\\BCNET; Database = Hello; Trusted_Connection = True;");
            using (var helloContext = new HelloContext(optionsBuilder.Options))
            {
                Assert.AreEqual(helloContext.Messages.Find(1).Message, "Hello World!!!");

            }


        }
    }
}
