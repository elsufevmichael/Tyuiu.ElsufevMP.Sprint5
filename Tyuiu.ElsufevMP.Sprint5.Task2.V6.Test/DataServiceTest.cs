using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.ElsufevMP.Sprint5.Task2.V6.Lib;

namespace Tyuiu.ElsufevMP.Sprint5.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\mihal\source\repos\Tyuiu.ElsufevMP.Sprint5\Tyuiu.ElsufevMP.Sprint5.Task2.V6\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
