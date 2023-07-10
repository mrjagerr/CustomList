using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using CustomList;






namespace CustomListTests
{
    [TestClass]
    public class AddMethodTests
    {





        [TestMethod]
        public void AddMethod_CountIncrements_FirstitemZero()
        {
            //arrange
            CustomList<string>firstList = new CustomList<string>();
            string bob = "Bob";

            //act
            firstList.Add(bob);

            //assert
            Assert.AreEqual(bob, firstList[0]);

        }

        [TestMethod]
        public void AddMethod_CountIncrements_SeconditemOne()
        {
            //arrange
            CustomList<string> firstList = new CustomList<string>();
            string bob = "Bob";
            string link = "Link";
            //act
            firstList.Add(bob);
            firstList.Add(link);
            //assert
            Assert.AreEqual(link, firstList[1]);
        }


        [TestMethod]
        public void AddMethod_CountIncrements_Thirditemtwo()
        {
            //arrange
            CustomList<string> firstList = new CustomList<string>();
            string bob = "Bob";
            string link = "Link";
            string zelda = "Zelda";
            //act
            firstList.Add(bob);
            firstList.Add(link);
            firstList.Add(zelda);

            //assert
            Assert.AreEqual(zelda, firstList[2]);

        }

        [TestMethod]
        public void AddMethod_CountIncrements_ItemExceedsCapacity()
        {
            //arrange
            CustomList<string> firstList = new CustomList<string>();
            string bob = "Bob";
            string link = "Link";
            string zelda = "Zelda";
            string ganon = "Ganon";
            string juju = "Juju";
                
            //act
            firstList.Add(bob);
            firstList.Add(link);
            firstList.Add(zelda);
            CustomList<string> secondList = firstList;
            
            secondList.Add(juju);
            //assert
            Assert.AreEqual(8,secondList.Capacity);

        }

        [TestMethod]
        public void AddMethod_CountIncrements_()
        {
            //arrange
            CustomList<string> firstList = new CustomList<string>();
            string bob = "Bob";
            string link = "Link";
            string zelda = "Zelda";
            string ganon = "Ganon";
            string juju = "Juju";
            //act
            CustomList<string> secondList = firstList;
            firstList.Add(bob);
            firstList.Add(link);
            firstList.Add(zelda);
            firstList.Add(ganon);
            firstList.Add(juju);

            //assert
            Assert.AreEqual(5, secondList.Count);
        }
        [TestMethod]
        public void AddMethod_CountIncrements_Objectinsecondlsit()
        {
            //arrange
            CustomList<string> firstList = new CustomList<string>();
            string bob = "Bob";
            string link = "Link";
            string zelda = "Zelda";
            string ganon = "Ganon";
            string juju = "Juju";
            string joey = "Joey";
            //act
            
            
            firstList.Add(bob);
            firstList.Add(link);
            firstList.Add(zelda);
            CustomList<string> secondList = firstList;
            firstList.Add(ganon);
            firstList.Add(juju);
            firstList.Add(joey);
             
            //assert
            Assert.AreEqual(secondList, firstList);
        }

        [TestMethod]
        public void AddMethod_CountIncrements_NewArray_ItemsStayConsitant()
        {
            //arrange
            CustomList<string> firstList = new CustomList<string>();
           
            
            string bob = "Bob";
            string link = "Link";
            string zelda = "Zelda";
            string ganon = "Ganon";
            string juju = "Juju";
            string joey = "Joey";

            //act
            firstList.Add(bob);
            firstList.Add(link);
            firstList.Add(zelda);
            firstList.Add(ganon);
            firstList.Add(juju);
            firstList.Add(joey);




            //assert
            Assert.AreEqual(5, firstList.Capacity);
        }
    }    


}