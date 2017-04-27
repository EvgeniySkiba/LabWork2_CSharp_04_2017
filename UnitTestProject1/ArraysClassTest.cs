using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Labwork2;
using System.Diagnostics;

namespace UnitTestProject1
{
    [TestClass]
    public class ArraysClassTest
    {
        int sizeFirst = 5;
        int sizeSecond = 10;
        ArraysClass array;

        [TestInitialize]
        public void TestInitialise()
        {
            Debug.Write("Test initialize");
            array = new ArraysClass(sizeFirst, sizeSecond);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Debug.Write("Test cleanup");
        }

        [TestMethod]
        public void IsPrime_Test()
        {
            int[] firstArray = { 1, 3, 5, 7 };
            array.FirstArray = firstArray;

            Assert.IsNotNull(array.FirstArray);

            int firstNum = array.getCountSimpleDigitsFromFirstArray();
            Assert.AreEqual(firstNum, firstArray.Length);
        }

        [TestMethod]
        public void IsPrime_EmptyResult_Test()
        {
            int[] firstArray = { 0, 2, 4, 6 };
            array.FirstArray = firstArray;

            Assert.IsNotNull(array.FirstArray);

            int firstNum = array.getCountSimpleDigitsFromFirstArray();
            Assert.AreEqual(firstNum, 0);
        }

        [TestMethod]
        public void IsPrime_FisrtArrBiggerThanSecond()
        {
            int[] firstArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] secondArray = { 1, 3, 5 };

            array.FirstArray = firstArray;
            array.SecondArray = secondArray;

            int firstNum = array.getCountSimpleDigitsFromFirstArray();
            int secondNum = array.getCountSimpleDigitsFromSecondArray();

            int res = firstNum - secondNum;
            Assert.IsTrue(res > 0);
        }

        [TestMethod]
        public void IsPrime_SecondArrBiggerThanFirst()
        {

            int[] firstArray = { 1, 3, 5 };
            int[] secondArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            array.FirstArray = firstArray;
            array.SecondArray = secondArray;

            int firstNum = array.getCountSimpleDigitsFromFirstArray();
            int secondNum = array.getCountSimpleDigitsFromSecondArray();

            int res = firstNum - secondNum;
            Assert.IsFalse(res > 0);
        }


        [TestMethod]
        public void IsPrime_SecondArrEqualFirst()
        {
            int[] firstArray = { 1, 3, 5 };
            int[] secondArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            array.FirstArray = firstArray;
            array.SecondArray = secondArray;

            int firstNum = array.getCountSimpleDigitsFromFirstArray();
            int secondNum = array.getCountSimpleDigitsFromSecondArray();

            int res = firstNum - secondNum;
            Assert.IsTrue(firstNum == secondNum);
        }
    }
}
