using System;
namespace ExceptionHandling
{
    class Intro
    {
        String resource="Velliangiri";
        public void extract()
        {
            try
            {
                int pos=Int32.Parse(Console.ReadLine());
                Console.WriteLine(resource[pos]);
            }
            catch(IndexOutOfRangeException ir)
            {
                Console.WriteLine(ir);
                Console.WriteLine("Please provide position within "+resource.Length);
                int pos=Int32.Parse(Console.ReadLine());
                Console.WriteLine(resource[pos]);
            }
            Console.WriteLine("Letter extracted");
        }
    }
}