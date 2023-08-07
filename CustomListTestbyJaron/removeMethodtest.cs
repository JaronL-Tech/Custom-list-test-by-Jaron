using CustomList;
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


        }
    }
}
