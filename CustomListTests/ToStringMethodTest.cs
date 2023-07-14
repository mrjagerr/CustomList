using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using CustomList;






namespace CustomListTests
{
    [TestClass]
    public class ToSTringTests
    {


        [TestMethod]
        public void ToStringMethod()
        {
            //arrange
            CustomList<int> firstList = new CustomList<int>();
            
            int one = 1;
            //act
            firstList.Add(one);
             string result = firstList.ToString();

            //assert
            Assert.AreEqual("1000", result);

        }
    
  




        [TestMethod]
        public void Return_String_Result()
        {
            //arrange
            CustomList<string> firstList = new CustomList<string>();

            int one = 1;
            string bob = "Bob";
            string link = "Link";
            string zelda = "Zelda";
            //act
            firstList.Add(bob);
            firstList.Add(link);
            firstList.Add(zelda);

            string result = firstList.ToString();

            //assert
            Assert.AreEqual("Bob,Link,Zelda", result);

        }
    }
}