using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BussinessLayer;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        FizzbuzzClass oFizz = new FizzbuzzClass();
        List<string> oList = new List<string>();
        [TestMethod]
        public void NotFizzBuzzCase()
        {
            oList = oFizz.logicFizzBuzz();
            Assert.AreEqual(oList[1].ToString(), "2");
        }


        [TestMethod]
        public void FizzCase()
        {
            oList = oFizz.logicFizzBuzz();
            Assert.AreEqual(oList[14].ToString(), "Fizz Buzz");
        }

        [TestMethod]
        public void BuzzCase()
        {
            oList = oFizz.logicFizzBuzz();
            Assert.AreEqual(oList[4].ToString(), "Buzz");
        }
    }
}
