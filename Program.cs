using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int start=Int32.Parse(Console.ReadLine());
            int end=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Prime series for "+start+" to "+end);
            for(;start<=end;start++)
            {
                //Console.WriteLine("Loop for "+start);
                if(start==2||start==3||start==5||start==7||start%2!=0&&start%3!=0&&start%5!=0&&start%7!=0)
                {
                    Console.WriteLine(start);
                }
            } */
            // nested loop for multiplication tables
            /* for(int tab=1;tab<=10;tab++)
            {
                Console.WriteLine("Table "+tab);
                for(int number=1;number<=10;number++)
                {
                    Console.WriteLine(number+" X "+tab+" = "+(number*tab));
                }
            } */

            // nested loop realtime
            for(int house=1;house<=10;house++)
            {
                Console.WriteLine("Tell us person in "+house+" house");
                int count=Int32.Parse(Console.ReadLine());
                for(int person=1;person<=count;person++)
                {
                    Console.WriteLine("Tell us age: ");
                    int age=Int32.Parse(Console.ReadLine());
                    if(age>=45)
                    {
                        Console.WriteLine("Vaccine must for "+person+" @ "+house);
                    }
                    else
                    {
                        Console.WriteLine("No need");
                    }
                }
            }
        }
    }   
}
