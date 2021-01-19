using System;
using System.Collections.Generic;

namespace FinalExamSecondAnswer
{
    public class Program
    {
       public static void Main(string[] args)
        {
            MyGenericClass<int> obj = new MyGenericClass<int>();
            obj.AddItem(5);
            obj.AddItem(2);
            obj.AddItem(4);
            obj.AddItem(1);
            obj.AddItem(3);

            Console.WriteLine($"Item at index 3 is {obj.GetItem(3)}");
            List<int>  mysortedlist=obj.SortedItems();
            mysortedlist.Reverse();
            foreach(var x in mysortedlist)
            {
                Console.WriteLine(x);
            }



        }
    }

    public class MyGenericClass <T> where T:struct
    {
        private List<T> mylist= new List<T>();

        public void AddItem(T item)
        {
            mylist.Add(item);
        }

        public T GetItem(int index)
        {
            return mylist[index];
        }

        public List<T> SortedItems()
        {
            mylist.Sort();
            return mylist;
        }
    }

}
