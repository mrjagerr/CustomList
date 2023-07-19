
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;
using Microsoft.VisualBasic;
using static System.Formats.Asn1.AsnWriter;

namespace CustomList
{
    public class CustomList<T>
    {
        //Member Variables (HAS A)
        private T[] items;
        private int capacity;
        private int count;


        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }

        }
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }

        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }








        //Constructor
        public CustomList()
        {
            capacity = 4;
            count = 0;
            items = new T[capacity];


        }



        //Member Methods (CAN DO)
        public void Add(T item)
        {


            if (count == capacity)
            {

                if (item != null)
                {
                    List<T> list = new List<T>();
                    list.AddRange(items);
                    capacity = capacity * 2;
                    items = new T[capacity];
                    list.CopyTo(items);



                }



            }
            items[count++] = item;


            //'item' parameter should be added to internal 'items' array
            //if items array is at capacity, double capacity and create new array
            //transfer all items to new array
        }

        public bool Remove(T item)
        {


            if (items.Contains(item))
            {

                List<T> list = new List<T>();
                list.AddRange(items);
                list.Remove(item);
                list.CopyTo(items);

                count--;
                return true;
            }

            else
            {
                Console.WriteLine("Item not in this array");
                return false;
            }




            //If 'item' exists in the 'items' array, remove its first instance
            //Any items coming after the removed item should be shifted down so there is no empty index.
            //If 'item' was removed, return true. If no item was removed, return false.

        }

        public override string ToString()
        {

            var result = string.Empty;


            foreach (var item in items)
            {
                result += item;



            }






            //returns a single string that contains all items from array





            return result;
        }



        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {

            CustomList<T> combinedListCustomOne = new CustomList<T>();



            List<T> listOne = new List<T>();
            List<T> listTwo = new List<T>();
            List<T> listCount = new List<T>();
            List<T> finalList = new List<T>();
            foreach (T item in firstList.items)
            {
                if (item is not 0 or null)
                {
                    combinedListCustomOne.Add(item);
                    listOne.Add(item);


                }



            }
            foreach (T item in secondList.items)
            {
                if (item is not 0 or null)
                {
                    combinedListCustomOne.Add(item);
                    listTwo.Add(item);


                }

            }
            listCount.AddRange(listOne);
            listCount.AddRange(listTwo);


            foreach (T item in listCount)
            {
                if (item is not 0 or null)
                {
                    finalList.Add(item);
                }

            }


            combinedListCustomOne.items = new T[finalList.Count];

            combinedListCustomOne.items = finalList.ToArray();
            return combinedListCustomOne;

        }

        


           
            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
           
        

       

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {

            CustomList<T> combinedListCustomOne = new CustomList<T>();


;
            List<T> finalList = new List<T>();
            foreach (T item in firstList.items)
            {
                if (item is not 0 or null)
                {
                    combinedListCustomOne.Add(item);
                    finalList.Add(item);


                }



            }
         
           
            foreach (T item in secondList.items)
            {   combinedListCustomOne.Remove(item);
                finalList.Remove(item);
            }

            combinedListCustomOne.items = new T[finalList.Count];

            combinedListCustomOne.items = finalList.ToArray();









            return combinedListCustomOne;





           
           




            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
           
        }


    }
}
