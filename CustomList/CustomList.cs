﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        //Member Variables (HAS A)
        private  T[] items;
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
            //returns a single string that contains all items from array
            return "";
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
            return null;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            return null;
        }


    }
}
