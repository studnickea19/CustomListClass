using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListClassTests
{
    [TestClass]
    public class CustomListTests
    {

        //Item was added to the list
        //List count has increased
        //List index is equal to list count -1

        [TestMethod]

        public void CustomListAdd_Element_WasAddedToList()
        {
            //Arrange
            CustomList<int> listName = new CustomList<int>();
            int expected = 32;
            int actual;

            //Act
            listName.Add(expected);
            actual = listName[0];
                
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomListAdd_ListCount_IncreasedByOne()
        {
            //Arrange
            CustomList<int> listName = new CustomList<int>();
            int firstInt = 32;
            int expected = 1;
            int actual;

            //Act
            listName.Add(firstInt);
            actual = listName.ListCount();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomListAdd_ListIndex_EqualsNumberOfElementsMinusOne()
        {
            //Arrange
            CustomList<int> listName = new CustomList<int>();
            int expected = 32;
            int actual;

            //Act
            listName.Add(expected);
            actual = listName[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Capacity increase to accomodate more items

        [TestMethod]
        public void CustomListRemove_ListElement_IsNotInList()
        {
            //Arrange
            CustomList<int> listName = new CustomList<int>();
            listName.Add(1);
            listName.Add(3);
            listName.Add(5);

            //Act
            listName.Remove(1);

            //Assert
            Assert.IsFalse(listName[0] == 1);
        }

        [TestMethod]
        public void CustomListRemove_ListCount_IsZeroIfNoElements()
        {
            //Arrange
            CustomList<int> listName = new CustomList<int>();
            listName.Add(5);
            int? expected = 0;
            int actual;

            //Act
            listName.Remove(5);
            actual = listName.ListCount();

            //Assert  
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CustomListRemove_ListIndexes_ResetToFillGap()
        {
            //Arrange
            CustomList<int> listName = new CustomList<int>();
            listName.Add(1);
            listName.Add(3);
            listName.Add(5);

            //Act
            listName.Remove(3);

            //Assert
            Assert.IsTrue(listName[1] == 5);
        }

        [TestMethod]
        public void CustomListCount_ListCount_StartsAtOne()
        {
            //Arrange
            CustomList<int> listName = new CustomList<int>();
            listName.Add(64);
            int expected = 1;
            int actual;

            //Act
            actual = listName.ListCount();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CustomListCount_ListCount_IncreasesAfterEachAddedItem()
        {
            //Arrange
            CustomList<int> listName = new CustomList<int>();
            listName.Add(64);
            listName.Add(32);
            listName.Add(16);
            int expected = 3;
            int actual;

            //Act
            actual = listName.ListCount();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZipNewArray_ReturnedArray_ZippedNewItems()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            listOne.Add(64);
            listOne.Add(32);
            listOne.Add(16);
            CustomList<int> listTwo = new CustomList<int>();
            listTwo.Add(46);
            listTwo.Add(23);
            listTwo.Add(61);
            CustomList<int> expected = new CustomList<int>();
            expected.Add(64);
            expected.Add(32);
            expected.Add(16);
            expected.Add(46);
            expected.Add(23);
            expected.Add(61);
            CustomList<int> actual = new CustomList<int>();

            //Act
            actual = listOne.ZipNewArray(listOne, listTwo);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
