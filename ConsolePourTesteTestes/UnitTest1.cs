using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsolePourTesteTestes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int i = 1;
            int j = 2;
            Assert.AreEqual(3, i + j);
        }
        [TestMethod]
        public void TestMethodAge()
        {
            var dateNaissance = new DateTime(2010,5,1);
            
            Assert.IsTrue(
                DateTime.Today.Subtract(dateNaissance).Days/365 > 10);
        }
    }
}
