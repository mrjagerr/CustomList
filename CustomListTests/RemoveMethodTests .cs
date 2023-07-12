using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using CustomList;






namespace CustomListTests
{
    [TestClass]
    public class RemoveMethodTest
    {
        [TestMethod]
        public void Remove_Item_From_List_count_Goes_Down()
        {
            //arrange
            CustomList<string> firstList = new CustomList<string>();
            string bob = "Bob";
            string link = "Link";
            string zelda = "Zelda";
            string ganon = "Ganon";
            string juju = "Juju";
            string joey = "Joey";
            firstList.Add(bob);
            firstList.Add(link);
            firstList.Add(zelda);
            firstList.Add(ganon);
            firstList.Add(juju);
            firstList.Add(joey);

            //act
           firstList.Remove(bob);




            //assert
            Assert.AreEqual(5, firstList.Count);
        }

         
        [TestMethod]
        public void Remove_Item_From_List_If_True()
        {
            //arrange
            CustomList<string> firstList = new CustomList<string>();
            string bob = "Bob";
            string link = "Link";
            string zelda = "Zelda";
            string ganon = "Ganon";
            string juju = "Juju";
            string joey = "Joey";
            firstList.Add(bob);
            firstList.Add(link);
            firstList.Add(zelda);
            firstList.Add(ganon);
            firstList.Add(juju);
            firstList.Add(joey);

            //act
            firstList.Remove(bob);
            firstList.Remove(link);



            //assert
            Assert.AreEqual(zelda, firstList[0]);
        }
        [TestMethod]
        public void Count_DoesNot_Decrease_When_item_Not_In_List()
        {
            //arrange
            CustomList<string> firstList = new CustomList<string>();
            string bob = "Bob";
            string link = "Link";
            string zelda = "Zelda";
            string ganon = "Ganon";
            string juju = "Juju";
            string joey = "Joey";
            firstList.Add(bob);
            firstList.Add(link);
            firstList.Add(zelda);
            firstList.Add(ganon);
            firstList.Add(juju);
            firstList.Add(joey);

            //act
            firstList.Remove(bob);
            firstList.Remove(link);
            firstList.Remove("Lux");


            //assert
            Assert.AreEqual(4, firstList.Count);
        }
        [TestMethod]
        public void Remove_Item_From_List_Then_List_Shifts_Backward()
        {
            //arrange
            CustomList<string> firstList = new CustomList<string>();
            string bob = "Bob";
            string link = "Link";
            string zelda = "Zelda";
            string ganon = "Ganon";
            string juju = "Juju";
            string joey = "Joey";
            firstList.Add(bob);
            firstList.Add(link);
            firstList.Add(zelda);
            firstList.Add(ganon);
            firstList.Add(juju);
            firstList.Add(joey);

            //act
            firstList.Remove(bob);
            firstList.Remove(link);



            //assert
            Assert.AreEqual(zelda,firstList[0]);
        }
        [TestMethod]
        public void Remove_Item_From_List_Then_List_Shifts_Backward_And_Only_Removes_First_Instance()
        {
            //arrange
            CustomList<string> firstList = new CustomList<string>();
            string bob = "Bob";
            string link = "Link";
            string zelda = "Zelda";
            string ganon = "Ganon";
            string juju = "Juju";
            string joey = "Joey";
            firstList.Add(bob);
            firstList.Add(link);
            firstList.Add(zelda);
            firstList.Add(ganon);
            firstList.Add(juju);
            firstList.Add(joey);
            firstList.Add(bob);

            //act
            firstList.Remove(bob);
            firstList.Remove(link);



            //assert
            Assert.AreEqual(bob, firstList[4]);
        }

    }

}




