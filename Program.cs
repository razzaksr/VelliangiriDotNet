using System;

namespace Projects
{
    class Program
    {
        public static void outting(out double salary,out int exp)
        {
            Console.WriteLine("Your expected salary: ");
            salary=Double.Parse(Console.ReadLine());
            Console.WriteLine("Your current experience: ");
            exp=Int32.Parse(Console.ReadLine());
        } 
        public static void party(ref String yet)
        {
            String tmp=yet.Substring(2,6);
            yet=tmp;
        }
        static void Main(string[] react)
        {

            double ctc=0.0;int e=0;
            Console.WriteLine("In Main UR Salary: "+ctc+" experience: "+e);
            Program.outting(out ctc,out e);
            Console.WriteLine("In Main UR Salary: "+ctc+" experience: "+e);

            /* String mine="Salem, Tamilnadu, India";
            Console.WriteLine("mine in main: "+mine);
            Program.party(ref mine);
            Console.WriteLine("mine in main: "+mine); */
        }
    }   
}
