using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int number=120;// init
            while(number<=100)//cond
            {
                Console.WriteLine(number);number++;//iter
            } */
            /* int number=120;// init
            do
            {
                Console.WriteLine(number);number++;//iter
            }while(number<=100);//cond */
            /* for(int number=120;number<=100;number++)
            {
                Console.WriteLine(number);
            } */
            
            
            int available=36, billCount=0, billCollection=0;

            while(available>0)
            {
                Console.WriteLine("Welcome to RR Biriyani booking");
                int count=Int32.Parse(Console.ReadLine());
                if(count<=available)
                {
                    Console.WriteLine("u can have ur meal "+count);
                    Console.WriteLine("Ur bill "+(count*80)+" for "+count+" of meals");
                    available-=count;//iter
                    billCount++;
                    billCollection+=(count*80);
                }
                else
                {
                    Console.WriteLine("meals are over");
                }
            }
            Console.WriteLine("Total sale bill: "+billCount+" total collection "+billCollection);
        }
    }   
}
