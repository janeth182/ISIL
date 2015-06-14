using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebasLibrary
{
    [TestFixture]

    public class TestClass2
    {
        Account source;
        Account destination;

        [SetUp]
        public void Init()
        {
            source = new Account();
            source.Deposit(5000m);

            destination = new Account();
            destination.Deposit(150m);
        }


        [Test]
        public void TransferFunds()
        {
            source.TransferFunds(destination, 100m);

            Assert.AreEqual(250m, destination.Balance);
            Assert.AreEqual(100m, source.Balance);
        }

        [Test]
        [ExpectedException(typeof(InsufficientFundsException))]
        public void TransferWithInsufficientFunds()
        {
            source.TransferFunds(destination, 300m);
        }


        [Test]
        [Ignore("Se espera que al final el Origen quede con 5000")]
        //[ExpectedException(typeof(ExceededException))]
        public void WithdrawTest()
        {
            try
            {
                source.Withdraw(3000m);
            }
            catch (ExceededException expected)
            {
            }

            Assert.AreEqual(5000m, source.Balance);
        }


        [Test]
        [Ignore("Decide how to implement transaction management")]
        public void TransferWithInsufficientFundsAtomicity()
        {
            try
            {
                source.TransferFunds(destination, 300m);
            }
            catch (InsufficientFundsException expected)
            {
            }

            Assert.AreEqual(200m, source.Balance);
            Assert.AreEqual(150m, destination.Balance);
        }



    }
}
