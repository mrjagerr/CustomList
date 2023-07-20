using System.Security.Cryptography.X509Certificates;

namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // step1 use tdd to test my methods
            //step2  utilize cutomlists T[]array items so that i can store data to the list and that when i use  the add method it will increase the capacity
            // step 3 utilize the read only capacity property
            //step 4 utilize the read only count property



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
            Console.WriteLine(resultsTwo);























        }
    }
}