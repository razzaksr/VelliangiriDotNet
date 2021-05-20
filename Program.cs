using System;

namespace Projects
{
    class Program
    {
        public static String[] filter(String[] yet)
        {
            String[] fname=new String[yet.Length];
            for(int index=0;index<yet.Length;index++)
            {
                fname[index]=yet[index].Split(" ")[1];
            }
            return fname;
        }

        public static int clickOnIt()
        {
            Random random=new Random();
            return random.Next(999999);
        }

        public static void haiThere(int count=1) // recursive
        {
            Console.WriteLine("Hai Called @ "+count);
            if(count<10)
            {
                count++;haiThere(count);
            }
            else
                return;
        }

        public static void list(String[] hai,int index=0)
        {
            if(index>=hai.Length)
                return;
            Console.Write(hai[index]+" ");
            index++;
            list(hai,index);
        }

        static void Main(string[] react)
        {
            /* String[] cast={"Tom Holland","Chris Pratt","Robert Downey","Chris Evans","Chris Helmsworth"};
            String[] hai=Program.filter(cast);
            foreach(String tmp in hai)
            {
                Console.WriteLine(tmp);
            } */
            /* int otp=Program.clickOnIt();
            Console.WriteLine("OTP is:"+otp); */
            //haiThere();
            String[] cast={"Tom Holland","Chris Pratt","Robert Downey","Chris Evans","Chris Helmsworth"};
            Program.list(cast);
        }
    }   
}
