using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolievAH.Sprint5.Task3.V11.Lib;

namespace Tyuiu.SolievAH.Sprint5.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest

    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService resp = new DataService();
            Assert.AreEqual("-2,556", resp.SaveToFileTextData(3));
        }
    }
}
