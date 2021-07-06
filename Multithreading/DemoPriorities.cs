using System;
using System.Threading;

namespace Multithreading
{
    class DemoPriorities
    {
        public static void otp()
        {
            Console.WriteLine("OTP is "+new Random().Next(100000)+" for "+Thread.CurrentThread.Name);
        }
    }
}