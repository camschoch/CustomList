using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
using System.IO;

namespace UnitTestCustomList
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestIndexer()
        {
            CustomListClass<int> testOne = new CustomListClass<int>();
            testOne[0] = 35;
            int expectedResult = 35;

            int actualResult = testOne[0];

            Assert.AreEqual(expectedResult, actualResult);
        }

        //[TestMethod]
        //public void TestChangingArraySize()
        //{
        //    CustomListClass<int> SetArraySize = new CustomListClass<int>();
        //    //set array size by making it a variable that gets added or subratced to everytime something is changed//
        //    SetArraySize[0] = 100;
        //    int expectedResult = 100;

        //    int actualResult = SetArraySize[0];

        //    Assert.AreEqual(expectedResult, actualResult);
        //}

        //ADD METHOD//
        [TestMethod]
        public void TestListAdd()
        {
            CustomListClass<string> list = new CustomListClass<string>;
            list.Add("TestOne");
            string expectedResults = "TestOne";

            string actualResults = list[0];

            Assert.AreEqual(expectedResults, actualResults); 
        }

        [TestMethod]
        public void TestIfAddWorksWithTwo()
        {
            CustomListClass<string> list = new CustomListClass<string>;
            list.Add("TestOne");
            list.Add("TestTwo");
            int expectedResults = 2;

            int actualResults = Count(list);

            Assert.AreEqual(expectedResults, actualResults);
        }

        [TestMethod]
        public void TestListHoldValueOrder()
        {
            CustomListClass<string> list = new CustomListClass<string>;
            list.Add("TestOne");
            list.Add("TestTwo");
            string expectedResults = "TestTwo";

            string actualResults = list[1];

            Assert.AreEqual(expectedResults, actualResults);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestAddingToWrongObjectType()
        {
            CustomListClass<string> list = new CustomListClass<string>();
            list.Add("TestOne");
            list.Add(2);
        }

        //END ADD METHOD//
        //SUBTRACT METHOD//
        [TestMethod]
        public void TestIfRemoveWorks()
        {
            CustomListClass<string> list = new CustomListClass<string>();
            list.Add("TestOne");
            list.Remove("TestOne");
            int expectedResults = 0;

            int actualResults = Count(list);

            Assert.AreEqual(expectedResults, actualResults);
        }

        [TestMethod]
        public void TestRemoveOrder()
        {
            CustomListClass<string> list = new CustomListClass<string>;
            list.Add("TestOne");
            list.Add("TestTwo");
            string expectedResult = "TestTwo";
            list.Remove([0])

            string actualResult = list[1]; 
        }

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        //public void Test
        

        //END SUBTRACT METHOD//
        //CONVER TO STRING//
        [TestMethod]
        public void TestConvertIntToString()
        {
            CustomListClass<int> list = new CustomListClass<int>;
            list.Add(1);
            list.Add(2);
            list.Add(3);
            string expectedResult = "123";
            list.ConvertToString();

            string actualResult = list[1];

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestConvertToOneString()
        {
            CustomListClass<string> list = new CustomListClass<string>;
            list.Add("TestOne");
            list.Add("TestTwo");
            list.Add("TestThree");
            string Converted = list.ConvertToString();

            string expectedResult = "TestOneTestTwoTestThree";

            string actualResult = Converted;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestConvertToOneWithCommaString()
        {
            CustomListClass<string> list = new CustomListClass<string>;
            list.Add("TestOne");
            list.Add("TestTwo");
            list.Add("TestThree");
            string Converted = list.ConvertToString(",");

            string expectedResult = "TestOne,TestTwo,TestThree";

            string actualResult = Converted;

            Assert.AreEqual(expectedResult, actualResult);
        }



        //END CONVERT TO STRING//
        [TestMethod]
        public void TestAddingTwoTogether()
        {
            CustomListClass<int> list = new CustomListClass<int>;
            list.Add(1);
            list.Add(2);
            int expectedResult = 3;
            int addedNumber = list.addTwo([0], [1]);

            int actualResult = addedNumber; 
        }
    }
}
