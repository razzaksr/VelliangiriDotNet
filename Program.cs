using System;
namespace Projects
{
    class Program:Beta
    {
        public void greet()=>Console.WriteLine("Beta Wishes you lot!");

        static void Main(string[] react)
        {
            CheckSome check=new CheckSome(1119);
            check.setAccBal(230.4);check.setAccNum(764567654L);
            check.billPay(120,"EB");
            /* 
            // Class vs Interface Demo
            Alpha alpha=new Alpha();
            alpha.hello();
            //Beta beta=new Beta();
            //Program program=new Program();
            //program.greet();
            Beta beta=new Program();
            beta.greet(); */
            /* 
            // Multilevel Example
            Netbanking netbanking=new Netbanking(765456786L,23490.4);
            Console.WriteLine(netbanking);
            Console.WriteLine(netbanking+100);
            Console.WriteLine(netbanking-19800);
            Console.WriteLine(netbanking); */


        }
    }   
}
