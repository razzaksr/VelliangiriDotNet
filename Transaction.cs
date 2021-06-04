using System;
namespace Projects
{
    class Transaction
    {
        int[] yet=new int[10];
        public int[] getYet()
        {
            return yet;
        }
        public void newTrans(int value)
        {
            for(int index=0;index<yet.Length;index++)
            {
                if(yet[index]==0)
                {
                    yet[index]=value;
                    Console.WriteLine("Transaction done");
                    break;
                }
            }
        }
        public override string ToString()
        {
            String hai="";
            foreach(int tmp in yet)
            {
                hai+=tmp+" ";
            }
            return hai;
        }
    }
}