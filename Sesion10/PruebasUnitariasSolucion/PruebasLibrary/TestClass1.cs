using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebasLibrary
{
    [TestFixture]
    public class TestClass1
    {
        [TestCase]
        public void AddTest()
        {
            CalculosHelper helper = new CalculosHelper();
            int result = helper.Add(20, 10);
            Assert.AreEqual(30, result);
        }

        [TestCase]
        public void SubstractTest()
        {
            CalculosHelper helper = new CalculosHelper();
            int result = helper.Substract(20, 10);
            Assert.AreEqual(10, result);
        }

        [TestCase]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivTest()
        {
            CalculosHelper helper = new CalculosHelper();
            int result = helper.Div(20, 0);
            Assert.AreEqual(2, result);
        }

    }
}
