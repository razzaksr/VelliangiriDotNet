using System;
using System.Threading;

namespace Multithreading
{
    class DemoNotRunnable
    {
        int cash=3000;
        public void deposit()
        {
            lock(this)
            {
                Console.WriteLine("Put your money to deposite "+Thread.CurrentThread.Name);
                int users=Int32.Parse(Console.ReadLine());
                cash+=users;
                Console.WriteLine(users+" cash deposited by "+Thread.CurrentThread.Name);
                Thread.Sleep(5000);
            }
        }

        public void withdraw()
        {
            Console.WriteLine("Enter the amount to withdraw "+Thread.CurrentThread.Name);
                int users=Int32.Parse(Console.ReadLine());
                if(users>4000)
                {
                    Console.WriteLine(Thread.CurrentThread.Name+" will be suspended due to over limit withdrawl");
                    Thread.Sleep(1000);
                }
                else{
                cash-=users;
                Console.WriteLine(users+" cash withdrawn by "+Thread.CurrentThread.Name);
                }
            
        }
    }
}