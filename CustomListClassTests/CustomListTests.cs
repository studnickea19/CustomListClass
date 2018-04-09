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
            actual = listName.ListCount;

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
            listName.RemoveAt(0);

            //Assert
            Assert.IsFalse(listName[0] = 1);
        }

        [TestMethod]
        public void CustomListRemove_ListCount_IsZeroIfNoElements()
        {
            //Arrange
            CustomList<int> listName = new CustomList<int>();
            listName.Add(5);
            int? expected = null;
            int actual;

            //Act
            listName.RemoveAt(0);
            actual = listName.ListCount;

            //Assert  
            Assert.AreSame(expected, actual);

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
            listName.RemoveAt(1);

            //Assert
            Assert.IsTrue(listName[1] = 5);
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
            actual = listName.ListCount;

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
            actual = listName.ListCount;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
