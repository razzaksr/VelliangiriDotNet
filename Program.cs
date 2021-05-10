using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cost={14900,56000,21000,31999,3400,1999,8999,10999};
            Console.WriteLine("Tell us index to read: ");
            int pos=Int32.Parse(Console.ReadLine());
            Console.WriteLine(cost[pos]+" is cost in "+pos+" position");
            /* double[] feed=new double[10];
            int index=4;
            while(index<feed.Length-2)
            {
                Console.WriteLine("Enter the value @ "+index);
                feed[index]=Double.Parse(Console.ReadLine());
                index++;
            }
            foreach(double third in feed)
            {
                Console.WriteLine(third);
            } */
            /* String[] yet={"Hayato","Kelly","Alok","Maxim","Andrews"};
            Console.WriteLine(yet.Length);
            Console.WriteLine(yet);
            /* for(int index=2;index<yet.Length-1;index++)
            {
                Console.WriteLine(yet[index]);
            } 

            foreach(String third in yet)
            {
                Console.WriteLine(third);
            } */
        }
    }   
}
