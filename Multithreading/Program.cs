using System;
using System.Threading;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1=new Thread(new ThreadStart(DemoIntro.list));
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
            thread5.Start();thread6.Start();thread7.Start();
        }
    }
}
