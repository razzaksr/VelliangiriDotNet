using System;

namespace Projects
{
    class Program:Transaction
    {
        public int findDebit()
        {
            int count=0;
            for(int index=1;index<getYet().Length;index++)
            {
                if(getYet()[index]<getYet()[index-1])
                {
                    count++;
                }
            }
            return count;
        }
        public void demo()
        {
            Console.WriteLine("Derived memeber");
        }
        public override string ToString()
        {
            return base.ToString()+"\nThis is derived class";
        }
        static void Main(string[] react)
        {
            Program program=new Program();
            program.newTrans(1200);program.newTrans(400);program.newTrans(200);
            program.newTrans(5500);program.newTrans(900);program.newTrans(300);
            Console.WriteLine(program);
            program.demo();
            Console.WriteLine("No of debits is: "+program.findDebit());
        }
    }   
}
