using CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListTestbyJaron
{
    [TestClass]
    public class StringMethodOverride
    {
        [TestMethod]
        public void stringmethod_listofstringsreturns_expectedresults()
        {
            //arrange
            CustomList<int> mylist = new CustomList<int>();
            //Act
            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3);
            //Assert
            Assert.AreEqual(mylist.Count[1]);
        }
        public void stringmethod_secondlist_longerthenfirst()
        {


        }
    }
}
