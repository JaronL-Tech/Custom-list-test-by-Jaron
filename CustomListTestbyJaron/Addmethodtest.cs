using CustomList;
using System;
using System.Security.Cryptography.X509Certificates;

namespace CustomListTestbyJaron
{
    [TestClass]
    public class Addmethodtest
    {
        [TestMethod]
        public void addMethod_AddTwoItems_SecondItemAtIndexOne()
        {
            //arrange
            CustomList<string> mylist = new CustomList<string>();

            //Act
            mylist.Add("hello");
            mylist.Add("world");
            
            
            //Assert
           
            Assert.AreEqual("world" , mylist[1]);
            
        }
        public void addMethod_Countincrements_addedItem()
        {
            //arrange
            CustomList<int> mylist = new CustomList<int>();
            //Act
            mylist.Add(mylist.Count);
            //Assert
            Assert.AreEqual(1, mylist.Count);
        }
        public void addmethod_item_atindex() 
        {
            //arrange
            CustomList<string> mylist = new CustomList<string>();
            //Act
            mylist.Add("hello");

            //Assert
            Assert.AreEqual("hello", mylist[0]);   
        } 
        public void addmethod_increasecapacity_wheneceeed()
        {
            //arrange
            CustomList<int> mylist = new CustomList<int>();
            //Act
            mylist.Add(mylist.Capacity);
            //Assert
            Assert.AreEqual(4, mylist.Capacity);
        }
        public void addmethod_Capacityincreases_whileoriginalitemspersist_insameindex()
        {
            //arrange
            CustomList<string> mylist = new CustomList<string>();
            //Act
            mylist.Add(mylist.Items);
            //Assert
            Assert.AreEqual(4, mylist.Items);
        }
    }
}