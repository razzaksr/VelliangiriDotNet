using System;
using System.Threading;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1=new Thread(new ThreadStart(DemoPriorities.otp));
            Thread thread2=new Thread(new ThreadStart(DemoPriorities.otp));
            Thread thread3=new Thread(new ThreadStart(DemoPriorities.otp));
            Thread thread4=new Thread(new ThreadStart(DemoPriorities.otp));
            thread1.Name="Oreo";thread2.Name="Gingerbread";thread3.Name="Icecream";
            thread4.Name="Donut";
            thread1.Priority=ThreadPriority.Lowest;
            thread2.Priority=ThreadPriority.AboveNormal;
            thread3.Priority=ThreadPriority.Highest;
            thread4.Priority=ThreadPriority.BelowNormal;

            thread1.Start();thread2.Start();thread3.Start();thread4.Start();
            /* DemoNotRunnable demo=new DemoNotRunnable();
            Thread thread1=new Thread(new ThreadStart(demo.deposit));thread1.Name="Downey";
            Thread thread2=new Thread(new ThreadStart(demo.deposit));thread2.Name="Pratt";
            Thread thread3=new Thread(new ThreadStart(demo.deposit));thread3.Name="Scarlet";
            Thread thread4=new Thread(new ThreadStart(demo.deposit));thread4.Name="Evans";

            Thread thread5=new Thread(new ThreadStart(demo.withdraw));thread5.Name="Havard";
            Thread thread6=new Thread(new ThreadStart(demo.withdraw));thread6.Name="Helmsworth";
            Thread thread7=new Thread(new ThreadStart(demo.withdraw));thread7.Name="Hiddleson";
            Thread thread8=new Thread(new ThreadStart(demo.withdraw));thread8.Name="Holland";

            //thread1.Start();thread2.Start();thread3.Start();thread4.Start();
            thread5.Start();thread6.Start();thread7.Start();thread8.Start();
            try{thread5.Abort();thread6.Abort();thread7.Abort();thread8.Abort();}
            catch(ThreadAbortException ex){Console.WriteLine("Thread aborted");} */

            /* Thread thread1=new Thread(new ThreadStart(DemoIntro.list));
            thread1.Name="Apple Pie";
            Thread thread2=new Thread(new ThreadStart(DemoIntro.list));
            thread2.Name="Kitkat";
            Thread thread3=new Thread(new ThreadStart(DemoIntro.list));
            thread3.Name="Nogut";
            Thread thread4=new Thread(new ThreadStart(DemoIntro.list));
            thread4.Name="Cupcake";
            thread1.Start();thread1.Join();// thread safty
            thread2.Start();thread2.Join();
            thread3.Start();thread3.Join();
            thread4.Start();

            DemoIntro demo=new DemoIntro();
            Thread thread5=new Thread(new ThreadStart(demo.update));
            thread5.Name="Lollipop";
            Thread thread6=new Thread(new ThreadStart(demo.update));
            thread6.Name="Marshmallow";
            Thread thread7=new Thread(new ThreadStart(demo.update));
            thread7.Name="Jellybean";
            thread5.Start();thread6.Start();thread7.Start(); */
        }
    }
}
