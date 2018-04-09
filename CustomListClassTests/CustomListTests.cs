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
            actual = listName.ElliesCount;

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
    }
}
