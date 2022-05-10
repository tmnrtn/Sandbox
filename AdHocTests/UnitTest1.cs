using EFModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdHocTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cxtFact = new SystemContextFactory();
            var cxt = cxtFact.CreateDbContext(null);



        }
    }
}