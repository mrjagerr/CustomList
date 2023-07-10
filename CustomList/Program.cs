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


            CustomList<string> firstList = new CustomList<string>();
            Console.WriteLine(firstList.Count);
           Console.WriteLine(firstList.Capacity);
            firstList.Add("1");
            Console.WriteLine(firstList[0]);



























        }
    }
}