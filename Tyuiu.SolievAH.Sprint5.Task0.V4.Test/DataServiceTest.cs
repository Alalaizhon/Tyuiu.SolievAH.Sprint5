using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SolievAH.Sprint5.Task0.V4.Lib;

namespace Tyuiu.SolievAH.Sprint5.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\katag\source\repos\Tyuiu.SolievAH.Sprint5\Tyuiu.SolievAH.Sprint5.Task0.V4\bin\Debug\OutOutFileTask0.txt";

            FileInfo fileinfo = new FileInfo(path);

            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, true);
        }
    }
}
