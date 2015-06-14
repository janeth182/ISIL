using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PruebasLibraryNET;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 helper = new Class1();
            int result = helper.Add(20, 10);
            Assert.AreEqual(30, result);
        }
    }
}
