using System;

namespace Projects
{
    class Program
    {
        
        //modifier return_type fun_name(parameters)
        public static void hello()
        {
            Console.WriteLine("Bhoom you have called your first function");
        }

        public static void alter(double yet)// call by value
        {
            Console.WriteLine("What i get: "+yet);
            yet-=(yet*0.100);
            Console.WriteLine("Confirm in alter: "+yet);
        }

        public static void change(double[] yet)// call by refernce
        {
            Console.WriteLine("What i get in 2nd index: "+yet[2]);
            yet[2]+=(yet[2]*0.100);
            Console.WriteLine("Confirm in alter in 2nd index: "+yet[2]);
        }
        
        static void Main(string[] react)
        {
            //Program.hello();
            double[] wind={10.5,7.2,12.6,0.08,4.1,7.2,8.8};

            Program.change(wind);

            Console.WriteLine("After change called 2nd index in main: "+wind[2]);

            double hai=9.2;
            Program.alter(2.3);
            Program.alter(hai);
            Console.WriteLine("Hai in Main: "+hai);
            Program.alter(wind[0]);
            Console.WriteLine(wind[0]+" index value in main");
        }
    }   
}
