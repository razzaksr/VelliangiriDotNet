using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            //SortedList
            SortedList<long,String> list=new SortedList<long, string>();
            list.Add(9876567887612,"Razak Mohamed");list.Add(8765567834,"Sabarinathan");
            list.Add(111111111111,"Rajiya Mohamed");list.Add(876556734345,"Manikandan");
            list.Add(774586544556,"Balaji");list.Add(12345687654,"Mahesh");

            Console.WriteLine(list.IndexOfKey(111111111111));

            Console.WriteLine(list.IndexOfValue("Razak Mohamed"));

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            /* 
            // Dictionary
            Dictionary<String,Int64> contact=new Dictionary<string, long>();
            contact.Add("Zealous",9597334782);contact.Add("Sheik",987656787644);
            contact.Add("Manikandan",7656789876);contact.Add("Academy",9597334782);
            contact.Add("Zealous Tech Corp",1111111111);contact.Add("Sabari",9876567834);

            contact.Remove("Zealous");

            foreach (var item in contact)
            {
                Console.WriteLine(item);
            } */

            /* 
            // Hashtable
            Hashtable table=new Hashtable();
            table.Add("Java",8000);table.Add("ASP",12000);
            table.Add("PHP",12000);table.Add("C#",8000);
            table.Add("DJango",16000);table.Add("Python",9000);

            Console.WriteLine(table.ContainsKey("SpringBoot"));
            Console.WriteLine(table.ContainsValue(12000));

            table.Remove("PHP");

            Console.WriteLine(table.ContainsValue(12000));

            ICollection items=table.Keys;
            foreach (var item in items)
            {
                Console.WriteLine("Key is "+item);
            }

            items=table.Values;
            foreach (var item in items)
            {
                Console.WriteLine("Value is "+item);
            } */
        }
    }
}
