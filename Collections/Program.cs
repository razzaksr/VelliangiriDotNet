using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            // Queue
            Queue<Double> line=new Queue<Double>(2);
            line.Enqueue(9.2);line.Enqueue(68.3);line.Enqueue(11.4);
            line.Enqueue(79.3);line.Enqueue(45.23);line.Enqueue(68.54);
            line.Enqueue(132.5);line.Enqueue(0.45);line.Enqueue(99031.1);
            line.Enqueue(1.345);line.Enqueue(9.123);line.Enqueue(0.3432);

            Console.WriteLine(line.Peek());

            line.Dequeue();line.Dequeue();line.Dequeue();line.Dequeue();

            foreach (var item in line)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(line.Count);


            //line.TrimExcess();

            Console.WriteLine(line.Count);
            
            /* 
            //Stack
            Stack<String> yet=new Stack<string>();
            yet.Push("React");yet.Push("Angular");
            yet.Push("Node");yet.Push("Express");
            
            //String hai=yet.ToString();

            //Console.WriteLine(hai);

            Console.WriteLine(yet.Peek());

            Console.WriteLine(yet.Pop());

            yet.Push("Java");yet.Push("SpringBoot");
            yet.Push("JPA");yet.Push("REST");

            Console.WriteLine(yet.Count);

            yet.Clear();

            String[] hai=yet.ToArray();

            foreach (var item in hai)
            {
                Console.WriteLine(item);
            }
 */
            /*
            // ArrayList
            ArrayList obj=new ArrayList();
            obj.Add("Razak Mohamed");obj.Add("Meharaj");
            obj.Add("SAbari");obj.Add("Manikandan");
            obj.Add("Senthil");obj.Add("Balaji");

            ArrayList str=new ArrayList();
            str.AddRange(obj);

            str.Insert(2,"Nathan");
            str.InsertRange(3,yet);

            foreach (var item in str)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Angular resides @ "+(str.IndexOf("Angular")));

            str.RemoveRange(6,4);

            Console.WriteLine(str.Contains("SAbari"));

            Console.WriteLine(obj.Contains("SAbari"));

            str.Sort();
            str.Reverse();

            foreach (var item in str)
            {
                Console.WriteLine(item);
            }
            */
        }
    }
}
