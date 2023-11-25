using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElsufevMP.Sprint5.Task4.V20.Lib;
using System.IO;

namespace Tyuiu.ElsufevMP.Sprint5.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V20.txt";
            //string path = @"C:\Users\mihal\source\repos\Tyuiu.ElsufevMP.Sprint5\Tyuiu.ElsufevMP.Sprint5.Task4.V20\bin\Debug\InPutDataFileTask4V20";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
