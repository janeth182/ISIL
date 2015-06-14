using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CalculosHelper helper = new CalculosHelper();
            int result = helper.Add(20, 10);
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            CalculosHelper helper = new CalculosHelper();
            int result = helper.Substract  (20, 10);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            CalculosHelper helper = new CalculosHelper();
            int result = helper.Div(20, 10);
            Assert.AreEqual(2, result);
        }


    }
}
