﻿using CustomList;
using System;
using System.Security.Cryptography.X509Certificates;

namespace CustomListTestbyJaron
{
    public class removeMethodtest
    {
        [TestMethod]
        public void removemethod_countdecreaseswhenanitem_isremoved()
        {
            //arrange
            CustomList<int> mylist = new CustomList<int>();
            mylist.Add(2);
            mylist.Add(4);
            //Act
            mylist.Remove(2);
            //Assert
            Assert.AreEqual(1, mylist.Count);
        }
        public void removemethod_methodreturnstruewhenitemisremoved()
        {
            //arrange
            CustomList<string> mylist = new CustomList<string>();
            //Act
            return mylist.Remove(Items);
            //Assert
            Assert.AreEqual(1, mylist.Items);
        }
        public void removemethod_countdecrement_removeanitemnot_customlist()
        {
            //arrange
            CustomList<int> mylist = new CustomList<int>();
            //Act
            mylist.Remove(item);
            //Assert
            Assert.AreEqual(4, mylist.Items);
        }
        public void removemethod_itemshiftsbackwards_filltheindexwithremoveditem()
            //arrange
    }
}
