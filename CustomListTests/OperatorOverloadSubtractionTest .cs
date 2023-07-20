using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using CustomList;






namespace CustomListTests
{
    [TestClass]
    public class OperatorOberloadSubtractionTest
    {


        [TestMethod]
        public void FirstList_Longer_Sub()
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
            firstList.Add(two);


            secondList.Add(two);
            secondList.Add(four);
            secondList.Add(six);

            secondList.Remove(six);

            bool firstGreaterThanSecond = false;
            if (firstList.Count >= secondList.Count)
            {
                firstGreaterThanSecond = true;

            }


            //assert
            Assert.AreEqual(firstGreaterThanSecond, true);

        }

        [TestMethod]
        public void SecondList_Longer_Sub()
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
            

            secondList.Add(one);
            secondList.Add(two);
            secondList.Add(four);
            secondList.Add(six);
            
            
            thirdList = firstList + secondList;

            bool firstLessThenSecond = false;
            if (firstList.Count <= secondList.Count)
            {
                firstLessThenSecond = true;

            }


            //assert
            Assert.AreEqual(firstLessThenSecond, true);

        }
        [TestMethod]
        public void SecondList_empty_Sub()
        
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
                firstList.Add(six);


              secondList.Add(0);
              secondList.Add(0);
              secondList.Add(0);
              secondList.Add(0);



            thirdList = firstList + secondList;
            string resultsOne = firstList.ToString();
            string resultsTwo = thirdList.ToString();




            //assert
            Assert.AreEqual(resultsOne, resultsTwo);

        }
        [TestMethod]
        public void Seconnd_List_Remove()

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
            firstList.Add(six);


            secondList.Add(0);
            secondList.Add(0);
            secondList.Add(0);
            secondList.Add(six);



            thirdList = firstList - secondList;
            string resultsOne = 135.ToString();
            string resultsTwo = thirdList.ToString();




            //assert
            Assert.AreEqual(resultsOne, resultsTwo);



        }
        [TestMethod]
        public void Seconnd_List_Remove_Multiple_Numbers()

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
            secondList.Add(one);
            secondList.Add(six);

            thirdList = firstList - secondList;
         
            string resultsTwo = thirdList.ToString();

            //assert
            Assert.AreEqual("35", resultsTwo);



           

        }








    }
    
}