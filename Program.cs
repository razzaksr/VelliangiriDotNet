using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int stock=40, days=5;
            double cost=34900, collection=0.0;
            for(;stock>0&&days>0;days--)
            {
                Console.WriteLine("AC Cost: "+cost);
                Console.WriteLine("Tell us how many AC's you want "+days+" days left ");
                int qty=Int32.Parse(Console.ReadLine());
                if(qty<=stock)
                {
                    stock-=qty;
                    collection+=(qty*cost);
                    Console.WriteLine(qty+" of AC's billed @ "+days+" with amount of "+(qty*cost));
                }
                else{
                    Console.WriteLine("Only "+stock+" available");
                }
                cost-=(cost*0.075);
            }
            Console.WriteLine("Stock available after sale: "+stock);
            Console.WriteLine("Total collection: "+collection); */

            //continue,break words
            for(int seat=1;seat<=30;seat++)
            {
                if(seat==2||seat==5||seat==9||seat%3==0)
                    //break;
                    continue;
                
                Console.WriteLine("Bring the amount: ");
                int amt=Int32.Parse(Console.ReadLine());
                if(amt>=220)
                {
                    Console.WriteLine("Seat booked for you @ "+seat);
                }
                else{
                    Console.WriteLine("Insufficient to book");
                }
            }
        }
    }   
}
