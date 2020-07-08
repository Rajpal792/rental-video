using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoRentalSystem_Rajpal;

namespace UnitTestProject_Rajpal
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result=VideoRentalSystem_Rajpal_Class.AdditionOfNumbers(10, 20);
            Assert.IsTrue(result == 30);
        }
    }
}
