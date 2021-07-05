using System;
using System.Threading;

namespace Multithreading
{
    class DemoIntro// app/process
    {
        static double[] hai={1.2,4.6,4.2,10.9,0.4,1.4,6.7,1.5,5.6,13.5};
        public static void list()
        {
            Console.WriteLine(Thread.CurrentThread.Name+" came inside");
            foreach(double tmp in hai)
            {
                Console.WriteLine(tmp);
            }
        }

        public void update()
        {
            lock(this)
            {
                Console.WriteLine(Thread.CurrentThread.Name+" came for update");
                for(int index=0;index<hai.Length;index++)
                {
                    hai[index]+=hai[index];
                    Console.WriteLine(hai[index]);
                }
            }
        }
    }
}