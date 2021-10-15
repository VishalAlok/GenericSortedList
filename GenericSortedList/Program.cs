using System;
using System.Collections.Generic;

namespace GenericSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string,string> obj = new SortedList<string,string>();
            obj.Add("Vishal", "Bangalore");
            obj.Add("Abhay", "Chennai");
            obj.Add("Rahul", "Hyderabad");
            obj.Add("Zak", "Pune");
            foreach (string s in obj.Keys)
            {
                Console.Write(s + " " + obj[s] + " ");
                Console.WriteLine();
            }
        }
    }
}
