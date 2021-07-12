using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            
            LinkedList<Int32> link=new LinkedList<Int32>();
            link.AddLast(90);link.AddLast(120);link.AddLast(90);
            link.AddFirst(500);

            foreach (var item in link)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(link.Last.Value);

            link.RemoveFirst();
            link.RemoveLast();

            IEnumerator enumerator=link.GetEnumerator();

            Console.WriteLine("Iterate via enum");
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            link.Remove(120);

            Console.WriteLine(link.Contains(120));

            /* 
            List<Object> list=new List<Object>();

            list.Add(12);list.Add("Zealous");
            list.Add(false);list.Add(8.9);
            list.Add('R');

            Console.WriteLine("Object @ 3rd index: "+(list[3]));

            list.RemoveAt(4);

            
            list.Insert(1,"Razak Mohamed");

            Console.WriteLine("Object @ 1st: "+list[1]);
            
            Console.WriteLine(list.Contains("Zealous"));

            Console.WriteLine(list.Count);

            //list.Sort();


            foreach (Object item in list)
            {
                Console.WriteLine(item);
            } */

            

        }
    }
}
