using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using CustomList;






namespace CustomListTests
{
    [TestClass]
    public class OperatorOberloadPlusTest
    {


        [TestMethod]
        public void FirstList_Longer()
        {
            //arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();
            CustomList<int> thirdList = new CustomList<int>();
            int one = 1;
            int two = 2;
            int three = 3;
            int four = 4;
            int five = 5;
            int six = 6;

            //act
            firstList.Add(one);
            firstList.Add(three);
            firstList.Add(five);

            secondList.Add(two);
            secondList.Add(four);
            secondList.Add(six);
          thirdList = firstList + secondList;

            //assert
            Assert.AreEqual(13502460, thirdList());

        }
    
  




    }
}