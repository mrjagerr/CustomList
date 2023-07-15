
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

namespace CustomList
{
    public class CustomList<T>
    {
        //Member Variables (HAS A)
        private  T[] items;
        private int capacity;
        private int count;
        private T itemsInList;
        
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
        public T ItemsInList
        {
            get { return itemsInList;}
            set { }

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
            items[count++]=item;



            if (count == capacity)
            {
                List<T> list = new List<T>();
                list.AddRange(items);
                capacity = capacity * 2;
                items = new T[capacity];
                list.CopyTo(items);
            }
           
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
            List<T> listOne = new List<T>();
            listOne.AddRange(firstList.items);
            listOne.AddRange(secondList.items);
            CustomList<T> combinedList = new CustomList<T>();
            

            combinedList.items = new T[firstList.capacity + secondList.capacity];
            listOne.CopyTo(combinedList.items);

            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
            return combinedList;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            return null;
        }


    }
}
