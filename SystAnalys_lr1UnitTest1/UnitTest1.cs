using System;
using SystAnalys_lr1;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SystAnalys_lr1UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //исходные данные
            int [,] E = new int[,] { { 0, 1, 0, 0 }, { 1, 0, 2, 0  } , { 0, 2, 0, 4 } , { 0, 0, 4, 0 } };
            int V = 4;
            int expected = 7;
            // получение значения с помощью тестируемого метода
            Dekstra d = new Dekstra();
            int actual = d.Dijkstra(E, V);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);


        }
    }
}
