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
            testOne.Add(35);
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
        //COUNT METHOD//
        [TestMethod]
        public void TestCount()
        {
            CustomListClass<string> list = new CustomListClass<string>();
            list.Add("testOne");
            list.Add("testTwo");
            int expectedResult = 2;

            int actualResult = list.Count;

            Assert.AreEqual(expectedResult, actualResult);
        } 


        //END COUNT METHOD//
        //ADD METHOD//
        [TestMethod]
        public void TestListAdd()
        {
            CustomListClass<string> list = new CustomListClass<string>();
            list.Add("TestOne");
            string expectedResults = "TestOne";

            string actualResults = list[0];

            Assert.AreEqual(expectedResults, actualResults); 
        }

        [TestMethod]
        public void TestIfAddWorksWithTwo()
        {
            CustomListClass<string> list = new CustomListClass<string>();
            list.Add("TestOne");
            list.Add("TestTwo");
            int expectedResults = 2;

            int actualResults = list.Count;

            Assert.AreEqual(expectedResults, actualResults);
        }

        [TestMethod]
        public void TestListHoldValueOrder()
        {
            CustomListClass<string> list = new CustomListClass<string>();
            list.Add("TestOne");
            list.Add("TestTwo");
            string expectedResults = "TestTwo";

            string actualResults = list[1];

            Assert.AreEqual(expectedResults, actualResults);
        }

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        //public void TestAddingToWrongObjectType()
        //{
        //    CustomListClass<string> list = new CustomListClass<string>();
        //    list.Add("TestOne");
        //    list.Add(2);
        //}

        //END ADD METHOD//
        //REMOVE METHOD//
        [TestMethod]
        public void TestIfRemoveWorks()
        {
            CustomListClass<string> list = new CustomListClass<string>();
            list.Add("TestOne");
            list.Remove("TestOne");
            int expectedResults = 0;

            int actualResults = list.Count;

            Assert.AreEqual(expectedResults, actualResults);
        }

        [TestMethod]
        public void TestRemoveOrder()
        {
            CustomListClass<string> list = new CustomListClass<string>();
            list.Add("TestOne");
            list.Add("TestTwo");
            string expectedResult = "TestTwo";
            list.Remove("TestOne");

            string actualResult = list[0];

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestRemoveOrderTwo()
        {
            CustomListClass<string> list = new CustomListClass<string>();
            list.Add("TestOne");
            list.Add("TestTwo");
            list.Add("TestThree");
            string expectedResult = "TestThree";
            list.Remove("TestOne");

            string actualResult = list[1];

            Assert.AreEqual(expectedResult, actualResult);
        }

        //[TestMethod]
        //public void TestRemoveAndPlaceInNewValue()
        //{
        //    CustomListClass<string> list = new CustomListClass<string>();
        //    list.Add("TestOne");
        //    list.Add("TestTwo");
        //    string expectedResult = "TestTwo";
        //    string temp = list.Remove("TestTwo");

        //    string actualResult = temp;

        //    Assert.AreEqual(expectedResult, actualResult);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        //public void Test


        //END REMOVE METHOD//
        //CONVER TO STRING//
        [TestMethod]
        public void TestConvertIntToString()
        {
            CustomListClass<int> list = new CustomListClass<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            string expectedResult = "123";

            string actualResult = list.ToString();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestConvertToOneString()
        {
            CustomListClass<string> list = new CustomListClass<string>();
            list.Add("TestOne");
            list.Add("TestTwo");
            list.Add("TestThree");
            string expectedResult = "TestOneTestTwoTestThree";

            string actualResult = list.ToString();

            Assert.AreEqual(expectedResult, actualResult);
        }
        //ITERABLE//



        //END ITERABLE//

        //[TestMethod]
        //public void TestConvertToOneWithCommaString()
        //{
        //    CustomListClass<string> list = new CustomListClass<string>();
        //    list.Add("TestOne");
        //    list.Add("TestTwo");
        //    list.Add("TestThree");
        //    string Converted = list.ToString(",");

        //    string expectedResult = "TestOne,TestTwo,TestThree";

        //    string actualResult = Converted;

        //    Assert.AreEqual(expectedResult, actualResult);
        //}



        //END CONVERT TO STRING//
        //ADD/CONCAT//
        [TestMethod]
        public void TestAddingTwoInts()
        {
            CustomListClass<int> list = new CustomListClass<int>();
            list.Add(1);
            list.Add(2);
            CustomListClass<int> listTwo = new CustomListClass<int>();
            listTwo.Add(3);
            listTwo.Add(4);
            int expectedResult = 4;
            CustomListClass<int> listThree = list + listTwo;

            int actualResult = listThree.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestAddingTwoStrings()
        {
            CustomListClass<string> list = new CustomListClass<string>();
            list.Add("TestOne");
            list.Add("TestTwo");
            list.Add("testThree");
            CustomListClass<string> listTwo = new CustomListClass<string>();
            listTwo.Add("TestOne");
            listTwo.Add("TestFour");
            listTwo.Add("TestFive");
            int expectedResult = 6;
            CustomListClass<string> listThree = list + listTwo;

            int actualResult = listThree.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestAddOrder()
        {
            CustomListClass<string> list = new CustomListClass<string>();
            list.Add("TestOne");
            list.Add("TestTwo");
            list.Add("testThree");
            CustomListClass<string> listTwo = new CustomListClass<string>();
            listTwo.Add("TestOne");
            listTwo.Add("TestFour");
            listTwo.Add("TestFive");
            string expectedResult = "TestFour";
            CustomListClass<string> listThree = list + listTwo;

            string actualResult = listThree[4];

            Assert.AreEqual(expectedResult, actualResult);
        }



        //END ADD/CONCAT//
        //SUBTRACT//
        [TestMethod]
        public void TestSubtractingTwoInts()
        {
            CustomListClass<int> list = new CustomListClass<int>();
            list.Add(1);
            list.Add(2);
            CustomListClass<int> listTwo = new CustomListClass<int>();
            listTwo.Add(2);
            listTwo.Add(3);
            int expectedResult = 1;
            CustomListClass<int> listThree = list - listTwo;

            int actualResult = listThree.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestSubtract()
        {
            CustomListClass<string> list = new CustomListClass<string>();
            list.Add("TestOne");
            list.Add("TestTwo");
            list.Add("testThree");
            CustomListClass<string> listTwo = new CustomListClass<string>();
            listTwo.Add("TestOne");
            listTwo.Add("TestFour");
            listTwo.Add("TestFive");
            int expectedResult = 2;
            CustomListClass<string> listThree = list - listTwo;

            int actualResult = listThree.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestSubtractOrder()
        {
            CustomListClass<string> list = new CustomListClass<string>();
            list.Add("TestOne");
            list.Add("TestTwo");
            list.Add("TestThree");
            CustomListClass<string> listTwo = new CustomListClass<string>();
            listTwo.Add("TestOne");
            listTwo.Add("TestFour");
            listTwo.Add("TestFive");
            string expectedResult = "TestTwo";
            CustomListClass<string> listThree = list - listTwo;

            string actualResult = listThree[0];

            Assert.AreEqual(expectedResult, actualResult);
        }
        //END SUBTRACT//
        //ZIP//
        [TestMethod]
        public void TestZipString()
        {
            CustomListClass<string> list = new CustomListClass<string>();
            list.Add("H");
            list.Add("l");
            list.Add("o");
            CustomListClass<string> listTwo = new CustomListClass<string>();
            list.Add("e");
            list.Add("l");
            string expectedResult = "e";
            CustomListClass<string> listThree = list.Zip(listTwo);

            string actualResult = listThree[1];

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestZipInt()
        {
            CustomListClass<int> list = new CustomListClass<int>();
            list.Add(1);
            list.Add(3);
            list.Add(4);
            CustomListClass<int> listTwo = new CustomListClass<int>();
            list.Add(2);
            list.Add(4);
            list.Add(6);
            int expectedResult = 2;
            CustomListClass<int> listThree = list.Zip(listTwo);

            int actualResult = listThree[1];

            Assert.AreEqual(expectedResult, actualResult);
        }

        //END ZIP//
    }
}
