using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TitkovAA.Sprint3.Review.V5.Lib;
namespace Tyuiu.TitkovAA.Sprint3.Review.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            int StartVal = -5, stopVal = 5;
            int length = stopVal - StartVal + 1;
            double[] valexpectarr = new double[length];
            valexpectarr = new double[length];
            valexpectarr[0] = 70;
            valexpectarr[1] = 55;
            valexpectarr[2] = 41;
            valexpectarr[3] = 28;
            valexpectarr[4] = 15;
            valexpectarr[5] = 1;
            valexpectarr[6] = -13;
            valexpectarr[7] = -28;
            valexpectarr[8] = -43;
            valexpectarr[9] = -57;
            valexpectarr[10] = -70;
            CollectionAssert.AreEqual(valexpectarr, dt.GetMassFunction(StartVal, stopVal));

        }
    }
}
